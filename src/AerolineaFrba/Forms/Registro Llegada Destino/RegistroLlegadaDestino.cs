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

namespace AerolineaFrba.Forms.Registro_Llegada_Destino {

    public partial class RegistroLlegadaDestino : Form {

        private static RegistroLlegadaDestino _instance = null;

        private RegistroLlegadaDestino() {
            this.InitializeComponent();
        }

        public static RegistroLlegadaDestino getInstance() {

            if (_instance == null) {
                _instance = new RegistroLlegadaDestino();
            }

            return _instance;
        }

        
        private void guardarButton_Click(object sender, EventArgs e) {
            string matricula = this.matriculaTextbox.Text;
            int id_origen = (int)this.origenCombo.SelectedValue;
            int id_destino = (int)this.destinoCombo.SelectedValue;
            DateTime fecha_llegada = this.fechaPicker.Value;

            DAO.connect();
            Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "matricula = '" + matricula + "'"});

            if (aeronave == null)
            {
                MessageBox.Show("No existe la aeronave con la matrícula ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DAO.closeConnection();
                return;
            }

            Ruta ruta = DAO.selectOne<Ruta>(new[] { "ciudad_origen_id = " + id_origen, "ciudad_destino_id = " + id_destino });

            if (ruta == null)
            {
                MessageBox.Show("No existe una ruta cargada con las ciudades ingresadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DAO.closeConnection();
                return;
            }

            Viaje viaje = DAO.selectOne<Viaje>(new[] { "aeronave_id = " + aeronave.Id, "fecha_llegada = fecha_salida", "ruta_id = " + ruta.Id, "fecha_llegada_estimada <= '" + fecha_llegada.AddDays(1).ToString("yyyyMMdd HH:mm:ss") + "'", "fecha_llegada_estimada >= '" + fecha_llegada.AddDays(-1).ToString("yyyyMMdd HH:mm:ss") + "'" });

            if (viaje == null) {
                viaje = DAO.selectOne<Viaje>(new[] { "aeronave_id = " + aeronave.Id, "fecha_llegada = fecha_salida", "ruta_id = " + ruta.Id, "fecha_llegada_estimada <= '" + fecha_llegada.AddDays(2).ToString("yyyyMMdd HH:mm:ss") + "'", "fecha_llegada_estimada >= '" + fecha_llegada.AddDays(-2).ToString("yyyyMMdd HH:mm:ss") + "'" });
                if (viaje == null)
                {

                    MessageBox.Show("No existe un viaje con la aeronave ingresada con una llegada estimada cercana a la fecha ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DAO.closeConnection();
                    return;
                }
            }

            viaje.Fecha_Llegada = fecha_llegada;

            int result = DAO.update<Viaje>(viaje);
            DAO.closeConnection();

            if (result != 0)
                MessageBox.Show("Llegada del viaje registrada correctamente.", "Nueva llegada de viaje creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al registrar la llegada del viaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cancelarButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void RegistroLlegadaDestino_Load(object sender, EventArgs e) {
            this.ciudadTableAdapter1.Fill(this.dataSetCiudad2.Ciudad);
            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);
        }

    }

}
