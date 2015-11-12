using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class TipoServicio {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Decimal Porcentaje { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Tipo_Servicio";
    }
}
