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

namespace AerolineaFrba.ABM.Abm_Ciudad {
    public partial class CiudadDialog : Form {

        private Enums.tipoDialog tipo { get; set; }
        private String nuevoMsg = "Confirma la creación de la nueva ciudad?";
        private String modificarMsg = "Seguro desea modificar la descripción?";

        public String descripcion { get; set; }
        public DialogResult dr { get; set; }

        public CiudadDialog(String _descripcion, Enums.tipoDialog tipoDialog) {
            InitializeComponent();
            this.tipo = tipoDialog;
            this.descripcionCiudad.Text = _descripcion;
            this.dr = DialogResult.Cancel;
        }

        private void guardarCiudad_Click(object sender, EventArgs e) {
            
            if (MessageBox.Show(this.tipo == Enums.tipoDialog.nuevo ? nuevoMsg : modificarMsg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            this.descripcion = this.descripcionCiudad.Text;
            this.dr = DialogResult.OK;
            this.Close();

        }
    }
}
