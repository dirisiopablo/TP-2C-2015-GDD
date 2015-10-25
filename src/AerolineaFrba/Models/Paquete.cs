using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Paquete {

        public int Id { get; set; }
        public int Codigo { get; set; }
        public float Precio { get; set; }
        public int Kg { get; set; }
        public DateTime Fecha_Compra { get; set; }

        public int Viaje_Id { get; set; }
        public int Cliente_Id { get; set; }

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

        private Viaje _viaje = null;
        public Viaje Viaje {
            get {
                if (_viaje != null) {
                    return _viaje;
                }
                else {
                    DAO.connect();
                    Viaje viaje = DAO.selectOne<Viaje>(new[] { "id = " + this.Viaje_Id });
                    DAO.closeConnection();
                    return viaje;
                }
            }
        }

        public int[] CancelacionesIds { get; set; }
        public List<Cancelacion> Cancelaciones { get; set; }

        public static string TableName = "BIEN_MIGRADO_RAFA.Paquete";

    }
}
