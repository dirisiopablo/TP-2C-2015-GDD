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
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.ABM.Abm_Rol;

namespace AerolineaFrba.Abm_Rol{
    

    public sealed partial class ABMRol : Form{

        private static ABMRol _instance = null;

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
            RolDialog rolDialog = new RolDialog();
            var dr = rolDialog.ShowDialog();
        }

        private void Modificar_Click(object sender, EventArgs e){ 
            RolDialog rolDialog = new RolDialog();
            var dr = rolDialog.ShowDialog();
        }

        private void Eliminar_Click(object sender, EventArgs e) {

            foreach (DataGridViewRow item in this.rolDatagrid.SelectedRows){

                int id = (int)item.Cells[0].Value;

                DAO.connect();

                Rol rol = DAO.selectOne<Rol>( new[] {"id = "+id} );
                rol.Activo = false;
                int affected = DAO.update<Rol>(rol);

                DAO.closeConnection();

                rolDatagrid.Update();

            }

        }

        private void ABMRol_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'gD2C2015DataSet11.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.gD2C2015DataSet1.Rol);
            // TODO: This line of code loads data into the 'gD2C2015DataSet1.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.gD2C2015DataSet1.Rol);
            // TODO: This line of code loads data into the 'gD2C2015DataSet1.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.gD2C2015DataSet1.Rol);

        }

        private void rolDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rolBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        //////////////////////////////////////////




          
    }
}
