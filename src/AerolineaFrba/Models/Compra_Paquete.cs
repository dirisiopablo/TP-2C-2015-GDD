using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Compra_Paquete {

        public int Id { get; set; }

        public int Compra_Id { get; set; }
        public int Paquete_Id { get; set; }

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

        private Paquete _paquete = null;
        public Paquete Paquete {
            get {
                if (_paquete != null) {
                    return _paquete;
                }
                else {
                    DAO.connect();
                    Paquete paquete = DAO.selectOne<Paquete>(new[] { "id = " + this.Paquete_Id });
                    DAO.closeConnection();
                    return paquete;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Compra_Paquete";

    }
}
