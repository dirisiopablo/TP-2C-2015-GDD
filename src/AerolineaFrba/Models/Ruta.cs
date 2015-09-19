using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Ruta {

        public int Id { get; set; }
        public int Codigo { get; set; }
        public float PrecioBaseKg { get; set; }
        public float PrecioBasePasajes { get; set; }

        public int CiudadOrigenId { get; set; }
        public Ciudad CiudadOrigen { get; set; }

        public int CiudadDestinoId { get; set; }
        public Ciudad CiudadDestino { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Ruta";

    }
}
