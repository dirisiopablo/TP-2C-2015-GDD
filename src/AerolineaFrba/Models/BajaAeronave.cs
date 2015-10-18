using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class BajaAeronave {

        public int Id { get; set; }

        public DateTime Fecha_Baja { get; set; }
        public DateTime Fecha_Reinicio { get; set; }

        public int Aeronave_Id { get; set; }
        public Aeronave Aeronave { get; set; }

        public int Tipo_Baja_Id { get; set; }
        public TipoBaja TipoBaja { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Baja_Aeronave";
    }
}
