﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class TipoBaja {

        public int Id { get; set; }
        string Descripcion { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Tipo_Baja";
    }
}
