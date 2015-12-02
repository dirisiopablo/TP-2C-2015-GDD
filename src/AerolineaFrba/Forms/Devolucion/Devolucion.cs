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
using AerolineaFrba.Config;

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

            //TODO or not todo, agarro el pnr de la compra del 1er pasaje, a veces coinciden y a veces no
            // porque le permitimos cancelar pasajes de varias compras en una sola devolucion
            // debatir duramente hasta llegar a una conclusion y tomar una decision sabia

            DataGridViewRow d = this.pasajesDatagrid.SelectedRows[0];
            decimal cod = (decimal)d.Cells[0].Value;
            Pasaje p = DAO.selectOne<Pasaje>(new[] { "codigo = " + cod.ToString() });
            Compra_Pasaje cpp = DAO.selectOne<Compra_Pasaje>(new[] { "pasaje_id = " + p.Id });
            Models.Compra referencia = DAO.selectOne<Models.Compra>(new[] { "id = " + cpp.Compra_Id });

            Cancelacion cancelacion = new Cancelacion();
            cancelacion.Fecha = Config.SystemConfig.systemDate;
            cancelacion.Motivo = this.motivoTextbox.Text;
            cancelacion.Numero_Compra = referencia.PNR; 
            int cancelacion_id = DAO.insert<Cancelacion>(cancelacion);

            foreach (DataGridViewRow pasaje in this.pasajesDatagrid.SelectedRows) {

                decimal codigo = (decimal)pasaje.Cells[0].Value;
                Pasaje pasaje_cancelado = DAO.selectOne<Pasaje>(new[] { "codigo = " + codigo.ToString() });

                Cancelacion_Pasaje cp = new Cancelacion_Pasaje();
                cp.Cancelacion_Id = cancelacion_id;
                cp.Pasaje_Id = pasaje_cancelado.Id;

                pasaje_cancelado.Activo = false;

                DAO.insert<Cancelacion_Pasaje>(cp);
                DAO.update<Pasaje>(pasaje_cancelado);
            
            }

            foreach (DataGridViewRow paquete in this.paquetesDatagrid.SelectedRows) {

                decimal codigo = (decimal)paquete.Cells[0].Value;
                Paquete paquete_cancelado = DAO.selectOne<Paquete>(new[] { "codigo = " + codigo.ToString() });

                Cancelacion_Paquete cp = new Cancelacion_Paquete();
                cp.Cancelacion_Id = cancelacion_id;
                cp.Paquete_Id = paquete_cancelado.Id;

                paquete_cancelado.Activo = false;

                DAO.insert<Cancelacion_Paquete>(cp);
                DAO.update<Paquete>(paquete_cancelado);

            }

            DAO.closeConnection();

            MessageBox.Show("Baja concretada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private String BuildQueryPasajes (int clienteId) {

            String queryPasajes =  "SELECT p.codigo 'Código', "
                                        + "p.precio 'Precio', "
                                        + "c.fecha_compra 'Fecha Compra', "
                                        + "v.fecha_salida 'Fecha Salida', "
                                        + "v.fecha_llegada_estimada 'Fecha Llegada', "
                                        + "co.descripcion 'Origen', "
                                        + "cd.descripcion 'Destino' ";
            queryPasajes += "FROM BIEN_MIGRADO_RAFA.Pasaje p ";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Viaje v ON p.viaje_id = v.id ";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Ruta r ON v.ruta_id = r.id ";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad co ON r.ciudad_origen_id = co.id ";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad cd ON r.ciudad_destino_id = cd.id ";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Compra_Pasaje cp ON cp.pasaje_id = p.id ";
            queryPasajes += "INNER JOIN BIEN_MIGRADO_RAFA.Compra c ON cp.compra_id = c.id ";
            queryPasajes += "WHERE c.cliente_id = " + clienteId + " AND v.fecha_salida >= " + "'" + Config.SystemConfig.systemDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND p.activo = 1";

            return queryPasajes;
        }

        private String BuildQueryPaquetes (int clienteId) {

            String queryPaquetes = "SELECT p.codigo 'Código', "
                                        + "p.precio 'Precio', "
                                        + "p.kg 'Peso', "
                                        + "c.fecha_compra 'Fecha Compra', "
                                        + "v.fecha_salida 'Fecha Salida', "
                                        + "v.fecha_llegada_estimada 'Fecha Llegada', "
                                        + "co.descripcion 'Origen', "
                                        + "cd.descripcion 'Destino' ";
            queryPaquetes += "FROM BIEN_MIGRADO_RAFA.Paquete p ";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Viaje v ON p.viaje_id = v.id ";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Ruta r ON v.ruta_id = r.id ";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad co ON r.ciudad_origen_id = co.id ";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Ciudad cd ON r.ciudad_destino_id = cd.id ";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Compra_Paquete cp ON cp.paquete_id = p.id ";
            queryPaquetes += "INNER JOIN BIEN_MIGRADO_RAFA.Compra c ON cp.compra_id = c.id ";
            queryPaquetes += "WHERE c.cliente_id = " + clienteId + " AND v.fecha_salida >= " + "'" + Config.SystemConfig.systemDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND p.activo = 1";


            return queryPaquetes;
        }

        private void FillDataGrid(string selectCommand, DataGridView datagrid) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            DataTable table = new DataTable();
            this.dataAdapter.Fill(table);

            //if (table.Rows.Count == 0)
            //    MessageBox.Show("No se encontraron viajes con los parametros ingresados.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            if (pasajesCount != 0 && paquetesCount != 0)
                msg += "y ";

            if (paquetesCount == 1)
                msg += "un paquete";

            if (paquetesCount > 1)
                msg += paquetesCount + " paquetes";

            msg += ". ¿Desea continuar?";

            return msg;

        }

        private void dniTextbox_TextChanged(object sender, EventArgs e) {

            //documentos de 7 u 8 digitos
            if (this.dniTextbox.Text.Length == 7 || this.dniTextbox.Text.Length == 8) {

                String dni = this.dniTextbox.Text;
                DAO.connect();
                Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = " + dni });
                DAO.closeConnection();

                if (cliente != null) {
                    this.nombreTextbox.Text = cliente.Nombre;
                    this.apellidoTextbox.Text = cliente.Apellido;
                }
                else {
                    this.nombreTextbox.Text = "";
                    this.apellidoTextbox.Text = "";
                }

            }
        }
       
    }

}
