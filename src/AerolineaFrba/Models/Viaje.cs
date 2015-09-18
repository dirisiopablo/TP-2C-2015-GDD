using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Viaje {

        public int Id { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaLlegadaEstimada { get; set; }

        public int RutaId { get; set; }
        public Ruta Ruta { get; set; }

        public int AeronaveId { get; set; }
        public Aeronave Aeronave { get; set; }

    }
}
