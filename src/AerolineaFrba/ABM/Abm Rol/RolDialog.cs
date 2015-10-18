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

namespace AerolineaFrba.ABM.Abm_Rol
{
    public partial class RolDialog : Form
    {

        private Enums.tipoDialog tipo { get; set; }
        private String nuevoMsg = "Confirma la creación del nuevo rol?";
        private String modificarMsg ="Seguro desea modificar la descripción?";

        public String descripcion { get; set; }
        public DialogResult dr { get; set; }

        public RolDialog(String _descripcion, Enums.tipoDialog tipoDialog)
        {
            InitializeComponent();
            this.tipo = tipoDialog;
            this.descripcionTextbox.Text = _descripcion;
            this.dr = DialogResult.Cancel;
        }

        private void Guardar_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this.tipo == Enums.tipoDialog.nuevo ? nuevoMsg : modificarMsg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            this.descripcion = this.descripcionTextbox.Text;
            this.dr = DialogResult.OK;
            this.Close();

        }

        private void Cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
