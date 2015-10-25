using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;


namespace AerolineaFrba.Models {
    class Canje {

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public int Cliente_Id { get; set; }
        public int Catalogo_Id { get; set; }

        private Cliente _cliente = null;
        public Cliente Cliente {
            get {
                if (_cliente != null) {
                    return _cliente;
                }
                else {
                    DAO.connect();
                    Cliente cliente = DAO.selectOne<Cliente>(new[] { "id = " + this.Cliente_Id });
                    DAO.closeConnection();
                    return cliente;
                }
            }
        }

        private Catalogo _catalogo = null;
        public Catalogo Catalogo {
            get {
                if (_catalogo != null) {
                    return _catalogo;
                }
                else {
                    DAO.connect();
                    Catalogo catalogo = DAO.selectOne<Catalogo>(new[] { "id = " + this.Catalogo_Id });
                    DAO.closeConnection();
                    return catalogo;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Canje";

    }
}
