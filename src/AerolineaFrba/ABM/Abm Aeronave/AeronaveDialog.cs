using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        public int tipoServicioId { get; set; }
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

            if (!validar()) return;

            if (MessageBox.Show(this.tipo == Enums.tipoDialog.nuevo ? nuevoMsg : modificarMsg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            this.matricula = this.matriculaTextbox.Text;
            this.modelo = this.modeloTextbox.Text;
            this.kgDisponibles = Convert.ToDecimal(this.kgTextbox.Text);
            this.fabricante = this.fabricanteTextbox.Text;
            this.tipoServicioId = (int)this.tipoServicioCombo.SelectedValue;
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
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet7.Tipo_Servicio' Puede moverla o quitarla según sea necesario.
            this.tipo_ServicioTableAdapter.Fill(this.gD2C2015DataSet7.Tipo_Servicio);
            if (this.tipo == Enums.tipoDialog.modificar)
            {
                this.splitContainer1.Visible = false;
            }
        }

        private Boolean validar()
        {
            string txt = matriculaTextbox.Text;

            string regex = @"^([A-Z]{3})(-)([0-9]{3})$";

            Regex r = new Regex(regex, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            if (!m.Success)
            {
                MessageBox.Show("La matricula debe respetar el siguiente formato XXX-### (letra-numero).");
                return false;
            }

            if (kgTextbox.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de kilogramos disponibles.");
                return false;
            }

            if (cantidadPasillo1Input.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de butacas pasillo del primer piso.");
                return false;
            }

            if (cantidadVentana1Input.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de butacas ventana del primer piso.");
                return false;
            }

            if (cantidadPasillo2Input.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de butacas pasillo del segundo piso.");
                return false;
            }

            if (cantidadVentana2Input.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de butacas ventana del segundo piso.");
                return false;
            }

            return true;
        }
    }
}
