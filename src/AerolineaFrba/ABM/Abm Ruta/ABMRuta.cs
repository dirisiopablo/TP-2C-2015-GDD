using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Models;
using AerolineaFrba.Services;
using AerolineaFrba.Config;

namespace AerolineaFrba.ABM.Abm_Ruta {
    public sealed partial class ABMRuta : Form {

        private static ABMRuta _instance = null;
        private SqlDataAdapter dataAdapter;

        private ABMRuta() {
            this.InitializeComponent();
        }

        public static ABMRuta getInstance() {

            if (_instance == null) {
                _instance = new ABMRuta();
            }

            return _instance;
        }

        private void rutaNuevo_Click(object sender, EventArgs e) {

            RutaDialog rutaDialog = new RutaDialog("", 0, 0, 1, 1, Enums.tipoDialog.nuevo);
            rutaDialog.ShowDialog();

            if (rutaDialog.dr == DialogResult.Cancel) return;

            String nuevoCodigo= rutaDialog.codigo;
            decimal nuevoPrecioKg = rutaDialog.precio_kg;
            decimal nuevoPrecioPasaje = rutaDialog.precio_pasaje;
            int nuevoOrigen_id = rutaDialog.origen_id;
            int nuevoDestino_id = rutaDialog.destino_id;

            DAO.connect();

            Ruta ruta = new Ruta();
            ruta.Codigo = Convert.ToInt32(nuevoCodigo);
            ruta.Precio_Base_Kg = (decimal)nuevoPrecioKg;
            ruta.Precio_Base_Pasajes = (decimal)nuevoPrecioPasaje;
            ruta.Ciudad_Origen_Id = nuevoOrigen_id;
            ruta.Ciudad_Destino_Id = nuevoDestino_id;

            int affected = DAO.insert<Ruta>(ruta);

            DAO.closeConnection();

            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);

        }

        private void rutaModificar_Click(object sender, EventArgs e) {

            if (this.rutaDataGrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir una ruta a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.rutaDataGrid.SelectedRows.Count > 1) {
                MessageBox.Show("Solo puede elegir una ruta a modificar a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.rutaDataGrid.SelectedRows[0];

            int id = (int)row.Cells[0].Value;
            String codigo = row.Cells[1].Value.ToString();
            decimal preciokg = (decimal)row.Cells[2].Value;
            decimal precioPasaje = (decimal)row.Cells[3].Value;
            int origen_id = (int)row.Cells[4].Value;
            int destino_id = (int)row.Cells[5].Value;

            RutaDialog rutaDialog = new RutaDialog(codigo, preciokg, precioPasaje, origen_id, destino_id, Enums.tipoDialog.modificar);
            var dr = rutaDialog.ShowDialog();

            if (rutaDialog.dr == DialogResult.Cancel) return;

            String nuevoCodigo = rutaDialog.codigo;
            decimal nuevoPrecioKg = rutaDialog.precio_kg;
            decimal nuevoPrecioPasaje = rutaDialog.precio_pasaje;
            int nuevoOrigen_id = rutaDialog.origen_id;
            int nuevoDestino_id = rutaDialog.destino_id;

            DAO.connect();

            Ruta ruta = DAO.selectOne<Ruta>(new[] { "id = " + id });
            ruta.Codigo = Convert.ToInt32(nuevoCodigo);
            ruta.Precio_Base_Kg = (decimal)nuevoPrecioKg;
            ruta.Precio_Base_Pasajes = (decimal)nuevoPrecioPasaje;
            ruta.Ciudad_Origen_Id = nuevoOrigen_id;
            ruta.Ciudad_Destino_Id = nuevoDestino_id;

            int affected = DAO.update<Ruta>(ruta);

            DAO.closeConnection();

            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);

        }

        private void rutaEliminar_Click(object sender, EventArgs e) {

        }

        private void ABMRuta_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'rutaDataSet.Ruta' table. You can move, or remove it, as needed.
            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);
        }

        private void GetData(string selectCommand)
        {
            DAO.connect();
            String connectionString = DAO.makeStringConnection(DBConfig.direccion, DBConfig.database, DBConfig.username, DBConfig.password);

            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            rutaDataGrid.DataSource = table;

            DAO.closeConnection();
        }

        private string obtenerQueryBase()
        {
            return "SELECT ruta.id 'Id', " +
                    "ruta.codigo 'Codigo', " +
                    "ruta.precio_base_kg 'Precio Base Kg', " +
                    "ruta.precio_base_pasajes 'Precio Base Pasajes', " +
                    "ruta.ciudad_origen_id 'Ciudad de Origen', " +
                    "ruta.ciudad_destino_id 'Ciudad Destino', " +
                    "ruta.activo 'Activo' " +
                    "FROM BIEN_MIGRADO_RAFA.Ruta ruta WHERE";
        }
    }
}
