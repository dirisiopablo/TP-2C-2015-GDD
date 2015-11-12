using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Config;
using AerolineaFrba.Services;

namespace AerolineaFrba.Models {

    class Aeronave {

        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public decimal Kilogramos_Disponibles { get; set; } 
        public string Fabricante { get; set; }
        public int Tipo_Servicio_Id { get; set; }

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

        public static string TableName = "BIEN_MIGRADO_RAFA.Aeronave";

    }

}
