using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using AerolineaFrba.Models;
using AerolineaFrba.Services;
using AerolineaFrba.Config;

namespace AerolineaFrba.Forms.Compra {
    public partial class Confirmacion : Form {

        private List<int> pasajerosIds = new List<int>();
        private List<int> butacasNumeros = new List<int>();
        private List<int> clientesIds = new List<int>();
        private List<Decimal> pesos = new List<Decimal>();
        private Aeronave selectedAeronave;
        private Viaje selectedViaje;


        public Confirmacion(List<String> detalle, List<int> pasajerosIds, List<int> butacasNumeros, List<int> clientesIds, List<decimal> pesos, Viaje v, Aeronave a) {

            this.InitializeComponent();

            this.pasajerosIds = pasajerosIds;
            this.butacasNumeros = butacasNumeros;
            this.clientesIds = clientesIds;
            this.pesos = pesos;
            this.selectedAeronave = a;
            this.selectedViaje = v;

            this.detalleTextbox.Lines = detalle.ToArray();
            this.fillCombos();

        }

        //autocompleta campos
        private void documentoTextbox_TextChanged(object sender, EventArgs e) {
            //documentos de 7 u 8 digitos
            if (this.documentoTextbox.Text.Length == 7 || this.documentoTextbox.Text.Length == 8) {

                String dni = this.documentoTextbox.Text;
                DAO.connect();
                Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = " + dni });
                DAO.closeConnection();

                if (cliente != null) {
                    this.nombreTextbox.Text = cliente.Nombre;
                    this.apellidoTextbox.Text = cliente.Apellido;
                    this.direccionTextbox.Text = cliente.Direccion;
                    this.emailTextbox.Text = cliente.Email;
                    //TODO this.fechaNacimientoPicker.Value = cliente.Fecha_Nacimiento;
                }
                else {
                    this.nombreTextbox.Text = "";
                    this.apellidoTextbox.Text = "";
                    this.direccionTextbox.Text = "";
                    this.emailTextbox.Text = "";
                }

            }
        }

        private bool hayCamposVacios() {
            return this.numeroTextbox.Text == "" ||
                   this.codigoTextbox.Text == "" ||
                   this.vencimientoTextbox.Text == "";
        }

        private void fillCombos() {

            DAO.connect();

            //medios de pago
            String connectionString = DAO.makeConnectionString(DBConfig.direccion, DBConfig.database, DBConfig.username, DBConfig.password);
            String selectCommand = "SELECT id, descripcion FROM BIEN_MIGRADO_RAFA.Medio_Pago";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

           this. medioDePagoCombo.DisplayMember = "descripcion";
            this.medioDePagoCombo.ValueMember = "id";
            this.medioDePagoCombo.DataSource = ds.Tables[0];

            //tipos tarjeta
            selectCommand = "SELECT id, descripcion FROM BIEN_MIGRADO_RAFA.Tipo_Tarjeta";
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            ds = new DataSet();

            dataAdapter.Fill(ds);

            this.tipoCombo.DisplayMember = "descripcion";
            this.tipoCombo.ValueMember = "id";
            this.tipoCombo.DataSource = ds.Tables[0];

            DAO.closeConnection();
        }

        private void medioDePagoCombo_SelectedIndexChanged(object sender, EventArgs e) {
            // 0 = efectivo
            // 1 = tarjeta
            if (this.medioDePagoCombo.SelectedIndex == 1) {
                this.numeroTextbox.Enabled = true;
                this.codigoTextbox.Enabled = true;
                this.vencimientoTextbox.Enabled = true;
                this.tipoCombo.Enabled = true;
                this.cuotasCombo.Enabled = true;
            }
            else {
                this.numeroTextbox.Enabled = false;
                this.codigoTextbox.Enabled = false;
                this.vencimientoTextbox.Enabled = false;
                this.tipoCombo.Enabled = false;
                this.cuotasCombo.Enabled = false;
            }
        }

        private void tipoCombo_SelectedIndexChanged(object sender, EventArgs e) {

            if (tipoCombo.SelectedIndex == 0) {

                var dataSource = new List<Cuotas>();

                dataSource.Add(new Cuotas() { Value = 3 });
                dataSource.Add(new Cuotas() { Value = 6 });

                this.cuotasCombo.DataSource = dataSource;
                this.cuotasCombo.DisplayMember = "Value";
                this.cuotasCombo.ValueMember = "Value";

            }

            if (tipoCombo.SelectedIndex == 1) {

                var dataSource = new List<Cuotas>();

                dataSource.Add(new Cuotas() { Value = 3 });
                dataSource.Add(new Cuotas() { Value = 6 });
                dataSource.Add(new Cuotas() { Value = 9 });
                dataSource.Add(new Cuotas() { Value = 12 });

                this.cuotasCombo.DataSource = dataSource;
                this.cuotasCombo.DisplayMember = "Value";
                this.cuotasCombo.ValueMember = "Value";

            }

        }

        private bool fechaTarjetaInvalida() {
            String fecha = this.vencimientoTextbox.Text;
            return fecha.Length != 4 ||
                   Convert.ToInt32(fecha.Substring(0, 2)) > 12 ||
                   Convert.ToInt32(fecha.Substring(0, 2)) == 0 ||
                   Convert.ToInt32(fecha.Substring(2, 2)) == 0 ||
                   2000 + Convert.ToInt32(fecha.Substring(2, 2)) < Config.SystemConfig.systemDate.Year;
        }

        private void confirmarButton_Click(object sender, EventArgs e) {
            // 0 = efectivo
            // 1 = tarjeta
            if (this.medioDePagoCombo.SelectedIndex == 1 && this.hayCamposVacios()) {
                MessageBox.Show("Complete todos los datos de tarjeta para continuar.");
                return;
            }

            if (this.medioDePagoCombo.SelectedIndex == 1 && this.fechaTarjetaInvalida()) {
                MessageBox.Show("La fecha de vencimiento de la tarjeta es invalida.");
                return;
            }

            DAO.connect();

            String dni = this.documentoTextbox.Text;

            Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = " + dni });

            Models.Compra compra = new Models.Compra();

            compra.Medio_Pago_Id = this.medioDePagoCombo.SelectedIndex + 1; // :D
            compra.Cliente_Id = cliente.Id;
            compra.Fecha_Compra = Config.SystemConfig.systemDate;
            compra.PNR = (this.getMaxIdCompra() + 1).ToString();

            if (this.medioDePagoCombo.SelectedIndex == 1) {
                compra.Numero_Tarjeta = Convert.ToInt32(this.numeroTextbox.Text);
                compra.Codigo_Tarjeta = Convert.ToInt32(this.codigoTextbox.Text);
                compra.Vencimiento_Tarjeta = Convert.ToInt32(this.vencimientoTextbox.Text);
                compra.Tipo_Tarjeta_Id = this.tipoCombo.SelectedIndex + 1; // :D
                compra.Cant_Cuotas = (cuotasCombo.SelectedIndex + 1) * 3; // :D !!! 
            }
            else {
                compra.Tipo_Tarjeta_Id = 1; //default, si entra en 0 rompe
            }

            int compra_id = DAO.insert<Models.Compra>(compra);

            List<int> pasajesIds = new List<int>();

            int i = 0;
            foreach (int p in pasajerosIds) {
                Pasaje pasaje = new Pasaje();
                pasaje.Viaje_id = selectedViaje.Id;
                pasaje.Cliente_Id = p;
                pasaje.Butaca_Id = butacasNumeros[i];
                Decimal precioBase = this.selectedViaje.Ruta.Precio_Base_Pasajes;
                Decimal mult = this.selectedAeronave.Tipo_Servicio.Porcentaje;
                pasaje.Precio = precioBase * mult;
                pasaje.Codigo = this.getMaxCodigoPasaje() + 1;
                pasaje.Activo = true;
                DAO.connect();
                int id = DAO.insert<Pasaje>(pasaje);
                DAO.closeConnection();
                pasajesIds.Add(id);
                i++;
            }

            List<int> paquetesIds = new List<int>();

            int j = 0;
            foreach (int p in clientesIds) {
                Paquete paquete = new Paquete();
                paquete.Viaje_Id = selectedViaje.Id;
                paquete.Cliente_Id = p;
                Decimal precioBase = this.selectedViaje.Ruta.Precio_Base_Kg;
                paquete.Precio = precioBase * pesos[j];
                paquete.Codigo = this.getMaxCodigoPaquete() + 1;
                paquete.Activo = true;
                DAO.connect();
                int id = DAO.insert<Paquete>(paquete);
                DAO.closeConnection();
                paquetesIds.Add(id);
                j++;
            }

            foreach (int p in pasajesIds) {
                Compra_Pasaje cp = new Compra_Pasaje();
                cp.Compra_Id = compra_id;
                cp.Pasaje_Id = p;
                DAO.insert<Compra_Pasaje>(cp);
            }

            foreach (int p in paquetesIds) {
                Compra_Paquete cp = new Compra_Paquete();
                cp.Compra_Id = compra_id;
                cp.Paquete_Id = p;
                DAO.insert<Compra_Paquete>(cp);
            }

            DAO.closeConnection();
            var dr = MessageBox.Show("Pago confirmado con exito. Su PNR es " + compra.PNR + ". Será solicitado en caso de querer efectuar una devolución.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private int getMaxCodigoPasaje() {

            String query = "select max(codigo) from BIEN_MIGRADO_RAFA.Pasaje";
            
            String connectionString = DAO.makeConnectionString();
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, sqlCon);

            sqlCon.Open();
            object max = command.ExecuteScalar();
            sqlCon.Close();

            return Convert.ToInt32(max);

        }

        private int getMaxCodigoPaquete() {

            String query = "select max(codigo) from BIEN_MIGRADO_RAFA.Paquete";

            String connectionString = DAO.makeConnectionString();
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, sqlCon);

            sqlCon.Open();
            object max = command.ExecuteScalar();
            sqlCon.Close();

            return Convert.ToInt32(max);
      
        }

        private int getMaxIdCompra() {

            String query = "select max(id) from BIEN_MIGRADO_RAFA.Compra";

            String connectionString = DAO.makeConnectionString();
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, sqlCon);

            sqlCon.Open();
            object max = command.ExecuteScalar();
            sqlCon.Close();

            return Convert.ToInt32(max);

        }


    }

    public class Cuotas {
        public int Value { get; set; }
    }

}
