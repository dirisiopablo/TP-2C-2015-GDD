using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using AerolineaFrba.Models;
using AerolineaFrba.Services;

namespace AerolineaFrba.Forms.Devolucion {

    public sealed partial class Devolucion : Form {

        private static Devolucion _instance = null;
        private SqlDataAdapter dataAdapter;

        private Devolucion() {
            this.InitializeComponent();
        }

        public static Devolucion getInstance() {

            if (_instance == null) {
                _instance = new Devolucion();
            }

            return _instance;

        }

        private void buscarButton_Click(object sender, EventArgs e) {

            String dni = this.dniTextbox.Text;
            String nombre = this.nombreTextbox.Text;
            String apellido = this.apellidoTextbox.Text;

            String error = "";
            if (!this.validarBusqueda(dni, nombre, apellido, ref error)) {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DAO.connect();

            Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = '" + dni + "'", "nombre = '" + nombre + "'", "apellido = '" + apellido + "'" });

            if (cliente == null) {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String queryPasajes = this.BuildQueryPasajes(cliente.Id);
            String queryPaquetes = this.BuildQueryPaquetes(cliente.Id);

            this.FillDataGrid(queryPasajes, this.pasajesDatagrid);
            this.FillDataGrid(queryPaquetes, this.paquetesDatagrid);

            DAO.closeConnection();

        }

        private void devolucionPasajeButton_Click(object sender, EventArgs e) {

            if (this.pasajesDatagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir un pasaje para iniciar la cancelación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.pasajesDatagrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Solo puede elegir un pasaje para dar de baja a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.pasajesDatagrid.SelectedRows[0];

            String codigo = (String)row.Cells[0].Value;

            //AeronaveBaja aeronaveBaja = new AeronaveBaja(matricula);
            //var dr = aeronaveBaja.ShowDialog();

            //if (aeronaveBaja.dr == DialogResult.Cancel) return;

            //TODO instanciar dialog de baja y eso...
            
            DAO.connect();

            Cancelacion cancelacion = new Cancelacion();
            cancelacion.Fecha = DateTime.Now;
            cancelacion.Motivo = "";
            cancelacion.NumeroCompra = 0000;

            //TODO agregar intermedia n shit
           
            int idInsertado = DAO.insert<Cancelacion>(cancelacion);

            DAO.closeConnection();

        }

        private void devolucionEncomiendaButton_Click(object sender, EventArgs e) {

            if (this.paquetesDatagrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir una encomienda para iniciar la cancelación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.paquetesDatagrid.SelectedRows.Count > 1) {
                MessageBox.Show("Solo puede elegir una encomienda para dar de baja a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.paquetesDatagrid.SelectedRows[0];

            String codigo = (String)row.Cells[0].Value;

            //AeronaveBaja aeronaveBaja = new AeronaveBaja(matricula);
            //var dr = aeronaveBaja.ShowDialog();

            //if (aeronaveBaja.dr == DialogResult.Cancel) return;

            //TODO instanciar dialog de baja y eso...

            DAO.connect();

            Cancelacion cancelacion = new Cancelacion();
            cancelacion.Fecha = DateTime.Now;
            cancelacion.Motivo = "";
            cancelacion.NumeroCompra = 0000;

            //TODO agregar intermedia n shit

            int idInsertado = DAO.insert<Cancelacion>(cancelacion);

            DAO.closeConnection();

        }

        private String BuildQueryPasajes (int clienteId) {

            String queryPasajes =  "SELECT p.codigo 'Código', "
                                        + "p.precio 'Precio', "
                                        + "p.fecha_compra 'Fecha Compra', "
                                        + "v.fecha_salida 'Fecha Salida', "
                                        + "v.fecha_llegada_estimada 'Fecha Llegada', "
                                        + "co.descripcion 'Origen', "
                                        + "cd.descripcion 'Destino' ";
            queryPasajes += "FROM BIEN_MIGRADO_RAFA.Pasaje p WHERE p.cliente_id = " + clienteId + " AND v.fecha_salida <= CURDATE()";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Viaje v ON p.viaje_id = v.id";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Ruta r ON v.ruta_id = r.id";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad co ON r.ciudad_origen_id = co.id";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad cd ON r.ciudad_destino_id = cd.id";


            return queryPasajes;
        }

        private String BuildQueryPaquetes (int clienteId) {

            String queryPaquetes = "SELECT p.codigo 'Código', "
                                        + "p.precio 'Precio', "
                                        + "p.kg 'Peso', "
                                        + "p.fecha_compra 'Fecha Compra', "
                                        + "v.fecha_salida 'Fecha Salida', "
                                        + "v.fecha_llegada_estimada 'Fecha Llegada', "
                                        + "co.descripcion 'Origen', "
                                        + "cd.descripcion 'Destino' ";
            queryPaquetes += "FROM BIEN_MIGRADO_RAFA.Paquete p WHERE p.cliente_id = " + clienteId + " AND v.fecha_salida <= CURDATE()";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Viaje v ON p.viaje_id = v.id";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Ruta r ON v.ruta_id = r.id";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad co ON r.ciudad_origen_id = co.id";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad cd ON r.ciudad_destino_id = cd.id";


            return queryPaquetes;
        }

        private void FillDataGrid(string selectCommand, DataGridView datagrid) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            DataTable table = new DataTable();
            this.dataAdapter.Fill(table);

            if (table.Rows.Count == 0)
                MessageBox.Show("No se encontraron viajes con los parametros ingresados.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            datagrid.DataSource = table;

        }

        private bool validarBusqueda(String dni, String nombre, String apellido, ref String error) {

            if ( String.IsNullOrWhiteSpace(dni) ) {
                error = "Debe ingresar el DNI del cliente a buscar.";
                return false;
            }

            if ( String.IsNullOrWhiteSpace(nombre) ) {
                error = "Debe ingresar el nombre del cliente a buscar.";
                return false;
            }

            if ( String.IsNullOrWhiteSpace(apellido) ) {
                error = "Debe ingresar el apellido del cliente a buscar.";
                return false;
            }

            return true;
        }


    }

}
