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
        private DataTable pasajerosDatatable;
        private DataTable paquetesDatatable;
        private Viaje selectedViaje;
        private Aeronave selectedAeronave;

        private Compra() {
            this.InitializeComponent();
            this.pasajerosDatatable = new DataTable();
            this.paquetesDatatable = new DataTable();
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

            String query = this.getBaseQueryViajes();

            query += " WHERE ";

            query += "CAST(v.fecha_salida AS DATE) = CAST('" + fecha_salida.ToString("yyyy-MM-dd") + "' AS DATE) AND ";

            query += "r.ciudad_origen_id = " + id_origen + " AND ";

            query += "r.ciudad_destino_id = " + id_destino;

            this.FillDataGridViajes(query);

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
                    //TODO this.fechaNacimientoPickerPaquete.Value = cliente.Fecha_Nacimiento; 
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

            if (fechaSalida < Config.SystemConfig.systemDate) {
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

        private void FillDataGridViajes(string selectCommand) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            DataTable table = new DataTable();
            this.dataAdapter.Fill(table);

            if (table.Rows.Count == 0)
                MessageBox.Show("No se encontraron viajes con los parametros ingresados.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.viajesDataGrid.DataSource = table;

        }

        private void FillDataGridPasajeros(string selectCommand) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            this.dataAdapter.Fill(this.pasajerosDatatable);

            this.pasajerosDataGrid.DataSource = this.pasajerosDatatable;

        }

        private void FillDataGridPaquetes(string selectCommand) {

            String connectionString = DAO.makeConnectionString();

            this.dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            this.dataAdapter.Fill(this.paquetesDatatable);

            this.paquetesDataGrid.DataSource = this.paquetesDatatable;

        }

        private String getBaseQueryViajes() {

            String query = "";

            query += "SELECT a.id 'Aeronave ID', " +
                            "v.id 'Viaje ID', " +
                            "v.fecha_salida 'Fecha Salida', " +
                            "v.fecha_llegada_estimada 'Llegada estimada', " +
                            "a.matricula 'Matricula Aeronave', " +
                            "m.descripcion 'Modelo Aeronave', " +
                            "(SELECT count(1) FROM BIEN_MIGRADO_RAFA.Butaca butaca where butaca.aeronave_id = a.id) 'Butacas Disponibles', " +
                            "a.kilogramos_disponibles 'Kilogramos Disponibles' " +
                     "FROM BIEN_MIGRADO_RAFA.Viaje v " +
                     "INNER JOIN BIEN_MIGRADO_RAFA.Aeronave a ON v.aeronave_id = a.id " +
                     "INNER JOIN BIEN_MIGRADO_RAFA.Modelo m ON m.id = a.modelo_id " +
                     "INNER JOIN BIEN_MIGRADO_RAFA.Ruta r ON v.ruta_id = r.id";


            return query;

        }

        private String getBaseQueryPasajero(int butaca_numero) {

            String query = "";

            query += "SELECT c.id 'Cliente ID', " +
                            "c.dni 'Cliente DNI', " +
                            "c.nombre 'Cliente Nombre', " +
                            "c.apellido 'Cliente Apellido', " +
                            butaca_numero + " 'Butaca' " +
                     "FROM BIEN_MIGRADO_RAFA.Cliente c ";

            return query;

        }

        private String getBaseQueryPaquete(int peso) {

            String query = "";

            query += "SELECT c.id 'Cliente ID', " +
                            "c.dni 'Cliente DNI', " +
                            "c.nombre 'Cliente Nombre', " +
                            "c.apellido 'Cliente Apellido', " +
                            peso + " 'Peso' " +
                     "FROM BIEN_MIGRADO_RAFA.Cliente c ";

            return query;

        }

        private void Compra_Load(object sender, EventArgs e) {

            this.ciudadTableAdapter1.Fill(this.dataSetCiudad2.Ciudad);
            this.ciudadTableAdapter.Fill(this.dataSetCiudad.Ciudad);

            viajesDataGrid.AutoResizeColumns();
            viajesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void agregarPasajeroButton_Click(object sender, EventArgs e) {

            if (this.selectedViaje == null) {
                MessageBox.Show("Debe seleccionar un viaje.");
                return;
            }

            if (String.IsNullOrWhiteSpace(this.documentoTextbox.Text)) {
                MessageBox.Show("Debe ingresar el DNI del cliente.");
                return;
            }

            String dni = this.documentoTextbox.Text;
            int butaca_id = (int)this.butacaCombo.SelectedValue;

            DAO.connect();
            Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = " + dni });
            if (cliente == null) {
                Cliente c = new Cliente();
                c.Apellido = this.apellidoTextbox.Text;
                c.Nombre = this.nombreTextbox.Text;
                c.DNI = Convert.ToInt32(this.documentoTextbox.Text);
                c.Email = this.emailTextbox.Text;
                c.Fecha_Nacimiento = this.fechaNacimientoPicker.Value;
                int id = DAO.insert<Cliente>(c);
                c.Id = id;
                cliente = c;
            }
            Butaca butaca = DAO.selectOne<Butaca>(new[] { "id = " + butaca_id });
            DAO.closeConnection();

            String query = this.getBaseQueryPasajero((int)butaca.Numero);

            query += " WHERE c.id = " + cliente.Id ;

            //butacaCombo.Items.RemoveAt(butacaCombo.SelectedIndex);  //sacar del dataset y updatear

            this.FillDataGridPasajeros(query);
        }

        private void agregarPaqueteButton_Click(object sender, EventArgs e){
            
            if (this.selectedViaje == null) {
                MessageBox.Show("Debe seleccionar un viaje.");
                return;
            }

            if (pesoBox.Text == "") {
                MessageBox.Show("Debe ingresar un valor en el campo de kilogramos disponibles.");
                return;
            }

            if (String.IsNullOrWhiteSpace(this.documentoTextboxPaquete.Text)) {
                MessageBox.Show("Debe ingresar el DNI del cliente.");
                return;
            }

            if (this.selectedAeronave.Kilogramos_Disponibles < Convert.ToInt32(pesoBox.Text)) {
                MessageBox.Show("Su encomienda supera el peso disponible de la aeronave.");
                return;
            }

            String dni = this.documentoTextboxPaquete.Text;

            DAO.connect();
            Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = '" + dni +"'" });
            if (cliente == null) {
                Cliente c = new Cliente();
                c.Apellido = this.apellidoTextboxPaquete.Text;
                c.Nombre = this.nombreTextboxPaquete.Text;
                c.DNI = Convert.ToInt32(this.documentoTextboxPaquete.Text);
                c.Email = this.emailTextboxPaquete.Text;
                c.Fecha_Nacimiento = this.fechaNacimientoPickerPaquete.Value;
                int id = DAO.insert<Cliente>(c);
                c.Id = id;
                cliente = c;
            }

            DAO.closeConnection();

            this.selectedAeronave.Kilogramos_Disponibles -= Convert.ToInt32(pesoBox.Text);

            String query = this.getBaseQueryPaquete(Convert.ToInt32(pesoBox.Text));

            query += " WHERE c.id = " + cliente.Id;

            this.FillDataGridPaquetes(query);

        }

        private void viajesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e){

            if (this.selectedViaje == null || (int)this.viajesDataGrid.SelectedRows[0].Cells[1].Value != this.selectedViaje.Id) {
                this.paquetesDatatable.Clear();
                this.pasajerosDatatable.Clear();
            }

            DataGridViewRow row = this.viajesDataGrid.SelectedRows[0];
            DAO.connect();
            this.selectedViaje = DAO.selectOne<Viaje>( new[] { "id = " + row.Cells[1].Value });
            this.selectedAeronave = this.selectedViaje.Aeronave;
            String connectionString = DAO.makeConnectionString(DBConfig.direccion, DBConfig.database, DBConfig.username, DBConfig.password);
            String selectCommand = "SELECT id, numero FROM BIEN_MIGRADO_RAFA.Butaca";
            selectCommand += " WHERE aeronave_id = " + row.Cells[0].Value.ToString();
            selectCommand += " AND id NOT IN (SELECT butaca_id FROM BIEN_MIGRADO_RAFA.Pasaje WHERE viaje_id = " + row.Cells[1].Value.ToString() + ")";
            selectCommand += " ORDER BY numero";
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            butacaCombo.DisplayMember = "numero";
            butacaCombo.ValueMember = "id";
            butacaCombo.DataSource = ds.Tables[0];

            DAO.closeConnection();
        }

        private List<String> buildDetalle(List<int> pasajerosIds, List<int> butacasNumeros, List<int> clientesIds, List<Decimal> pesos) {

            List<String> detalle = new List<String>();

            int i = 0;
            foreach (int id in pasajerosIds) {
                DAO.connect();
                Cliente cliente = DAO.selectOne<Cliente>( new[] {"id = " + id } );
                Decimal precioBase = this.selectedViaje.Ruta.Precio_Base_Pasajes;
                Decimal mult = this.selectedAeronave.Tipo_Servicio.Porcentaje;
                DAO.closeConnection();
                String str = "";
                str += "Pasaje - DNI Cliente: " + cliente.DNI + " - Precio: $" + precioBase * mult + " - Butaca: " + butacasNumeros[i]  + ".";
                detalle.Add(str);
                i++;
            }

            int j = 0;
            foreach (int id in clientesIds) {
                DAO.connect();
                Cliente cliente = DAO.selectOne<Cliente>(new[] { "id = " + id });
                Decimal precioBase = this.selectedViaje.Ruta.Precio_Base_Kg;
                DAO.closeConnection();
                String str = "";
                str += "Encomienda - DNI Cliente: " + cliente.DNI + " - Precio: $" + precioBase * pesos[j] + " - Peso: " + pesos[j] + " kg.";
                detalle.Add(str);
                j++;
            }

            return detalle;

        }

        private void confirmarCompraButton_Click(object sender, EventArgs e) {

            List<int> pasajerosIds = new List<int>();
            List<int> butacasNumeros = new List<int>();

            List<int> clientesIds = new List<int>();
            List<Decimal> pesos = new List<Decimal>();

            foreach (DataRow d in this.pasajerosDatatable.Rows) {
                pasajerosIds.Add((int)d.ItemArray[0]);
                butacasNumeros.Add((int)d.ItemArray[4]);
            }

            foreach (DataRow d in this.paquetesDatatable.Rows) {
                clientesIds.Add((int)d.ItemArray[0]);
                pesos.Add(Convert.ToDecimal(d.ItemArray[4]));
            }

            if (pasajerosIds.Count == 0 && clientesIds.Count == 0) {
                MessageBox.Show("No selecciono nada para comprar.");
                return;
            }

            List<String> detalle = this.buildDetalle(pasajerosIds, butacasNumeros, clientesIds, pesos);

            List<int> pasajesIds = new List<int>();

            int i = 0;
            foreach (int p in pasajerosIds) {
                Pasaje pasaje = new Pasaje();
                pasaje.Viaje_id = selectedViaje.Id;
                pasaje.Cliente_Id = p;
                pasaje.Butaca_Id = butacasNumeros[i];
                Decimal precioBase = this.selectedViaje.Ruta.Precio_Base_Pasajes;
                Decimal mult = this.selectedAeronave.Tipo_Servicio.Porcentaje;
                pasaje.Precio = precioBase * mult;
                pasaje.Codigo = 0; // TODO
                DAO.connect();
                int id = DAO.insert<Pasaje>(pasaje);
                DAO.closeConnection();
                pasajesIds.Add(id);
                i++;
            }

            List<int> paquetesIds = new List<int>();

            int j = 0;
            foreach (int p in clientesIds) {
                Paquete paquete = new Paquete();
                paquete.Viaje_Id = selectedViaje.Id;
                paquete.Cliente_Id = p;
                Decimal precioBase = this.selectedViaje.Ruta.Precio_Base_Kg;
                paquete.Precio = precioBase * pesos[j];
                paquete.Codigo = 0; // TODO
                DAO.connect();
                int id = DAO.insert<Paquete>(paquete);
                DAO.closeConnection();
                paquetesIds.Add(id);
                j++;
            }

            Confirmacion confirmacionDialog = new Confirmacion(detalle, pasajesIds, paquetesIds);
            var dr = confirmacionDialog.ShowDialog();

        }


    }
}
