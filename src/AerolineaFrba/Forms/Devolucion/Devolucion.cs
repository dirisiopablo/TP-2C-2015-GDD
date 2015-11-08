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

        private void devolucionButton_Click(object sender, EventArgs e) {

            int pasajesCount = this.pasajesDatagrid.SelectedRows.Count;
            int paquetesCount = this.paquetesDatagrid.SelectedRows.Count;

            if (pasajesCount == 0 && paquetesCount == 0) {
                MessageBox.Show("Debe elegir por lo menos un pasaje o una encomienda para iniciar la cancelación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show(this.buildConfirmMsg(pasajesCount, paquetesCount), "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result != DialogResult.OK) return;

            DAO.connect();

            Cancelacion cancelacion = new Cancelacion();
            cancelacion.Fecha = DateTime.Now;
            cancelacion.Motivo = "";
            cancelacion.NumeroCompra = 0000;
            int cancelacion_id = DAO.insert<Cancelacion>(cancelacion);

            foreach (DataGridViewRow pasaje in this.pasajesDatagrid.SelectedRows) {

                String codigo = (String)pasaje.Cells[0].Value;
                Pasaje pasaje_cancelado = DAO.selectOne<Pasaje>(new[] { "codigo = " + codigo });

                Cancelacion_Pasaje cp = new Cancelacion_Pasaje();
                cp.Cancelacion_Id = cancelacion_id;
                cp.Pasaje_Id = pasaje_cancelado.Id;

                DAO.insert<Cancelacion_Pasaje>(cp);
            
            }

            foreach (DataGridViewRow paquete in this.paquetesDatagrid.SelectedRows) {

                String codigo = (String)paquete.Cells[0].Value;
                Paquete paquete_cancelado = DAO.selectOne<Paquete>(new[] { "codigo = " + codigo });

                Cancelacion_Paquete cp = new Cancelacion_Paquete();
                cp.Cancelacion_Id = cancelacion_id;
                cp.Paquete_Id = paquete_cancelado.Id;

                DAO.insert<Cancelacion_Paquete>(cp);

            }

            DAO.closeConnection();

            MessageBox.Show("Baja concretada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private String buildConfirmMsg(int pasajesCount, int paquetesCount) {

            String msg = "Está por dar de baja ";

            if (pasajesCount == 1)
                msg += "un pasaje ";

            if (pasajesCount > 1)
                msg += pasajesCount + " pasajes ";

            if (pasajesCount != 0)
                msg += "y ";

            if (paquetesCount == 1)
                msg += "un paquete";

            if (paquetesCount > 1)
                msg += paquetesCount + " paquetes";

            msg += ". ¿Desea continuar?";

            return msg;

        }

       
    }

}
