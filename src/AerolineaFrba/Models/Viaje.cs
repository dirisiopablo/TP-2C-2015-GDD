using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Viaje {

        public int Id { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Llegada { get; set; }
        public DateTime Fecha_Llegada_Estimada { get; set; }

        public int Ruta_Id { get; set; }
        public Ruta Ruta { get; set; }

        public int Aeronave_Id { get; set; }
        public Aeronave Aeronave { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Viaje";
    }
}
