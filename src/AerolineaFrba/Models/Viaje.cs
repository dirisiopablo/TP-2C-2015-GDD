using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
   
    public class Viaje {

        public int Id { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Llegada { get; set; }
        public DateTime Fecha_Llegada_Estimada { get; set; }

        public int Ruta_Id { get; set; }
        public int Aeronave_Id { get; set; }

        private Ruta _ruta = null;
        public Ruta Ruta {
            get {
                if (_ruta != null) {
                    return _ruta;
                }
                else {
                    DAO.connect();
                    Ruta ruta = DAO.selectOne<Ruta>(new[] { "id = " + this.Ruta_Id });
                    DAO.closeConnection();
                    return ruta;
                }
            }
        }

        private Aeronave _aeronave = null;
        public Aeronave Aeronave {
            get {
                if (_aeronave != null) {
                    return _aeronave;
                }
                else {
                    DAO.connect();
                    Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "id = " + this.Aeronave_Id });
                    DAO.closeConnection();
                    return aeronave;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Viaje";
    }
}
