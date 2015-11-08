using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Cancelacion_Paquete {

        public int Id { get; set; }

        public int Cancelacion_Id { get; set; }
        public int Paquete_Id { get; set; }

        private Cancelacion _cancelacion = null;
        public Cancelacion Cancelacion {
            get {
                if (_cancelacion != null) {
                    return _cancelacion;
                }
                else {
                    DAO.connect();
                    Cancelacion cancelacion = DAO.selectOne<Cancelacion>(new[] { "id = " + this.Cancelacion_Id });
                    DAO.closeConnection();
                    return cancelacion;
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

        public static string TableName = "BIEN_MIGRADO_RAFA.Cancelacion_Paquete";

    }
}
