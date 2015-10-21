using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Ruta {

        public int Id { get; set; }
        public decimal Codigo { get; set; }
        public decimal Precio_Base_Kg { get; set; }
        public decimal Precio_Base_Pasajes { get; set; }

        public int Ciudad_Origen_Id { get; set; }
        public Ciudad CiudadOrigen { get; set; }

        public int Ciudad_Destino_Id { get; set; }
        public Ciudad CiudadDestino { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Ruta";

    }
}
