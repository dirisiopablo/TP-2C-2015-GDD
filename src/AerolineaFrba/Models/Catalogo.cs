using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Catalogo {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Decimal Costo { get; set; }
        public Decimal Stock { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Catalogo";

    }
}
