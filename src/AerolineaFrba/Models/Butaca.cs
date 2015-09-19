using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Butaca {

        public int Id { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string Tipo { get; set; }

        public int AeronaveId { get; set; }
        public Aeronave Aeronave { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Butaca";
    }
}
