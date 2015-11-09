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


namespace AerolineaFrba.Forms.Canje_Millas {

    public sealed partial class CanjeMillas : Form {

        private static CanjeMillas _instance = null;
        private Cliente cliente_activo = null;
        private int[] indexer;

        private CanjeMillas() {

            this.InitializeComponent();
        }

        public static CanjeMillas getInstance() {

            if (_instance == null) {
                _instance = new CanjeMillas();
            }

            return _instance;

        }

        private void buscarClienteButton_Click(object sender, EventArgs e) {

            String dni_string = this.DNITextbox.Text;

            if (String.IsNullOrWhiteSpace(dni_string)) {
                MessageBox.Show("Debe ingresar un DNI para realizar un canje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int dni = Convert.ToInt32(dni_string);

            DAO.connect();

            Cliente cliente = DAO.selectOne<Cliente>(new[] { "dni = " + dni });

            if (cliente == null) {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.cliente_activo = cliente;
            this.clienteLabel.Text = cliente.Nombre + " " + cliente.Apellido;
            this.puntosLabel.Text = cliente.Puntos.ToString();

            this.populateCombo(cliente.Puntos);

        }

        private void canjearButton_Click(object sender, EventArgs e) {

            if (this.productosCombo.SelectedIndex == -1) {
                MessageBox.Show("Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.cantidadNumeric.Value == 0) {
                MessageBox.Show("Seleccione una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.cliente_activo == null) {
                MessageBox.Show("Debe seleccionar un cliente para realizar un canje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int productoId = this.indexer[productosCombo.SelectedIndex];

            DAO.connect();

            Catalogo producto = DAO.selectOne<Catalogo>(new[] { "id = " + productoId });

            if (cantidadNumeric.Value > producto.Stock) {
                MessageBox.Show("El stock del producto " +producto.Descripcion + " no es suficiente. Solo se dispone de " + producto.Stock + "unidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DAO.closeConnection();
                return;
            }

            Canje canje = new Canje();
            canje.Catalogo_Id = productoId;
            canje.Cliente_Id = this.cliente_activo.Id;
            canje.Cantidad = cantidadNumeric.Value;
            canje.Fecha = DateTime.Now;

            producto.Stock -= cantidadNumeric.Value;

            DAO.insert<Canje>(canje);
            DAO.update<Catalogo>(producto);

            DAO.closeConnection();

            MessageBox.Show("Canje realizado con exito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void populateCombo(int puntos) {

            DAO.connect();
            List<Catalogo> productos = DAO.selectAll<Catalogo>(new[] { "costo <= " + puntos, "stock > 0" });
            DAO.closeConnection();

            List<String> dataSource = new List<String>();
            this.indexer = new int[dataSource.Count];

            int i = 0;
            foreach (Catalogo p in productos) {
                dataSource.Add(p.Descripcion + " - " + p.Costo + " puntos");
                this.indexer[i] = p.Id;
            }
        
        }

    }
}
