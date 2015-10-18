using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Enums;

namespace AerolineaFrba.ABM.Abm_Ruta {

    public partial class RutaDialog : Form {

        private Enums.tipoDialog tipo { get; set; }
        private String nuevoMsg = "Confirma la creación de la nueva Aeronave?";
        private String modificarMsg = "Seguro desea modificar los campos?";

        public String codigo { get; set; }
        public decimal precio_kg { get; set; }
        public decimal precio_pasaje { get; set; }
        public int origen_id { get; set; }
        public int destino_id { get; set; } 
        public DialogResult dr { get; set; }

        public RutaDialog(String _codigo, decimal _precio_kg, decimal _precio_pasaje, int _origen_id, int _destino_id, Enums.tipoDialog tipoDialog) {

            InitializeComponent();

            this.codigoTextbox.Text = _codigo;
            this.kgTextbox.Text = _precio_kg.ToString();
            this.pasajeTextbox.Text = _precio_pasaje.ToString();
            this.origenCombo.SelectedValue = _origen_id; //FIXME
            this.destinoCombo.SelectedValue = _destino_id; //FIXME
            this.tipo = tipoDialog;
            this.dr = DialogResult.Cancel;

        }

        private void guardarRuta_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this.tipo == Enums.tipoDialog.nuevo ? nuevoMsg : modificarMsg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            this.codigo = codigoTextbox.Text;
            this.precio_kg = Convert.ToDecimal(kgTextbox.Text);
            this.precio_pasaje = Convert.ToDecimal(pasajeTextbox.Text);
            this.origen_id = (int)origenCombo.SelectedValue;
            this.destino_id = (int)destinoCombo.SelectedValue;

            this.dr = DialogResult.OK;
            this.Close();

        }

        private void cancelarRuta_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void RutaDialog_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dataSetCiudad2.Ciudad' table. You can move, or remove it, as needed.
            this.ciudadTableAdapter1.Fill(this.dataSetCiudad2.Ciudad);
            // TODO: This line of code loads data into the 'dataSetCiudad.Ciudad' table. You can move, or remove it, as needed.
            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);
        }
    }
}
