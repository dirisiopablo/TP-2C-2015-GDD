using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Models;
using AerolineaFrba.Services;

namespace AerolineaFrba.ABM.Abm_Ciudad {

    public sealed partial class ABMCiudad : Form {

        private static ABMCiudad _instance = null;

        private ABMCiudad() {
            this.InitializeComponent();
        }

        public static ABMCiudad getInstance() {

            if (_instance == null) {
                _instance = new ABMCiudad();
            }

            return _instance;

        }

        private void nuevoCiudad_Click(object sender, EventArgs e) {

            CiudadDialog ciudadDialog = new CiudadDialog("", Enums.tipoDialog.nuevo);
            ciudadDialog.ShowDialog();

            if (ciudadDialog.dr == DialogResult.Cancel) return;

            String nuevaDescripcion = ciudadDialog.descripcion;

            DAO.connect();

            Ciudad ciudad = new Ciudad();
            ciudad.Descripcion = nuevaDescripcion;
            int affected = DAO.insert<Ciudad>(ciudad);

            DAO.closeConnection();

            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);
            ciudadDataGrid.Update(); 

        }

        private void modificarCiudad_Click(object sender, EventArgs e) {

            if (this.ciudadDataGrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir una ciudad a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.ciudadDataGrid.SelectedRows.Count > 1) {
                MessageBox.Show("Solo puede elegir una ciudad a modificar a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.ciudadDataGrid.SelectedRows[0];

            int id = (int)row.Cells[0].Value;
            String descripcion = (String)row.Cells[1].Value;

            CiudadDialog ciudadDialog = new CiudadDialog(descripcion, Enums.tipoDialog.modificar);
            var dr = ciudadDialog.ShowDialog();

            if (ciudadDialog.dr == DialogResult.Cancel) return;

            String nuevaDescripcion = ciudadDialog.descripcion;

            DAO.connect();

            Ciudad ciudad = DAO.selectOne<Ciudad>(new[] { "id = " + id });
            ciudad.Descripcion = nuevaDescripcion;
            int affected = DAO.update<Ciudad>(ciudad);

            DAO.closeConnection();

            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);
            ciudadDataGrid.Update();

        }

        private void eliminarCiudad_Click(object sender, EventArgs e) {

            if (this.ciudadDataGrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir al menos una ciudad a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.ciudadDataGrid.SelectedRows.Count == 1) {
                if (MessageBox.Show("Seguro desea eliminar la ciudad seleccionada?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            }

            if (this.ciudadDataGrid.SelectedRows.Count > 1) {
                if (MessageBox.Show("Seguro desea eliminar las " + this.ciudadDataGrid.SelectedRows.Count + " ciudades seleccionadas?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            }


            foreach (DataGridViewRow item in ciudadDataGrid.SelectedRows) {

                int id = (int)item.Cells[0].Value;

                DAO.connect();

                Ciudad ciudad = DAO.selectOne<Ciudad>(new[] { "id = " + id });
                int affected = DAO.update<Ciudad>(ciudad);

                DAO.closeConnection();

                this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);
                ciudadDataGrid.Update();

            }

        }

        private void ABMCiudad_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dataSetCiudad.Ciudad' table. You can move, or remove it, as needed.
            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);

        }

    }
}
