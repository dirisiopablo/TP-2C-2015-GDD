using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class BajaAeronave {

        public int Id { get; set; }

        public DateTime Fecha_Baja { get; set; }
        public DateTime Fecha_Reinicio { get; set; }

        public int Aeronave_Id { get; set; }
        public int Tipo_Baja_Id { get; set; }

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

        private TipoBaja _tipoBaja = null;
        public TipoBaja TipoBaja {
            get {
                if (_tipoBaja != null) {
                    return _tipoBaja;
                }
                else {
                    DAO.connect();
                    TipoBaja tipoBaja = DAO.selectOne<TipoBaja>(new[] { "id = " + this.Tipo_Baja_Id });
                    DAO.closeConnection();
                    return tipoBaja;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Baja_Aeronave";
    }
}
