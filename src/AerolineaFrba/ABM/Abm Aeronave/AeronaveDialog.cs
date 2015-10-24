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

namespace AerolineaFrba.ABM.Abm_Aeronave {

    public partial class AeronaveDialog : Form {

        private Enums.tipoDialog tipo { get; set; }
        private String nuevoMsg = "Confirma la creación de la nueva Aeronave?";
        private String modificarMsg = "Seguro desea modificar los campos?";

        public String matricula { get; set; }
        public String modelo { get; set; }
        public decimal kgDisponibles { get; set; }
        public String fabricante { get; set; }
        public int cantidadPasillo1 { get; set; }
        public int cantidadVentana1 { get; set; }
        public int cantidadPasillo2 { get; set; }
        public int cantidadVentana2 { get; set; }
        public DialogResult dr { get; set; }

        public AeronaveDialog(String _matricula, String _modelo, decimal _kgDisponibles, String _fabricante, Enums.tipoDialog tipoDialog) {
            InitializeComponent();

            this.matriculaTextbox.Text = _matricula.ToString();
            this.modeloTextbox.Text = _modelo.ToString();
            this.kgTextbox.Text = _kgDisponibles.ToString();
            this.fabricanteTextbox.Text = _fabricante.ToString();
            this.tipo = tipoDialog;
            this.dr = DialogResult.Cancel;
        }

        private void guardarAeronave_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this.tipo == Enums.tipoDialog.nuevo ? nuevoMsg : modificarMsg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            this.matricula = this.matriculaTextbox.Text;
            this.modelo = this.modeloTextbox.Text;
            this.kgDisponibles = Convert.ToDecimal(this.kgTextbox.Text);
            this.fabricante = this.fabricanteTextbox.Text;
            this.cantidadPasillo1 = Convert.ToInt32(this.cantidadPasillo1Input.Text);
            this.cantidadVentana1 = Convert.ToInt32(this.cantidadVentana1Input.Text);
            this.cantidadPasillo2 = Convert.ToInt32(this.cantidadPasillo2Input.Text);
            this.cantidadVentana2 = Convert.ToInt32(this.cantidadVentana2Input.Text);

            this.dr = DialogResult.OK;
            this.Close();

        }

        private void cancelarAeronave_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AeronaveDialog_Load(object sender, EventArgs e)
        {
            if (this.tipo == Enums.tipoDialog.modificar)
            {
                this.splitContainer1.Visible = false;
            }
        }
    }
}
