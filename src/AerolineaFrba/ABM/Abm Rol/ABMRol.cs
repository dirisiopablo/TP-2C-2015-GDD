using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Services;

namespace AerolineaFrba.Abm_Rol{

    public sealed partial class ABMRol : Form{

        private static ABMRol _instance = null;
        private string tableName = "test.Rol";

        private ABMRol() {
            this.InitializeComponent();
        }

        public static ABMRol getInstance() {

            if (_instance == null) {
                _instance = new ABMRol();
            }

            return _instance;

        }

        private void Nuevo_Click(object sender, EventArgs e) {
            DAO.connect();
            DAO.select(tableName);
        }

        private void Modificar_Click(object sender, EventArgs e) {

        }

        private void Eliminar_Click(object sender, EventArgs e) {

        }

        //////////////////////////////////////////




          
    }
}
