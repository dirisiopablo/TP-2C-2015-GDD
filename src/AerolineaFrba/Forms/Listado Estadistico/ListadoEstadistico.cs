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

            String query = "";

            query += "select top 5 d.descripcion as 'Destino', count(1) as 'Ventas'";
            query += " from BIEN_MIGRADO_RAFA.Compra_Pasaje";
            query += " inner join BIEN_MIGRADO_RAFA.Pasaje p on pasaje_id = p.id";
            query += " inner join BIEN_MIGRADO_RAFA.Viaje v on p.viaje_id = v.id";
            query += " inner join BIEN_MIGRADO_RAFA.Ruta r on v.ruta_id = r.id";
            query += " inner join BIEN_MIGRADO_RAFA.Ciudad d on r.ciudad_destino_id = d.id";
            query += " inner join BIEN_MIGRADO_RAFA.Compra c on compra_id = c.id";

            query += " WHERE (c.fecha_compra " + rango + ")";

            query += " group by d.descripcion";
            query += " order by count(1) DESC"; 

            DataTable table = this.buildDatatable(query);

            TableDialog dialog = new TableDialog(table, title);

            dialog.ShowDialog();


        }

        private void destinosVaciosButton_Click(object sender, EventArgs e) {

            String title = "Destinos más comprados";

            String rango = this.getRango();

            String query = "SELECT top 5    c.descripcion 'Ciudad destino', " +
		                                    "(SELECT count(*) FROM BIEN_MIGRADO_RAFA.Ciudad d " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Ruta r ON r.ciudad_destino_id = pv.destinoId " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Viaje v ON v.ruta_id = r.id " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Aeronave a ON v.aeronave_id = a.id " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Butaca b ON b.aeronave_id = a.id " +
				                                    "where d.id = pv.destinoId AND v.fecha_salida " + rango + ") 'Butacas totales', " +
		                                    "pv.viajesTotales 'Butacas vendidas', " +
		                                    "((SELECT count(*) FROM BIEN_MIGRADO_RAFA.Ciudad d " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Ruta r ON r.ciudad_destino_id = pv.destinoId " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Viaje v ON v.ruta_id = r.id " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Aeronave a ON v.aeronave_id = a.id " +
				                                    "JOIN BIEN_MIGRADO_RAFA.Butaca b ON b.aeronave_id = a.id " +
                                                    "where d.id = pv.destinoId AND v.fecha_salida " + rango + ") - pv.viajesTotales) 'Butacas libres', " +
		                                    "1 - CAST(pv.viajesTotales AS DECIMAL) / (SELECT count(*) FROM BIEN_MIGRADO_RAFA.Ciudad d " +
								                                    "JOIN BIEN_MIGRADO_RAFA.Ruta r ON r.ciudad_destino_id = pv.destinoId " +
								                                    "JOIN BIEN_MIGRADO_RAFA.Viaje v ON v.ruta_id = r.id " +
								                                    "JOIN BIEN_MIGRADO_RAFA.Aeronave a ON v.aeronave_id = a.id " +
								                                    "JOIN BIEN_MIGRADO_RAFA.Butaca b ON b.aeronave_id = a.id " +
                                                                    "where d.id = pv.destinoId AND v.fecha_salida " + rango + ") 'Porcentaje butacas libres' " +
                                "FROM (SELECT COUNT(*) viajesTotales, d.id destinoId FROM BIEN_MIGRADO_RAFA.Ciudad d " +
		                                "JOIN BIEN_MIGRADO_RAFA.Ruta r ON r.ciudad_destino_id = d.id " +
		                                "JOIN BIEN_MIGRADO_RAFA.Viaje v ON v.ruta_id = r.id " +
		                                "JOIN BIEN_MIGRADO_RAFA.Aeronave a ON v.aeronave_id = a.id " +
		                                "JOIN BIEN_MIGRADO_RAFA.Pasaje p ON p.viaje_id = v.id " +
                                        "WHERE v.fecha_salida " + rango + " group by d.id) pv " +
                                "JOIN BIEN_MIGRADO_RAFA.Ciudad c ON c.id = pv.destinoId " +
                                "order by 'Porcentaje butacas libres' DESC";
            
            DataTable table = this.buildDatatable(query);

            TableDialog dialog = new TableDialog(table, title);

            dialog.ShowDialog();

        }

        private void clientesPuntosButton_Click(object sender, EventArgs e) {

            String title = "Clientes con más puntos acumulados";
            
            String rango = this.getRango();


            String queryPasajes = "";

            queryPasajes += "(select sum(precio) from BIEN_MIGRADO_RAFA.Pasaje p ";
            queryPasajes += "inner join BIEN_MIGRADO_RAFA.Compra c on c.cliente_id = cl.id ";
            queryPasajes += "inner join BIEN_MIGRADO_RAFA.Compra_Pasaje cp on c.id = cp.compra_id and cp.pasaje_id = p.id ";
            queryPasajes += " WHERE (c.fecha_compra " + rango + ")";
            queryPasajes += ") ";

            String queryPaquetes = "";

            queryPaquetes += "(select sum(precio) from BIEN_MIGRADO_RAFA.Paquete p ";
            queryPaquetes += "inner join BIEN_MIGRADO_RAFA.Compra c on c.cliente_id = cl.id ";
            queryPaquetes += "inner join BIEN_MIGRADO_RAFA.Compra_Paquete cp on c.id = cp.compra_id and cp.paquete_id = p.id ";
            queryPaquetes += " WHERE (c.fecha_compra " + rango + ")";
            queryPaquetes += ") ";

            String queryCanjes = "";

            queryCanjes += "(select sum(c.cantidad * cat.costo) from BIEN_MIGRADO_RAFA.Canje c ";
            queryCanjes += "inner join BIEN_MIGRADO_RAFA.Catalogo cat on c.catalogo_id = cat.id ";
            queryCanjes += "where c.cliente_id = cl.id ";
            queryCanjes += "and (c.fecha " + rango + ") ";
            queryCanjes += ") ";

            String queryPuntos = queryPasajes + " + " + queryPaquetes + " - " + queryCanjes;  

            String query = "";

            query += "select top 5 cl.nombre + ' ' + cl.apellido as 'Cliente', " + queryPuntos + " as 'Puntos Acumulados' ";
            query += " from BIEN_MIGRADO_RAFA.Cliente cl";
            query += " order by [Puntos Acumulados] DESC"; 

            DataTable table = this.buildDatatable(query);

            TableDialog dialog = new TableDialog(table, title);

            dialog.ShowDialog();

        }

        private void destinosCanceladosButton_Click(object sender, EventArgs e) {

            String title = "Destinos más cancelados";

            String rango = this.getRango();

            String query = "";

            query += "select top 5 d.descripcion as 'Destino', count(1) as 'Cancelaciones'";
            query += " from BIEN_MIGRADO_RAFA.Cancelacion_Pasaje";
            query += " inner join BIEN_MIGRADO_RAFA.Pasaje p on pasaje_id = p.id";
            query += " inner join BIEN_MIGRADO_RAFA.Viaje v on p.viaje_id = v.id";
            query += " inner join BIEN_MIGRADO_RAFA.Ruta r on v.ruta_id = r.id";
            query += " inner join BIEN_MIGRADO_RAFA.Ciudad d on r.ciudad_destino_id = d.id";
            query += " inner join BIEN_MIGRADO_RAFA.Cancelacion c on cancelacion_id = c.id";

            query += " WHERE (c.fecha " + rango + ")";

            query += " group by d.descripcion";
            query += " order by count(1) DESC";

            DataTable table = this.buildDatatable(query);

            TableDialog dialog = new TableDialog(table, title);

            dialog.ShowDialog();

        }

        private void aeronaveBajaButton_Click(object sender, EventArgs e) {

            String title = "Aeronaves con más días fuera de servicio";

            String rango = this.getRango();

            String query = "";

            query += "select top 5 a.matricula as 'Matrícula', sum(DATEDIFF(DAY, b.fecha_baja, b.fecha_reinicio)) as 'Días fuera de servicio'";
            query += " from BIEN_MIGRADO_RAFA.Aeronave a";
            query += " inner join BIEN_MIGRADO_RAFA.Baja_Aeronave b on a.id = b.aeronave_id";

            query += " WHERE (b.fecha_baja " + rango + ") AND b.tipo_baja_id != 2";

            query += " group by a.matricula";
            query += " order by count(1) DESC";


            DataTable table = this.buildDatatable(query);

            TableDialog dialog = new TableDialog(table, title);

            dialog.ShowDialog();

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

            int year = Config.SystemConfig.systemDate.Year;

            int from = year - 3;
            int to = year + 3;

            for (int i = from; i <= to; i++)
                dataSource.Add(new Anio() { Value = i });
        
            this.anioCombo.DataSource = dataSource;
            this.anioCombo.DisplayMember = "Value";
            this.anioCombo.ValueMember = "Value";

        }

        private String getRango() {

            String rango;
            int anio = (int)this.anioCombo.SelectedValue;

            DateTime firstDayOfYear = new DateTime(anio, 1, 1);
            DateTime lastDayFirstSemester = new DateTime(anio, 6, 30);
            DateTime firstDayLastSemester = new DateTime(anio, 7, 1);
            DateTime lastDayOfYear = new DateTime(anio, 12, 31);

            String a = firstDayOfYear.ToString("yyyyMMdd HH:mm:ss");
            String b = lastDayFirstSemester.ToString("yyyyMMdd HH:mm:ss");
            String c = firstDayLastSemester.ToString("yyyyMMdd HH:mm:ss");
            String d = lastDayOfYear.ToString("yyyyMMdd HH:mm:ss");

            if (this.semestreCombo.SelectedIndex == 0) {
                rango = "BETWEEN '" + a + "' AND '" + b + "'";
            }
            else {
                rango = "BETWEEN '" + c + "' AND '" + d + "'";
            }

            return rango;

        }

    }

    public class Anio {
        public int Value { get; set; }
    }

}
