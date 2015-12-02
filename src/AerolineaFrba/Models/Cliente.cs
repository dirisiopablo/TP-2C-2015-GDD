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

                String condicionFecha = "BETWEEN DATEADD(year, -1, " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + ") AND " + "'" + Config.SystemConfig.systemDate.ToString("yyyyMMdd HH:mm:ss") + "'" + " ";

                List<Compra> compras = DAO.selectAll<Compra>(new[] { "cliente_id = " + this.Id, "( fecha_compra " + condicionFecha + ")" });

                List<Pasaje> pasajes = new List<Pasaje>();
                List<Paquete> paquetes = new List<Paquete>();
                List<Canje> canjes = DAO.selectAll<Canje>(new[] { "cliente_id = " + this.Id, "( fecha " + condicionFecha + ")" });

                foreach (Compra c in compras) {
                    List<Compra_Pasaje> cp = DAO.selectAll<Compra_Pasaje>(new[] { "compra_id = " + c.Id});
                    List<Compra_Paquete> cpq = DAO.selectAll<Compra_Paquete>(new[] { "compra_id = " + c.Id });

                    foreach (Compra_Pasaje comp in cp) {
                        Pasaje p = DAO.selectOne<Pasaje>(new[] { "id = " + comp.Pasaje_Id });
                        if (p.Activo) pasajes.Add(p);
                    }
                    foreach (Compra_Paquete comp in cpq) {
                        Paquete p = DAO.selectOne<Paquete>(new[] { "id = " + comp.Paquete_Id });
                        if (p.Activo) paquetes.Add(p);
                    }
                }

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
