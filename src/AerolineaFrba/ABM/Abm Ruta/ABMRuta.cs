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
            ruta.Activo = true;

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

            DAO.connect();

            Ciudad ciudadOrigen = DAO.selectOne<Ciudad>(new[] { "descripcion = " + "'" +  (String)row.Cells[4].Value + "'" });
            Ciudad ciudadDestino = DAO.selectOne<Ciudad>(new[] { "descripcion = " + "'" +  (String)row.Cells[5].Value + "'" });

            DAO.closeConnection();

            int origen_id = ciudadOrigen.Id;
            int destino_id = ciudadDestino.Id;

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

            if (this.rutaDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir una ruta para dar de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.rutaDataGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Solo puede elegir una ruta para dar de baja a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.rutaDataGrid.SelectedRows[0];

            int id = (int)row.Cells[0].Value;

            DAO.connect();
            Ruta ruta = DAO.selectOne<Ruta>(new[] { "id = " + id + " " });
            DAO.closeConnection();

            if (!ruta.Activo) {
                MessageBox.Show("La ruta seleccionada ya fue dada de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Viaje> viajes = DAO.selectAll<Viaje>(new[] { "ruta_id = " + ruta.Id });

            foreach (Viaje viaje in viajes) {
                if (viaje.Fecha_Salida < Config.SystemConfig.systemDate) {
                    MessageBox.Show("Existen futuros viajes con la ruta seleccionada asignada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            var dr = MessageBox.Show("¿Confirma la eliminación de la ruta seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes) return;

            DAO.connect();

            ruta.Activo = false;
            int idInsertado = DAO.update<Ruta>(ruta);

            DAO.closeConnection();

            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);
        }

        private void ABMRuta_Load(object sender, EventArgs e) {
            this.ciudadTableAdapter1.Fill(this.gD2C2015DataSet6.Ciudad);
            this.ciudadTableAdapter.Fill(this.gD2C2015DataSet5.Ciudad);
            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);
        }

        private void GetData(string selectCommand)
        {
            DAO.connect();
            String connectionString = DAO.makeConnectionString(DBConfig.direccion, DBConfig.database, DBConfig.username, DBConfig.password);

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
                    "c1.descripcion 'Ciudad de Origen', " +
                    "c2.descripcion 'Ciudad Destino', " +
                    "ruta.activo 'Activo' " +
                    "FROM BIEN_MIGRADO_RAFA.Ruta ruta " +
                    "JOIN BIEN_MIGRADO_RAFA.ciudad c1 ON c1.id = ruta.ciudad_origen_id " +
                    "JOIN BIEN_MIGRADO_RAFA.ciudad c2 ON c2.id = ruta.ciudad_destino_id WHERE";
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string query = obtenerQueryBase();

            if (!validar()) return;

            String codigo = this.codigoInput.Text;
            int precioBaseKg = Int32.Parse(this.baseKgInput.Text);
            int precioBasePasaje = Int32.Parse(this.basePasajeInput.Text);
            int destinoId = (int) this.destinoCombo.SelectedValue;
            int origenId = (int) this.origenCombo.SelectedValue;
            bool origenTodos = this.origenTodosCheckBox.Checked;
            bool destinoTodos = this.destinoTodosCheckBox.Checked;

            if (codigo != null && codigo != "")
            {
                query += " ruta.codigo LIKE " + "'%" + codigo + "%' AND ";
            }

            if (precioBaseKg != 0)
            {
                query += " ruta.precio_base_kg < " + precioBaseKg + " AND ";
            }

            if (precioBasePasaje != 0)
            {
                query += " ruta.precio_base_pasajes < " + precioBasePasaje + " AND ";
            }

            if (destinoId != 0 && !destinoTodos)
            {
                query += " ruta.ciudad_destino_id = " + destinoId + " AND ";
            }

            if (origenId != 0 && !origenTodos)
            {
                query += " ruta.ciudad_origen_id = " + origenId + " AND ";
            }
            
            query = query.Substring(0, query.Length - 5);
            GetData(query);
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.codigoInput.Text = "";
            this.baseKgInput.Text = "0";
            this.basePasajeInput.Text = "0";
            this.origenTodosCheckBox.Checked = true;
            this.destinoTodosCheckBox.Checked = true;
        }

        private Boolean validar()
        {
            if (baseKgInput.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de precio base de kilogramo.");
                return false;
            }

            if (basePasajeInput.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de precio base de pasaje.");
                return false;
            }

            return true;
        }
    }

}
