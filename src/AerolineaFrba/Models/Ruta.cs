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
        public int Tipo_Servicio_Id { get; set; }
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

        private TipoServicio _tipo = null;
        public TipoServicio Tipo_Servicio {
            get {
                if (_tipo != null) {
                    return _tipo;
                }
                else {
                    DAO.connect();
                    TipoServicio tipo_servicio = DAO.selectOne<TipoServicio>(new[] { "id = " + this.Tipo_Servicio_Id });
                    DAO.closeConnection();
                    return tipo_servicio;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Ruta";

    }
}
