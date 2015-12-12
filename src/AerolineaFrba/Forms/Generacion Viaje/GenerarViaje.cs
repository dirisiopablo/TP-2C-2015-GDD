using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Services;
using AerolineaFrba.Models;

namespace AerolineaFrba.Forms.Generacion_Viaje {

    public sealed partial class GenerarViaje : Form {

        // private static GenerarViaje _instance = null;

        private GenerarViaje() {
            this.InitializeComponent();
        }

        public static GenerarViaje getInstance() {

            /*if (_instance == null) {
                _instance = new GenerarViaje();
            }

            return _instance;*/
            return new GenerarViaje();

        }

        private void aeronaveCombo_SelectedIndexChanged_1(object sender, EventArgs e) {

            int aeronaveId = (int)this.aeronaveCombo.SelectedValue;

            DAO.connect();
            Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "id = " + aeronaveId });
            DAO.closeConnection();

            this.fabModeloLabel.Text = aeronave.Fabricante.Descripcion + ' ' + aeronave.Modelo.Descripcion;
            this.matriculaLabel.Text = aeronave.Matricula;
            this.tipoServicioLabel.Text = aeronave.Tipo_Servicio.Descripcion;

            this.kgLabel.Text = aeronave.Kilogramos_Disponibles.ToString();

        }

        private void rutaCombo_SelectedIndexChanged_1(object sender, EventArgs e) {

            int rutaId = (int)this.rutaCombo.SelectedValue;

            DAO.connect();
            Ruta ruta = DAO.selectOne<Ruta>(new[] { "id = " + rutaId });
            Ciudad origen = DAO.selectOne<Ciudad>(new[] { "id = " + ruta.Ciudad_Origen_Id });
            Ciudad destino = DAO.selectOne<Ciudad>(new[] { "id = " + ruta.Ciudad_Destino_Id });
            DAO.closeConnection();

            this.codigoLabel.Text = ruta.Codigo.ToString();
            this.precioKgLabel.Text = ruta.Precio_Base_Kg.ToString();
            this.precioPasajeLabel.Text = ruta.Precio_Base_Pasajes.ToString();
            this.origenLabel.Text = origen.Descripcion;
            this.destinoLabel.Text = destino.Descripcion;
            this.tipoServicioRutaLabel.Text = ruta.Tipo_Servicio.Descripcion;

        }

        private void guardarButton_Click_1(object sender, EventArgs e) {

            int aeronaveId = (int)this.aeronaveCombo.SelectedValue;
            int rutaId = (int)this.rutaCombo.SelectedValue;

            DAO.connect();
            Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "id = " + aeronaveId });
            Ruta ruta = DAO.selectOne<Ruta>(new[] { "id = " + rutaId });
            DateTime fechaSalida = fechaPicker.Value;

            String error = "";

            if (!this.validarViaje(aeronave, ruta, fechaSalida, ref error)) {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Viaje nuevoViaje = new Viaje();
            nuevoViaje.Aeronave_Id = aeronaveId;
            nuevoViaje.Ruta_Id = rutaId;
            nuevoViaje.Fecha_Salida = fechaSalida;
            nuevoViaje.Fecha_Llegada = fechaSalida; //fecha por default
            nuevoViaje.Fecha_Llegada_Estimada = fechaSalida.AddDays(1); 


            int affected = DAO.insert<Viaje>(nuevoViaje);
            DAO.closeConnection();

            if (affected != 0)
                MessageBox.Show("Nuevo viaje creado con exito.", "Nuevo viaje creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al crear nuevo viaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cancelarButton_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private bool validarViaje(Aeronave aeronave, Ruta ruta, DateTime fechaSalida, ref String error) {

            if (fechaSalida < Config.SystemConfig.systemDate) {
                error = "La fecha de salida ingresada no puede ser menor a la fecha actual.";
                return false;
            }

            if (aeronave.Tipo_Servicio_Id != ruta.Tipo_Servicio_Id) {
                error = "La aeronave seleccionada no proporciona el tipo de servicio requerido por la ruta aerea seleccionada.";
                return false;
            }

            DAO.connect();
            Viaje viaje = DAO.selectOne<Viaje>(new[] { "aeronave_id = " + aeronave.Id, "fecha_salida = '" + fechaSalida.ToString("yyyyMMdd HH:mm:ss") + "'" });
            DAO.closeConnection();

            if (viaje != null) {
                error = "La aeronave seleccionada ya ha sido previamente asignada a un viaje en la fecha seleccionada.";
                return false;
            }

            return true;

        }

        private void GenerarViaje_Load_1(object sender, EventArgs e) {

            this.rutaTableAdapter.Fill(this.gD2C2015DataSet4.Ruta);
            this.aeronaveTableAdapter.Fill(this.gD2C2015DataSet3.Aeronave);

            //trigger change
            this.aeronaveCombo.SelectedIndex = 1;
            this.rutaCombo.SelectedIndex = 1;

        }

    }
}
