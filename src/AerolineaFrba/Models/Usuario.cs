using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Usuario {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int Rol_Id { get; set; }

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

        public static string TableName = "BIEN_MIGRADO_RAFA.Usuario";
    }
}
