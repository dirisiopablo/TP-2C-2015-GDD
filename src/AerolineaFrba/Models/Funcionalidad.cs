using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Funcionalidad {

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public int[] RolesIds { get; set; }
        public List<Rol> Roles { get; set; }

    }
}
