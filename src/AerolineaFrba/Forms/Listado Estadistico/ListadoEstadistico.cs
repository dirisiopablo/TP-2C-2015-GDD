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

using AerolineaFrba.Services;
using AerolineaFrba.Models;

namespace AerolineaFrba.Forms.Listado_Estadistico {

    public partial class ListadoEstadistico : Form {

        private static ListadoEstadistico _instance = null;
        private SqlDataAdapter dataAdapter;

        private ListadoEstadistico() {
            this.InitializeComponent();
            this.populateAniosCombo();
            this.anioCombo.SelectedIndex = 0;
            this.semestreCombo.SelectedIndex = 0;
        }

        public static ListadoEstadistico getInstance() {

            if (_instance == null) {
                _instance = new ListadoEstadistico();
            }

            return _instance;
        }

        private void destinosPasajesButton_Click(object sender, EventArgs e) {
            String title = "Destinos más comprados";

            String rango = this.getRango();

            String tabla = Viaje.TableName + " v";
            String pasajeTabla = Pasaje.TableName + " p";
            String rutaTabla = Ruta.TableName + " r";
            String ciudadTabla = Ciudad.TableName + " c";

            String query = "";
            query += "SELECT TOP 5 c.descripcion as 'Destino', count(1) as 'Ventas'" + " FROM " + tabla;
            query += " INNER JOIN " + pasajeTabla + " ON p.viaje_id = v.id";
            query += " INNER JOIN " + rutaTabla + " ON v.ruta_id = r.id";
            query += " INNER JOIN " + ciudadTabla + " ON r.ciudad_destino_id = c.id";
            query += " WHERE (p.fecha_compra " + rango + ")";
            query += " GROUP BY c.descripcion";
            query += " ORDER BY 'Ventas' DESC";

            DataTable table = this.buildDatatable(query);

            TableDialog dialog = new TableDialog(table, title);

            dialog.ShowDialog();


        }

        private void destinosVaciosButton_Click(object sender, EventArgs e) {

        }

        private void clientesPuntosButton_Click(object sender, EventArgs e) { //FIXME fechas

            String title = "Clientes con más puntos acumulados";
            
            String rango = this.getRango();

            String tabla = Cliente.TableName + " c";
            String pasajeTabla = Pasaje.TableName + " p";
            String paqueteTabla = Paquete.TableName + " pq";

            String puntos = "( SELECT ( CAST (SUM(p.precio) + SUM(pq.precio) AS INT) / 10 ) ) AS 'puntos acumulados'";

            String query = "";
            query += "SELECT TOP 5 c.id, " + puntos + " FROM " + tabla;
            query += " INNER JOIN " + pasajeTabla + " ON p.cliente_id = c.id";
            query += " INNER JOIN " + paqueteTabla + " ON pq.cliente_id = c.id";
            query += " WHERE (p.fecha_compra " + rango + ") AND (pq.fecha_compra " + rango + ")";
            query += " GROUP BY c.id, p.cliente_id, pq.cliente_id";
            query += " ORDER BY 'puntos acumulados' DESC";

            DataTable table = this.buildDatatable(query);

            TableDialog dialog = new TableDialog(table, title);

            dialog.ShowDialog();

        }

        private void destinosCanceladosButton_Click(object sender, EventArgs e) {

        }

        private void aeronaveBajaButton_Click(object sender, EventArgs e) {

        }

        //-- private functions

        private DataTable buildDatatable(String query) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable();

            this.dataAdapter.Fill(table);

            return table;

        }

        private void populateAniosCombo() {

            var dataSource = new List<Anio>();

            //dataSource.Add(new Anio() { Value = 2010 });
            //dataSource.Add(new Anio() { Value = 2011 });
            //dataSource.Add(new Anio() { Value = 2012 });
            //dataSource.Add(new Anio() { Value = 2013 });
            dataSource.Add(new Anio() { Value = 2014 });
            dataSource.Add(new Anio() { Value = 2015 });
            dataSource.Add(new Anio() { Value = 2016 });
            dataSource.Add(new Anio() { Value = 2017 });

            this.anioCombo.DataSource = dataSource;
            this.anioCombo.DisplayMember = "Value";
            this.anioCombo.ValueMember = "Value";

        }

        private String getRango() {

            String rango;
            String anio = this.anioCombo.SelectedValue.ToString();

            if (this.semestreCombo.SelectedIndex == 0) {
                rango = "BETWEEN '" + anio + "-01-01'" + " AND '" + anio + "-06-31'";
            }
            else {
                rango = "BETWEEN '" + anio + "-07-01'" + " AND '" + anio + "-12-31'";
            }

            return rango;

        }

    }

    public class Anio {
        public int Value { get; set; }
    }

}
