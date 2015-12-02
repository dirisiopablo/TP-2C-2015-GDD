using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Pasaje {

        public int Id { get; set; }
        public Decimal Codigo { get; set; }
        public Decimal Precio { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public bool Activo { get; set; }

        public int Butaca_Id { get; set; }
        public int Cliente_Id { get; set; }
        public int Viaje_id { get; set; }

        private Butaca _butaca = null;
        public Butaca Butaca {
            get {
                if (_butaca != null) {
                    return _butaca;
                }
                else {
                    DAO.connect();
                    Butaca butaca = DAO.selectOne<Butaca>(new[] { "id = " + this.Butaca_Id });
                    DAO.closeConnection();
                    return butaca;
                }
            }
        }

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
                    Viaje viaje = DAO.selectOne<Viaje>(new[] { "id = " + this.Viaje_id });
                    DAO.closeConnection();
                    return viaje;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Pasaje";

    }
}
