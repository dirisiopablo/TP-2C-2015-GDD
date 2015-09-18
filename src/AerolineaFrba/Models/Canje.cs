using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Canje {

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int CatalogoId { get; set; }
        public Catalogo Catalogo { get; set; }

    }
}
