using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Cliente {

        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal DNI { get; set; }
        public string Direccion { get; set; }
        public decimal Telefono { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        public int Puntos { //extra, sin columna en db
            get {
                DAO.connect();

                String condicionFecha = "BETWEEN DATEADD(year, -1, GETDATE()) AND GETDATE() ";

                List<Pasaje> pasajes = DAO.selectAll<Pasaje>(new[] { "cliente_id = " + this.Id, "( fecha_compra " + condicionFecha + ")" });
                List<Paquete> paquetes = DAO.selectAll<Paquete>(new[] { "cliente_id = " + this.Id, "( fecha_compra " + condicionFecha + ")" });
                List<Canje> canjes = DAO.selectAll<Canje>(new[] { "cliente_id = " + this.Id, "( fecha " + condicionFecha + ")" });

                DAO.closeConnection();

                decimal puntos = 0;

                foreach (Pasaje p in pasajes)
                    puntos += p.Precio / 10;

                foreach (Paquete p in paquetes)
                    puntos += p.Precio / 10;

                foreach (Canje c in canjes)
                    puntos -= c.Cantidad * c.Catalogo.Costo;

                return (int)puntos;
            }
        } 

        public static string TableName = "BIEN_MIGRADO_RAFA.Cliente";

    }
}
