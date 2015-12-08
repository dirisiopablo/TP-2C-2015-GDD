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

namespace AerolineaFrba.Login {

    public partial class LoginForm : Form {

        public Usuario loggedUser { get; set; }
        public String lastLoginResult { get; set; }

        public LoginForm() {
            InitializeComponent();
        }

        //Functions Section 
        private void login(String username, String password) {

            String hashedPass = sha256(password);

            DAO.connect();
            Usuario usuario = DAO.selectOne<Usuario>(new[] { "username = '" + username + "'"});
            if (usuario == null) {
                MessageBox.Show("Usuario incorrecto.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }
            IntentosLogin intentos = DAO.selectOne<IntentosLogin>(new[] { "usuario_id = " + usuario.Id });
            DAO.closeConnection();

            if (usuario != null && usuario.Password.Equals(hashedPass) && usuario.Activo) {
                intentos.Intentos = 0;
                DAO.connect();
                DAO.update<IntentosLogin>(intentos);
                DAO.closeConnection();
                this.DialogResult = DialogResult.OK;
                this.loggedUser = usuario;
            }
            else if (!usuario.Activo)
            {
                MessageBox.Show("El usuario se encuentra bloqueado por exceder los intentos de autenticación permitidos.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                intentos.Intentos += 1;
                DAO.connect();
                DAO.update<IntentosLogin>(intentos);
                if (intentos.Intentos == 3)
                {
                    usuario.Activo = false;
                    DAO.update<Usuario>(usuario);
                    MessageBox.Show("El usuario fue bloqueado por exceder los intentos permitidos.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Contraseña invalida. Recuerde que solo puede tener hasta 3 intentos fallidos. Le quedan " + (3 - intentos.Intentos) + " intentos.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DAO.closeConnection();
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

        static string sha256(string password) {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto) {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

    }
}