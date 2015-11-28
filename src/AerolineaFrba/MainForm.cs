using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Login;
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.ABM.Abm_Ciudad;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.ABM.Abm_Ruta;
using AerolineaFrba.Forms.Generacion_Viaje;
using AerolineaFrba.Forms.Compra;
using AerolineaFrba.Forms.Listado_Estadistico;
using AerolineaFrba.Forms.Devolucion;
using AerolineaFrba.Forms.Consulta_Millas;
using AerolineaFrba.Forms.Canje_Millas;

using AerolineaFrba.Services;
using AerolineaFrba.Models;

namespace AerolineaFrba {
    public partial class MainForm : Form {

        public MainForm() {

            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e) {

            LoginForm loginForm = new LoginForm();
            var dr = loginForm.ShowDialog();

            if (dr == DialogResult.Cancel) { //si cierra la ventana
                loginForm.Close();
            }

            if (dr == DialogResult.OK) { //si se loguea
                var loginResult = loginForm.lastLoginResult;
                this.onLogin(loginForm.loggedUser);
            }

        }

        private void onLogin(Usuario loggedUser){

            DAO.connect();
            List<Funcionalidad_Rol> funcionalidadesRol = DAO.selectAll<Funcionalidad_Rol>(new[] { "rol_id = " + loggedUser.Rol.Id });

            foreach (var funcionalidadRol in funcionalidadesRol)
            {
                switch (funcionalidadRol.Funcionalidad.Descripcion)
                {
                    case "ABM_Rol":
                        this.ABMRol_Button.Visible = true;
                        break;
                    case "ABM_Aeronave":
                        this.ABMAeronave_Button.Visible = true;
                        break;
                    case "ABM_Ruta":
                        this.ABMRuta_Button.Visible = true;
                        break;
                    case "Generar_Viaje":
                        this.generarViajeButton.Visible = true;
                        break;
                    case "Devolucion":
                        this.devolucionButton.Visible = true;
                        break;
                }               
            }

            DAO.closeConnection();

            

            this.loginButton.Visible = false;

            this.loggedAs.Text = "Logueado como " + loggedUser.Rol.Descripcion + " " + loggedUser.Username;

        }


        private void ABMRol_Button_Click(object sender, EventArgs e) {
            ABMRol ABMRolForm = ABMRol.getInstance();
            var dr = ABMRolForm.ShowDialog();
        }

        private void ABMCiudad_Button_Click(object sender, EventArgs e) {
            ABMCiudad ABMCiudadForm = ABMCiudad.getInstance();
            var dr = ABMCiudadForm.ShowDialog();
        }

        private void ABMAeronave_Button_Click(object sender, EventArgs e) {
            ABMAeronave ABMAeronaveForm = ABMAeronave.getInstance();
            var dr = ABMAeronaveForm.ShowDialog();
        }

        private void ABMRuta_Button_Click(object sender, EventArgs e) {
            ABMRuta ABMRutaForm = ABMRuta.getInstance();
            var dr = ABMRutaForm.ShowDialog();
        }

        private void generarViajeButton_Click(object sender, EventArgs e) {
            GenerarViaje GenerarViajeForm = GenerarViaje.getInstance();
            var dr = GenerarViajeForm.ShowDialog();
        }

        private void compraButton_Click(object sender, EventArgs e) {
            Compra CompraForm = Compra.getInstance();
            var dr = CompraForm.ShowDialog();
        }

        private void estadisticasButton_Click(object sender, EventArgs e) {
            ListadoEstadistico ListadoEstadisticoForm = ListadoEstadistico.getInstance();
            var dr = ListadoEstadisticoForm.ShowDialog();
        }

        private void devolucionButton_Click(object sender, EventArgs e) {
            Devolucion DevolucionForm = Devolucion.getInstance();
            var dr = DevolucionForm.ShowDialog();
        }

        private void consultarMillasButton_Click(object sender, EventArgs e) {
            ConsultaMillas ConsultaMillasForm = ConsultaMillas.getInstance();
            var dr = ConsultaMillasForm.ShowDialog();
        }

        private void canjearMillasButton_Click(object sender, EventArgs e) {
            CanjeMillas CanjeMillasForm = CanjeMillas.getInstance();
            var dr = CanjeMillasForm.ShowDialog();
        }

    }
}
