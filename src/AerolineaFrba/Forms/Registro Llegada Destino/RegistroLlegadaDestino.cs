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

            int id_aeronave = (int)this.matriculaCombo.SelectedValue;
            int id_origen = (int)this.origenCombo.SelectedValue;
            int id_destino = (int)this.destinoCombo.SelectedValue;
            DateTime fecha_llegada = this.fechaPicker.Value;

            DAO.connect();
            Viaje viaje = DAO.selectOne<Viaje>(new[] { "aeronave_id = " + id_aeronave, "fecha_llegada_estimada = " + fecha_llegada });

            if (viaje == null) {
                MessageBox.Show("No existe un viaje con la aeronave ingresada con una llegada estimada cercana a la fecha ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DAO.closeConnection();
                return;
            }

            int ruta_id = viaje.Ruta_Id;
            Ruta ruta = DAO.selectOne<Ruta>( new[] {"id = " + ruta_id} );

            if (ruta.Ciudad_Origen_Id != id_origen || ruta.Ciudad_Destino_Id != id_destino) {
                MessageBox.Show("La ciudad origen o destino es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DAO.closeConnection();
                return;
            }

            viaje.Fecha_Llegada = fecha_llegada;

            DAO.update<Viaje>(viaje);
            DAO.closeConnection();

        }

        private void cancelarButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void RegistroLlegadaDestino_Load(object sender, EventArgs e) {

            this.ciudadTableAdapter1.Fill(this.dataSetCiudad2.Ciudad);
            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);
            this.aeronaveTableAdapter1.Fill(this.gD2C2015DataSet3.Aeronave);
            this.aeronaveTableAdapter.Fill(this.dataSetAeronave.Aeronave);

        }

    }

}
