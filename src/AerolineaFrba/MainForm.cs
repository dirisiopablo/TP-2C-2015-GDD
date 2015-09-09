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

namespace AerolineaFrba {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            this.showLoginForm();
          
        }

        private void showLoginForm() {

            LoginForm loginForm = LoginForm.getLoginFormInstance();
            var dr = loginForm.ShowDialog();

            if (dr == DialogResult.Cancel) { //si cierra la ventana

                loginForm.Close();
                this.Close();

            }

            if (dr == DialogResult.OK) { //si se loguea

                var loginResult = loginForm.lastLoginResult;

                if (loginResult == "SUCCESS")
                    this.onLogin(loginForm.getLoggedUser());
                else if (loginResult == "FAILURE") {
                    this.showLoginForm();
                }

            }

        }

        private void onLogin(User loggedUser){

            //segun rol, ocultar/bloquear botones
            MessageBox.Show("Welcome to qqnessland " + loggedUser.role +" "+ loggedUser.username, "Hi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (loggedUser.role == "admin")
                this.adminConfig();

        }

        private void adminConfig(){


        }


    }
}
