using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class BajaAeronave {

        public int AeronaveId { get; set; }
        public Aeronave Aeronave { get; set; }

        public int TipoBajaId { get; set; }
        public TipoBaja TipoBaja { get; set; }

        public DateTime FechaBaja { get; set; }
        public DateTime FechaReinicio { get; set; }

    }
}
