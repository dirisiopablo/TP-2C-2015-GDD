﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    public class Rol {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Rol";
    }
}
