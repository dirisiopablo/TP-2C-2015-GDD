using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Enums;
using AerolineaFrba.Models;
using AerolineaFrba.Services;

namespace AerolineaFrba.ABM.Abm_Rol
{
    public partial class AsignarFuncionalidades : Form
    {
        public Rol rol { get; set; }
        public DialogResult dr { get; set; }

        public AsignarFuncionalidades(Rol rol, List<Funcionalidad_Rol> funcionalidadesRol)
        {
            InitializeComponent();
            this.rolTexto.Text = rol.Descripcion;
            this.rol = rol;

            foreach (var funcionalidadRol in funcionalidadesRol){
                switch (funcionalidadRol.Funcionalidad.Descripcion){
                    case "ABM_Rol":
                        this.abmRolCheck.Checked = true;
                        break;
                    case "ABM_Aeronave":
                        this.abmAeronaveCheck.Checked = true;
                        break;
                    case "ABM_Ruta":
                        this.abmRutaCheck.Checked = true;
                        break;
                    case "Generar_Viaje":
                        this.generarViajeCheck.Checked = true;
                        break;
                    case "Devolucion":
                        this.devolucionCheck.Checked = true;
                        break;
                }
                    
            }

        }

        private void Guardar_Click(object sender, EventArgs e) {
        }

        private void Cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void confirmarFuncionalidades_Click(object sender, EventArgs e)
        {
            DAO.connect();
            List<Funcionalidad_Rol> funcionalidadesRol = DAO.selectAll<Funcionalidad_Rol>(new[] { "rol_id = " + this.rol.Id });

            foreach (var funcionalidadRol in funcionalidadesRol)
            {
                DAO.delete<Funcionalidad_Rol>(funcionalidadRol);
            }

            Funcionalidad_Rol fRol = new Funcionalidad_Rol();
            fRol.Rol_Id = this.rol.Id;

            if (this.abmRolCheck.Checked)
            {
                fRol.Funcionalidad_Id = 1; //TODO: MAKE ME A CONSTANT DOOD - NEIN
                DAO.insert<Funcionalidad_Rol>(fRol);
            }

            if (this.abmAeronaveCheck.Checked)
            {
                fRol.Funcionalidad_Id = 2; //TODO: MAKE ME A CONSTANT DOOD - NO
                DAO.insert<Funcionalidad_Rol>(fRol);
            }

            if (this.abmRutaCheck.Checked)
            {
                fRol.Funcionalidad_Id = 3; //TODO: MAKE ME A CONSTANT DOOD - NO I WONT
                DAO.insert<Funcionalidad_Rol>(fRol);
            }

            if (this.generarViajeCheck.Checked)
            {
                fRol.Funcionalidad_Id = 4; //TODO: MAKE ME A CONSTANT DOOD - NOPE
                DAO.insert<Funcionalidad_Rol>(fRol);
            }

            if (this.devolucionCheck.Checked)
            {
                fRol.Funcionalidad_Id = 5; //TODO: MAKE ME A CONSTANT DOOD - NOES
                DAO.insert<Funcionalidad_Rol>(fRol);
            }

            DAO.closeConnection();
            this.dr = DialogResult.OK;
            this.Close();

        }

        private void cancelarFuncionalidades_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
