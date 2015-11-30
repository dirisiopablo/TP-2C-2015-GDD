using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Compra_Pasaje {

        public int Id { get; set; }

        public int Compra_Id { get; set; }
        public int Pasaje_Id { get; set; }

        private Compra _compra = null;
        public Compra Compra {
            get {
                if (_compra != null) {
                    return _compra;
                }
                else {
                    DAO.connect();
                    Compra compra = DAO.selectOne<Compra>(new[] { "id = " + this.Compra_Id });
                    DAO.closeConnection();
                    return compra;
                }
            }
        }

        private Pasaje _pasaje = null;
        public Pasaje Pasaje {
            get {
                if (_pasaje != null) {
                    return _pasaje;
                }
                else {
                    DAO.connect();
                    Pasaje pasaje = DAO.selectOne<Pasaje>(new[] { "id = " + this.Pasaje_Id });
                    DAO.closeConnection();
                    return pasaje;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Compra_Pasaje";

    }
}
