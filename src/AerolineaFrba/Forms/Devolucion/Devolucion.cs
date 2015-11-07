using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Models;
using AerolineaFrba.Services;

namespace AerolineaFrba.Forms.Devolucion {

    public sealed partial class Devolucion : Form {

        private static Devolucion _instance = null;

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

            List<Pasaje> pasajes = DAO.selectAll<Pasaje>(new[] { "cliente_id = " + cliente.Id });


            DAO.closeConnection();


            

        }

        private void devolucionPasajeButton_Click(object sender, EventArgs e) {

        }

        private void devolucionEncomiendaButton_Click(object sender, EventArgs e) {

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


    }

}
