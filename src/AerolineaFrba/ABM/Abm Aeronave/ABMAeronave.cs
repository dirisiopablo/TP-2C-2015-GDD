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
using AerolineaFrba.ABM.Abm_Aeronave;

namespace AerolineaFrba.Abm_Aeronave {
    public sealed partial class ABMAeronave : Form {

        private static ABMAeronave _instance = null;

        private ABMAeronave() {
            this.InitializeComponent();
        }

        public static ABMAeronave getInstance() {

            if (_instance == null) {
                _instance = new ABMAeronave();
            }

            return _instance;

        }

        private void NuevoAeronave_Click(object sender, EventArgs e) {

            AeronaveDialog aeronaveDialog = new AeronaveDialog("", "", 0, "", Enums.tipoDialog.nuevo);
            aeronaveDialog.ShowDialog();

            if (aeronaveDialog.dr == DialogResult.Cancel) return;

            String nuevaMatricula = aeronaveDialog.matricula;
            String nuevoModelo = aeronaveDialog.modelo;
            decimal nuevoKgDisponibles = aeronaveDialog.kgDisponibles;
            String nuevoFabricante = aeronaveDialog.fabricante;

            DAO.connect();

            Aeronave aeronave = new Aeronave();
            aeronave.Matricula = nuevaMatricula;
            aeronave.Modelo = nuevoModelo;
            aeronave.Kilogramos_Disponibles = nuevoKgDisponibles;
            aeronave.Fabricante = nuevoFabricante;
            int affected = DAO.insert<Aeronave>(aeronave);

            DAO.closeConnection();

            this.aeronaveTableAdapter.Fill(this.dataSetAeronave.Aeronave);
            aeronaveDataGrid.Update(); 

        }

        private void ModificarAeronave_Click(object sender, EventArgs e) {

            if (this.aeronaveDataGrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir una aeronave a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.aeronaveDataGrid.SelectedRows.Count > 1) {
                MessageBox.Show("Solo puede elegir una aeronave a modificar a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.aeronaveDataGrid.SelectedRows[0];

            int id = (int)row.Cells[0].Value;
            String matricula = (String)row.Cells[1].Value;
            String modelo = (String)row.Cells[2].Value;
            decimal kgDisponibles = Convert.ToDecimal(row.Cells[3].Value);
            String fabricante = (String)row.Cells[4].Value;

            AeronaveDialog aeronaveDialog = new AeronaveDialog(matricula, modelo, kgDisponibles, fabricante, Enums.tipoDialog.nuevo);
            var dr = aeronaveDialog.ShowDialog();

            if (aeronaveDialog.dr == DialogResult.Cancel) return;

            String nuevaMatricula = aeronaveDialog.matricula;
            String nuevoModelo = aeronaveDialog.modelo;
            decimal nuevoKgDisponibles = aeronaveDialog.kgDisponibles;
            String nuevoFabricante = aeronaveDialog.fabricante;

            DAO.connect();

            Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "id = " + id });
            aeronave.Matricula = nuevaMatricula;
            aeronave.Modelo = nuevoModelo;
            aeronave.Kilogramos_Disponibles = nuevoKgDisponibles;
            aeronave.Fabricante = nuevoFabricante;
            int affected = DAO.update<Aeronave>(aeronave);

            DAO.closeConnection();

            this.aeronaveTableAdapter.Fill(this.dataSetAeronave.Aeronave);
            aeronaveDataGrid.Update(); 

        }

        private void EliminarAeronave_Click(object sender, EventArgs e) {
            // usar TipoBaja
        }

        private void ABMAeronave_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dataSetAeronave.Aeronave' table. You can move, or remove it, as needed.
            this.aeronaveTableAdapter.Fill(this.dataSetAeronave.Aeronave);
        }
    }
}
