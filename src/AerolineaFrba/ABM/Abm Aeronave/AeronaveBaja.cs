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

namespace AerolineaFrba.ABM.Abm_Aeronave
{
    public partial class AeronaveBaja : Form
    {
        public String matricula { get; set; }
        public int tipoBajaId { get; set; }
        public DialogResult dr { get; set; }

        public AeronaveBaja(String _matricula)
        {
            InitializeComponent();
            this.matricula = _matricula.ToString();
            this.dr = DialogResult.Cancel;
        }

        private void AeronaveBaja_Load(object sender, EventArgs e)
        {
            Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "matricula = '" + matricula + "' " });

            this.tipo_BajaTableAdapter.Fill(this.gD2C2015DataSet2.Tipo_Baja);

            this.matriculaTexto.Text = aeronave.Matricula;
            this.fabricanteTexto.Text = aeronave.Fabricante.Descripcion;
            this.modeloTexto.Text = aeronave.Modelo.Descripcion;
        }

        private void cancelarBaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmarBaja_Click(object sender, EventArgs e)
        {
            this.tipoBajaId = (int)this.tipoBajaCombo.SelectedValue;

            this.dr = DialogResult.OK;
            this.Close();
        }
    }
}
