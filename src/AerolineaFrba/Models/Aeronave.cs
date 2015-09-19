using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Interfaces;
using AerolineaFrba.Config;

namespace AerolineaFrba.Models {

    class Aeronave : IMappedModel {

        public int Id { get; set; }
        public int Numero { get; set; }
        public int KilogramosDisponibles { get; set; }
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Aeronave";

    }

}
