using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Config;
using AerolineaFrba.Services;

namespace AerolineaFrba.Models {

    class IntentosLogin {

        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public int Intentos { get; set; }

        private Usuario _usuario = null;
        public Usuario Usuario {
            get {
                if (_usuario != null) {
                    return _usuario;
                }
                else {
                    DAO.connect();
                    Usuario usuario = DAO.selectOne<Usuario>(new[] { "id = " + this.Usuario_Id });
                    DAO.closeConnection();
                    return usuario;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Intentos_Login";

    }

}
