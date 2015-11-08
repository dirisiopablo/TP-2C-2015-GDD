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
            this.puntosLabel.Text = this.calcularPuntos(cliente.Id).ToString();

            String queryMillas = this.BuildQuery(cliente.Id);

            this.FillDataGrid(queryMillas);

            DAO.closeConnection();

        }

        private String BuildQuery(int clienteId) {

            String queryPasajes = "SELECT 'Pasaje' 'Tipo', "
                                        + "p.fecha_compra 'Fecha', "
                                        + "(p.precio / 10) 'Puntos' ";
            queryPasajes += "FROM BIEN_MIGRADO_RAFA.Pasaje p WHERE p.cliente_id = " + clienteId + " AND (p.fecha_compra BETWEEN DATEADD(year, -1, GETDATE()) AND GETDATE())";

            String queryPaquetes = "SELECT 'Encomienda' 'Tipo', "
                                         + "pq.fecha_compra 'Fecha', "
                                         + "(pq.precio / 10) 'Puntos' ";
            queryPaquetes += "FROM BIEN_MIGRADO_RAFA.Paquete pq WHERE pq.cliente_id = " + clienteId + " AND (pq.fecha_compra BETWEEN DATEADD(year, -1, GETDATE()) AND GETDATE())";

            String queryCanjes = "SELECT 'Canje de puntos' 'Tipo', "
                                       + "c.fecha 'Fecha', "
                                       + "(c.cantidad * cat.costo) 'Puntos' ";
            queryCanjes += "FROM BIEN_MIGRADO_RAFA.Canje c, BIEN_MIGRADO_RAFA.Catalogo cat ";
            queryCanjes += "WHERE c.cliente_id = " + clienteId + " AND (c.fecha BETWEEN DATEADD(year, -1, GETDATE()) AND GETDATE()) AND c.catalogo_id = cat.id";

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

        private int calcularPuntos(int clienteId) {

            DAO.connect();

            String condicionFecha = "BETWEEN DATEADD(year, -1, GETDATE()) AND GETDATE() ";

            List<Pasaje> pasajes = DAO.selectAll<Pasaje>(new[] { "cliente_id = " + clienteId, "( fecha_compra " + condicionFecha + ")"});
            List<Paquete> paquetes = DAO.selectAll<Paquete>(new[] { "cliente_id = " + clienteId, "( fecha_compra " + condicionFecha + ")" });
            List<Canje> canjes = DAO.selectAll<Canje>(new[] { "cliente_id = " + clienteId, "( fecha " + condicionFecha + ")" });

            DAO.closeConnection();

            decimal puntos = 0;

            foreach (Pasaje p in pasajes)
                puntos += p.Precio / 10;

            foreach (Paquete p in paquetes)
                puntos += p.Precio / 10;
           
            foreach (Canje c in canjes)
                puntos -= c.Cantidad * c.Catalogo.Costo;

            return (int)puntos;

        }

    }

}
