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

namespace AerolineaFrba.Forms.Compra {
    public sealed partial class Compra : Form {
       
        private static Compra _instance = null;
        private SqlDataAdapter dataAdapter;

        private Compra() {
            this.InitializeComponent();
        }

        public static Compra getInstance() {

            if (_instance == null) {
                _instance = new Compra();
            }

            return _instance;

        }

        private void buscarButton_Click(object sender, EventArgs e) {

            DateTime fecha_salida = this.salidaPicker.Value;
            int id_origen = (int)this.origenCombo.SelectedValue;
            int id_destino = (int)this.destinoCombo.SelectedValue;

            String error = "";
            if (!this.validarBusqueda(fecha_salida, id_origen, id_destino, ref error)) {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String query = this.getBaseQuery();

            query += " WHERE ";

            query += "CAST(v.fecha_salida AS DATE) = CAST('" + fecha_salida.ToString("yyyy-MM-dd") + "' AS DATE) AND ";

            query += "r.ciudad_origen_id = " + id_origen + " AND ";

            query += "r.ciudad_destino_id = " + id_destino;

            this.FillDataGrid(query);

        }

        //autocompleta campos
        private void documentoTextbox_TextChanged(object sender, EventArgs e) {
            //documentos de 7 u 8 digitos
            if (this.documentoTextbox.Text.Length == 7 || this.documentoTextbox.Text.Length == 8) {

                String dni = this.documentoTextbox.Text;
                DAO.connect();
                Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = " + dni });
                DAO.closeConnection();

                if (cliente != null) {
                    this.nombreTextbox.Text = cliente.Nombre;
                    this.apellidoTextbox.Text = cliente.Apellido;
                    this.direccionTextbox.Text = cliente.Direccion;
                    this.emailTextbox.Text = cliente.Email;
                    //this.fechaNacimientoPicker.Value = cliente.Fecha_Nacimiento;
                }
                else {
                    this.nombreTextbox.Text = "";
                    this.apellidoTextbox.Text = "";
                    this.direccionTextbox.Text = "";
                    this.emailTextbox.Text = "";
                }

            }

        }

        private void documentoTextboxPaquete_TextChanged(object sender, EventArgs e) {
            //documentos de 7 u 8 digitos
            if (this.documentoTextboxPaquete.Text.Length == 7 || this.documentoTextboxPaquete.Text.Length == 8) {

                String dni = this.documentoTextboxPaquete.Text;
                DAO.connect();
                Cliente cliente = DAO.selectOne<Cliente>(new[] { "DNI = " + dni });
                DAO.closeConnection();

                if (cliente != null) {
                    this.nombreTextboxPaquete.Text = cliente.Nombre;
                    this.apellidoTextboxPaquete.Text = cliente.Apellido;
                    this.direccionTextboxPaquete.Text = cliente.Direccion;
                    this.emailTextboxPaquete.Text = cliente.Email;
                    //this.fechaNacimientoPickerPaquete.Value = cliente.Fecha_Nacimiento;
                }
                else {
                    this.nombreTextboxPaquete.Text = "";
                    this.apellidoTextboxPaquete.Text = "";
                    this.direccionTextboxPaquete.Text = "";
                    this.emailTextboxPaquete.Text = "";
                }

            }
        }

        private bool validarBusqueda(DateTime fechaSalida, int id_origen, int id_destino, ref String error) {

            if (fechaSalida < DateTime.Now) {
                error = "La fecha de salida ingresada no puede ser menor a la fecha actual.";
                return false;
            }

            if (id_origen == 0) { 
                error = "Debe seleccionar una ciudad de origen para el vuelo.";
                return false;
            }

            if (id_destino == 0) {
                error = "Debe seleccionar una ciudad de destino para el vuelo.";
                return false;
            }

            return true;
        }

        private void FillDataGrid(string selectCommand) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            DataTable table = new DataTable();
            this.dataAdapter.Fill(table);

            if (table.Rows.Count == 0)
                MessageBox.Show("No se encontraron viajes con los parametros ingresados.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.viajesDataGrid.DataSource = table;

        }

        private String getBaseQuery() {

            String query = "";

            query += "SELECT v.fecha_salida 'Fecha Salida', " +
                            "v.fecha_llegada_estimada 'Llegada estimada', " +
                            "a.matricula 'Matricula Aeronave', " +
                            "a.modelo 'Modelo Aeronave', " +
                            "(SELECT count(1) FROM BIEN_MIGRADO_RAFA.Butaca butaca where butaca.aeronave_id = a.id) 'Butacas Disponibles', " +
                            "a.kilogramos_disponibles 'Kilogramos Disponibles' " +
                     "FROM BIEN_MIGRADO_RAFA.Viaje v " +
                     "INNER JOIN BIEN_MIGRADO_RAFA.Aeronave a ON v.aeronave_id = a.id " +
                     "INNER JOIN BIEN_MIGRADO_RAFA.Ruta r ON v.ruta_id = r.id";

            return query;

        }

        private void Compra_Load(object sender, EventArgs e) {

            this.ciudadTableAdapter1.Fill(this.dataSetCiudad2.Ciudad);
            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);

            viajesDataGrid.AutoResizeColumns();
            viajesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

    }
}
