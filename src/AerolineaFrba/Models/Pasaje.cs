using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Pasaje {

        public int Id { get; set; }
        public int Codigo { get; set; }
        public float Precio { get; set; }
        public DateTime Fecha_Compra { get; set; }

        public int Butaca_Id { get; set; }
        public Butaca Butaca { get; set; }

        public int Cliente_Id { get; set; }
        public Cliente Cliente { get; set; }

        public int[] CancelacionesIds { get; set; }
        List<Cancelacion> Cancelaciones { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Pasaje";

    }
}
