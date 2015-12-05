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
using AerolineaFrba.ABM.Abm_Aeronave;
using AerolineaFrba.Config;

namespace AerolineaFrba.Abm_Aeronave {
    public sealed partial class ABMAeronave : Form {

        private static ABMAeronave _instance = null;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        private ABMAeronave() {
            this.InitializeComponent();
            this.bajaInput.SelectedIndex = 0;
        }

        public static ABMAeronave getInstance() {

            if (_instance == null) {
                _instance = new ABMAeronave();
            }

            return _instance;

        }

        private void NuevoAeronave_Click(object sender, EventArgs e) {

            AeronaveDialog aeronaveDialog = new AeronaveDialog("", 1, 0, 1, 1, Enums.tipoDialog.nuevo);
            aeronaveDialog.ShowDialog();

            if (aeronaveDialog.dr == DialogResult.Cancel) return;

            String nuevaMatricula = aeronaveDialog.matricula;
            int nuevoModelo = aeronaveDialog.modelo;
            decimal nuevoKgDisponibles = aeronaveDialog.kgDisponibles;
            int nuevoFabricante = aeronaveDialog.fabricante;
            int tipoServicioId = aeronaveDialog.tipoServicioId;

            DAO.connect();

            Aeronave aeronave = new Aeronave();
            aeronave.Matricula = nuevaMatricula;
            aeronave.Modelo_Id = nuevoModelo;
            aeronave.Kilogramos_Disponibles = nuevoKgDisponibles;
            aeronave.Fabricante_Id = nuevoFabricante;
            aeronave.Tipo_Servicio_Id = tipoServicioId;
            int idInsertado = DAO.insert<Aeronave>(aeronave);

            DAO.closeConnection();

            this.insertarButacas(aeronaveDialog.cantidadPasillo1, idInsertado, "Pasillo");
            this.insertarButacas(aeronaveDialog.cantidadVentana1, idInsertado, "Ventanilla");
            this.insertarButacas(aeronaveDialog.cantidadPasillo2, idInsertado, "Pasillo");
            this.insertarButacas(aeronaveDialog.cantidadVentana2, idInsertado, "Ventanilla");

            //this.aeronaveTableAdapter.Fill(this.dataSetAeronave.Aeronave);
            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);

        }

        private void ModificarAeronave_Click(object sender, EventArgs e) {

            if (this.aeronaveDataGrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir una aeronave a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.aeronaveDataGrid.SelectedRows.Count > 1) {
                MessageBox.Show("Solo puede elegir una aeronave a modificar a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.aeronaveDataGrid.SelectedRows[0];

            //int id = (int)row.Cells[0].Value;
            String matricula = (String)row.Cells[0].Value;

            Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "matricula = '" + matricula + "' " });

            AeronaveDialog aeronaveDialog = new AeronaveDialog(matricula, aeronave.Modelo_Id, aeronave.Kilogramos_Disponibles, aeronave.Fabricante_Id, aeronave.Tipo_Servicio_Id, Enums.tipoDialog.modificar);
            var dr = aeronaveDialog.ShowDialog();

            if (aeronaveDialog.dr == DialogResult.Cancel) return;

            String nuevaMatricula = aeronaveDialog.matricula;
            int nuevoModelo = aeronaveDialog.modelo;
            decimal nuevoKgDisponibles = aeronaveDialog.kgDisponibles;
            int nuevoFabricante = aeronaveDialog.fabricante;
            int tipoServicioId = aeronaveDialog.tipoServicioId;

            DAO.connect();

            Aeronave aeronaveMod = DAO.selectOne<Aeronave>(new[] { "matricula = '" + matricula +"' " });
            aeronaveMod.Matricula = nuevaMatricula;
            aeronaveMod.Modelo_Id = nuevoModelo;
            aeronaveMod.Kilogramos_Disponibles = nuevoKgDisponibles;
            aeronaveMod.Fabricante_Id = nuevoFabricante;
            aeronaveMod.Tipo_Servicio_Id = tipoServicioId;
            int idInsertado = DAO.update<Aeronave>(aeronaveMod);

            DAO.closeConnection();

            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);
        }


        private void ABMAeronave_Load(object sender, EventArgs e) {
            this.fabricanteTableAdapter.Fill(this.gD2C2015DataSet10.Fabricante);
            this.modeloTableAdapter.Fill(this.gD2C2015DataSet9.Modelo);
            this.tipo_ServicioTableAdapter.Fill(this.gD2C2015DataSet8.Tipo_Servicio);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string query = obtenerQueryBase();

            if (!validar()) return;

            String matricula = this.matriculaInput.Text;
            int modeloId = (int)this.modeloCombo.SelectedValue;
            int kilogramos = Int32.Parse(this.kilogramosInput.Text);
            int fabricanteId = (int)this.fabricanteCombo.SelectedValue;
            int cantidadButacas = Int32.Parse(this.butacasInput.Text);
            String baja = this.bajaInput.Text;
            int tipoServicioId = (int)this.tipoServicioCombo.SelectedValue;
            bool tipoServicioTodos = this.tipoServicioTodosCheckBox.Checked;
            bool modeloTodos = this.modeloTodos.Checked;
            bool fabricanteTodos = this.fabricanteTodos.Checked;


            if (matricula != null && matricula != "")
            {
                query += " aero.matricula LIKE " + "'%" + matricula + "%' AND ";
            }

            if (modeloId != 0 && !modeloTodos)
            {
                query += " aero.modelo_id = " + modeloId + " AND ";
            }

            if (kilogramos != 0)
            {
                query += " aero.kilogramos_disponibles > " + kilogramos + " AND ";
            }

            if (fabricanteId != 0 && !fabricanteTodos)
            {
                query += " aero.fabricante_id = " + fabricanteId + " AND ";
            }

            if (cantidadButacas != 0)
            {
                query += "(SELECT count(1) FROM BIEN_MIGRADO_RAFA.Butaca butaca where butaca.aeronave_id = aero.id) > " + cantidadButacas + " AND ";
            }

            if (baja != "" && baja != "Todas las aeronaves")
            {
                query += "(SELECT TOP 1 tb.descripcion FROM BIEN_MIGRADO_RAFA.Baja_Aeronave ba JOIN BIEN_MIGRADO_RAFA.Tipo_Baja tb on ba.tipo_baja_id = tb.id WHERE  ba.aeronave_id = aero.id order by ba.fecha_baja DESC) = '" + baja + "' AND ";
            }

            if (tipoServicioId != 0 && !tipoServicioTodos)
            {
                query += " aero.tipo_servicio_id = " + tipoServicioId + " AND ";
            }

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
            aeronaveDataGrid.DataSource = table;

            DAO.closeConnection();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.matriculaInput.Text = "";
            this.kilogramosInput.Text = "0";
            this.butacasInput.Text = "0";
            this.bajaInput.Text = "";
            this.tipoServicioTodosCheckBox.Checked = true;
            this.modeloTodos.Checked = true;
            this.fabricanteTodos.Checked = true;
        }

        private void insertarButacas(int cantidadButacas, int idAeronave, string tipoButaca) {
            for (int i = 1; i <= cantidadButacas; i++)
            {
                DAO.connect();
                Butaca butaca = new Butaca();
                butaca.Numero = i;
                butaca.Piso = 1;
                butaca.Tipo = tipoButaca;
                butaca.Aeronave_Id = idAeronave;
                int idButaca = DAO.insert<Butaca>(butaca);
                DAO.closeConnection();
            }
        }

        private string obtenerQueryBase()
        {
            return "SELECT aero.matricula 'Matrícula', " +
                            "t2.descripcion 'Modelo', " +
                            "aero.kilogramos_disponibles 'Kilogramos Disponibles', " +
                            "t3.descripcion 'Fabricante', " +
                            "(SELECT count(1) FROM BIEN_MIGRADO_RAFA.Butaca butaca where butaca.aeronave_id = aero.id) as 'Cantidad Butacas', " +
                            "isnull((SELECT TOP 1 CASE WHEN ba.fecha_reinicio is not null THEN 'SI' WHEN ba.fecha_reinicio is null THEN 'NO' ELSE 'SI' END FROM BIEN_MIGRADO_RAFA.Baja_Aeronave ba where ba.aeronave_id = aero.id order by ba.fecha_baja DESC), 'SI') as 'Activo', " +
                            "isnull((SELECT TOP 1 tb.descripcion FROM BIEN_MIGRADO_RAFA.Baja_Aeronave ba JOIN BIEN_MIGRADO_RAFA.Tipo_Baja tb on ba.tipo_baja_id = tb.id WHERE  ba.aeronave_id = aero.id order by ba.fecha_baja DESC), '---') as 'Tipo Baja', " +
                            "t1.descripcion 'Tipo de Servicio' " +
                            "FROM BIEN_MIGRADO_RAFA.Aeronave aero " +
                            "JOIN BIEN_MIGRADO_RAFA.Fabricante t3 ON t3.id = aero.fabricante_id " +
                            "JOIN BIEN_MIGRADO_RAFA.Modelo t2 ON t2.id = aero.modelo_id " +
                            "JOIN BIEN_MIGRADO_RAFA.Tipo_Servicio t1 ON t1.id = aero.tipo_servicio_id WHERE";
        }

        private void bajaAeronave_Click(object sender, EventArgs e)
        {
            if (this.aeronaveDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir una aeronave para dar de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.aeronaveDataGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Solo puede elegir una aeronave para dar de baja a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.aeronaveDataGrid.SelectedRows[0];

            String matricula = (String)row.Cells[0].Value;
            String modelo = (String)row.Cells[1].Value;
            decimal kgDisponibles = Convert.ToDecimal(row.Cells[2].Value);
            String fabricante = (String)row.Cells[3].Value;

            AeronaveBaja aeronaveBaja = new AeronaveBaja(matricula);
            var dr = aeronaveBaja.ShowDialog();

            if (aeronaveBaja.dr == DialogResult.Cancel) return;
            
            DAO.connect();

            Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "matricula = '" + matricula + "' " });

            BajaAeronave bajaAeronave = new BajaAeronave();
            bajaAeronave.Aeronave_Id = aeronave.Id;
            bajaAeronave.Tipo_Baja_Id = aeronaveBaja.tipoBajaId;
            bajaAeronave.Fecha_Baja = Config.SystemConfig.systemDate;
            int idInsertado = DAO.insert<BajaAeronave>(bajaAeronave);

            DAO.closeConnection();

            string query = obtenerQueryBase();
            query = query.Substring(0, query.Length - 5);

            GetData(query);
        }

        private Boolean validar()
        {
            if (kilogramosInput.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de kilogramos disponibles.");
                return false;
            }

            if (butacasInput.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el campo de butacas disponibles.");
                return false;
            }

            return true;
        }


    }
}
