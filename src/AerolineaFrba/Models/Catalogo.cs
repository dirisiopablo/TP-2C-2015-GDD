﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Catalogo {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Costo { get; set; }
        public int Stock { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Catalogo";

    }
}