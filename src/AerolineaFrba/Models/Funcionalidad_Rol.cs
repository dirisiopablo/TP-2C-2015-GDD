using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    public class Funcionalidad_Rol {

        public int Id { get; set; }

        public int Funcionalidad_Id { get; set; }
        public int Rol_Id { get; set; }

        private Funcionalidad _funcionalidad = null;
        public Funcionalidad Funcionalidad {
            get {
                if (_funcionalidad != null) {
                    return _funcionalidad;
                }
                else {
                    DAO.connect();
                    Funcionalidad funcionalidad = DAO.selectOne<Funcionalidad>(new[] { "id = " + this.Funcionalidad_Id });
                    DAO.closeConnection();
                    return funcionalidad;
                }
            }
        }

        private Rol _rol = null;
        public Rol Rol {
            get {
                if (_rol != null) {
                    return _rol;
                }
                else {
                    DAO.connect();
                    Rol rol = DAO.selectOne<Rol>(new[] { "id = " + this.Rol_Id });
                    DAO.closeConnection();
                    return rol;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Funcionalidad_Rol";

    }
}
