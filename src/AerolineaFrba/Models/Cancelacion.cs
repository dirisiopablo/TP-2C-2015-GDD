using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Cancelacion {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroCompra { get; set; }
        public string Motivo { get; set; }

        public int[] PaquetesIds { get; set; }
        List<Paquete> Paquetes { get; set; }

        public int[] PasajesIds { get; set; }
        List<Pasaje> Pasajes { get; set; }

    }
}
