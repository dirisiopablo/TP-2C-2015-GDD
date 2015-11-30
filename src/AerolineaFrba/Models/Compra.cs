using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Compra {

        public int Id { get; set; }
        public string PNR { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public int Numero_Tarjeta { get; set; }
        public int Codigo_Tarjeta { get; set; }
        public DateTime Vencimiento_Tarjeta { get; set; }
        public int Cant_Cuotas { get; set; }

        public int Cliente_Id { get; set; }
        public int Medio_Pago_Id { get; set; }
        public int Tipo_Tarjeta_Id { get; set; }

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

        private MedioPago _MedioPago = null;
        public MedioPago MedioPago {
            get {
                if (_MedioPago != null) {
                    return _MedioPago;
                }
                else {
                    DAO.connect();
                    MedioPago MedioPago = DAO.selectOne<MedioPago>(new[] { "id = " + this.Medio_Pago_Id });
                    DAO.closeConnection();
                    return MedioPago;
                }
            }
        }

        private TipoTarjeta _TipoTarjeta = null;
        public TipoTarjeta TipoTarjeta {
            get {
                if (_TipoTarjeta != null) {
                    return _TipoTarjeta;
                }
                else {
                    DAO.connect();
                    TipoTarjeta TipoTarjeta = DAO.selectOne<TipoTarjeta>(new[] { "id = " + this.Tipo_Tarjeta_Id });
                    DAO.closeConnection();
                    return TipoTarjeta;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Compra";
    }
}
