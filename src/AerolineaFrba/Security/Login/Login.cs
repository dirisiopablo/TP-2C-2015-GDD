using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Abm_Aeronave;

namespace AerolineaFrba.Login {


    public class User { //TEST

        public User() { }

        public User(String u, String p, String r) {
            this.username = u;
            this.password = p;
            this.role = r;
        }

        public String username { get; set; }
        public String password { get; set; }
        public String role { get; set; }
    }


    public partial class LoginForm : Form {

        public User loggedUser { get; set; }
        public String lastLoginResult { get; set; }

        public LoginForm() {
            InitializeComponent();
        }

        //Functions Section 

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        public User getLoggedUser() {

            return this.loggedUser;

        }

        private void login(String username, String password) {

            if(username == "qq" && password == "qq"){

                this.DialogResult = DialogResult.OK;
                loggedUser = new User(username, password, "admin");

            }else{

                MessageBox.Show("Invalid User or Password", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;

            }

        }


        //Buttons Section

        private void login_btn_Click(object sender, EventArgs e) {

            var username = username_input.Text;
            var password = password_input.Text;

            this.login(username, password);
            
        }

        private void clear_btn_Click(object sender, EventArgs e) {

            username_input.Clear();
            password_input.Clear();

        }

    }
}