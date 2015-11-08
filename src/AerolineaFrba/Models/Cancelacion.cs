using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Cancelacion {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public int NumeroCompra { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Cancelacion";

    }
}
