using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Ruta {

        public int Id { get; set; }
        public Decimal Codigo { get; set; }
        public Decimal Precio_Base_Kg { get; set; }
        public Decimal Precio_Base_Pasajes { get; set; }

        public int Ciudad_Origen_Id { get; set; }
        public int Ciudad_Destino_Id { get; set; }
        public Boolean Activo { get; set; }

        private Ciudad _ciudadOrigen = null;
        public Ciudad CiudadOrigen {
            get {
                if (_ciudadOrigen != null) {
                    return _ciudadOrigen;
                }
                else {
                    DAO.connect();
                    Ciudad ciudad_origen = DAO.selectOne<Ciudad>(new[] { "id = " + this.Ciudad_Origen_Id });
                    DAO.closeConnection();
                    return ciudad_origen;
                }
            }
        }

        private Ciudad _ciudadDestino = null;
        public Ciudad CiudadDestino {
            get {
                if (_ciudadDestino != null) {
                    return _ciudadDestino;
                }
                else {
                    DAO.connect();
                    Ciudad ciudad_destino = DAO.selectOne<Ciudad>(new[] { "id = " + this.Ciudad_Destino_Id });
                    DAO.closeConnection();
                    return ciudad_destino;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Ruta";

    }
}
