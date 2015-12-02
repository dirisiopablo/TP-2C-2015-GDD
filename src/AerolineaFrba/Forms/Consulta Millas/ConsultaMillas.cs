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

namespace AerolineaFrba.Forms.Consulta_Millas {

    public sealed partial class ConsultaMillas : Form {

        private static ConsultaMillas _instance = null;
        private SqlDataAdapter dataAdapter;

        private ConsultaMillas() {
            this.InitializeComponent();
        }

        public static ConsultaMillas getInstance() {

            if (_instance == null) {
                _instance = new ConsultaMillas();
            }

            return _instance;

        }

        private void consultarButton_Click(object sender, EventArgs e) {

            String dni_string = this.DNITextbox.Text;
         
            if (String.IsNullOrWhiteSpace(dni_string)) {
                MessageBox.Show("Debe ingresar un DNI para consultar las millas de un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int dni = Convert.ToInt32(dni_string);

            DAO.connect();

            Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = " + dni });

            if (cliente == null) {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.clienteNameLabel.Text = cliente.Nombre + " " + cliente.Apellido;
            this.puntosLabel.Text = cliente.Puntos.ToString();

            String queryMillas = this.BuildQuery(cliente.Id);

            this.FillDataGrid(queryMillas);

            DAO.closeConnection();

        }

        private String BuildQuery(int clienteId) {

            String queryPasajes = "SELECT 'Pasaje' 'Tipo', "
                                        + "c.fecha_compra 'Fecha', "
                                        + "(p.precio / 10) 'Puntos' ";
            queryPasajes += " FROM BIEN_MIGRADO_RAFA.Pasaje p ";
            queryPasajes += " INNER JOIN BIEN_MIGRADO_RAFA.Compra_pasaje cp on cp.pasaje_id = p.id ";
            queryPasajes += " INNER JOIN BIEN_MIGRADO_RAFA.Compra c on c.id = cp.compra_id ";
            queryPasajes += " WHERE p.cliente_id = " + clienteId; 
            queryPasajes += " AND (c.fecha_compra BETWEEN DATEADD(year, -1, " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + ") AND " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + ")";
            queryPasajes += " AND p.activo = 1";

            String queryPaquetes = "SELECT 'Encomienda' 'Tipo', "
                                         + "c.fecha_compra 'Fecha', "
                                         + "(pq.precio / 10) 'Puntos' ";
            queryPaquetes += " FROM BIEN_MIGRADO_RAFA.Paquete pq ";
            queryPaquetes += " INNER JOIN BIEN_MIGRADO_RAFA.Compra_paquete cpq on cpq.paquete_id = pq.id ";
            queryPaquetes += " INNER JOIN BIEN_MIGRADO_RAFA.Compra c on c.id = cpq.compra_id ";
            queryPaquetes += " WHERE pq.cliente_id = " + clienteId;
            queryPaquetes += " AND (c.fecha_compra BETWEEN DATEADD(year, -1, " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + ") AND " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + ")";
            queryPaquetes += " AND pq.activo = 1";

            String queryCanjes = "SELECT 'Canje de puntos' 'Tipo', "
                                       + "c.fecha 'Fecha', "
                                       + "(c.cantidad * cat.costo) 'Puntos' ";
            queryCanjes += "FROM BIEN_MIGRADO_RAFA.Canje c, BIEN_MIGRADO_RAFA.Catalogo cat ";
            queryCanjes += "WHERE c.cliente_id = " + clienteId + " AND (c.fecha BETWEEN DATEADD(year, -1, " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + ") AND " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + ") AND c.catalogo_id = cat.id";

            return queryPasajes + " UNION " + queryPaquetes + " UNION " + queryCanjes + " ORDER BY Fecha DESC";

        }

        private void FillDataGrid(String query) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable();
            this.dataAdapter.Fill(table);

            if (table.Rows.Count == 0)
                MessageBox.Show("El cliente no ha realizado ninguna compra/canje aún.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.millasDataGrid.DataSource = table;

        }


    }

}
