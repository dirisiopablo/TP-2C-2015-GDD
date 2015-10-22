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
            DateTime fecha = this.fechaPicker.Value;

            DAO.selectOne<Aeronave>(new[] { "id = " + id_aeronave });


            //TODO, hay que pensar, lo dejamos para otro ma;ana

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
