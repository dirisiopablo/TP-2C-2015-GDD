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

using AerolineaFrba.Services;
using AerolineaFrba.Models;

namespace AerolineaFrba {
    public partial class MainForm : Form {

        public MainForm() {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            this.showLoginForm();
          
        }

        private void showLoginForm() {

            LoginForm loginForm = new LoginForm();
            var dr = loginForm.ShowDialog();
         
            if (dr == DialogResult.Cancel) { //si cierra la ventana

                loginForm.Close();
                this.Close();

            }

            if (dr == DialogResult.OK) { //si se loguea

                var loginResult = loginForm.lastLoginResult;

                this.onLogin(loginForm.getLoggedUser());

            }

        }

        private void onLogin(User loggedUser){

            //segun rol, ocultar/bloquear botones
            
            if (loggedUser.role == "admin")
                this.adminConfig();

        }

        private void adminConfig(){


        }

        private void ABMRol_Button_Click(object sender, EventArgs e) {

            ABMRol ABMRolForm = ABMRol.getInstance();
            var dr = ABMRolForm.ShowDialog();

        }

        private void generarViaje_Click(object sender, EventArgs e) {



        }





    }
}
