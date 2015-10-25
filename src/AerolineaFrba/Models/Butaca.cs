using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Butaca {

        public int Id { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string Tipo { get; set; }

        public int Aeronave_Id { get; set; }


        private Aeronave _aeronave = null;
        public Aeronave Aeronave {
            get {
                if (_aeronave != null) {
                    return _aeronave;
                }
                else {
                    DAO.connect();
                    Aeronave aeronave = DAO.selectOne<Aeronave>(new[] { "id = " + this.Aeronave_Id });
                    DAO.closeConnection();
                    return aeronave;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Butaca";
    }
}
