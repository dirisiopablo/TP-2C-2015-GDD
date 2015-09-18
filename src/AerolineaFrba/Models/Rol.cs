using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Rol {

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public int[] FuncionalidadesIds { get; set; }
        public List<Funcionalidad> Funcionalidades { get; set; }

    }
}
