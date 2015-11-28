using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Config;
using AerolineaFrba.Services;

namespace AerolineaFrba.Models {

    class Aeronave {

        public int Id { get; set; }
        public string Matricula { get; set; }
        public int Modelo_Id { get; set; }
        public decimal Kilogramos_Disponibles { get; set; } 
        public int Fabricante_Id { get; set; }
        public int Tipo_Servicio_Id { get; set; }

        private TipoServicio _tipo = null;
        public TipoServicio Tipo_Servicio {
            get {
                if (_tipo != null) {
                    return _tipo;
                }
                else {
                    DAO.connect();
                    TipoServicio tipo_servicio = DAO.selectOne<TipoServicio>(new[] { "id = " + this.Tipo_Servicio_Id });
                    DAO.closeConnection();
                    return tipo_servicio;
                }
            }
        }

        private Modelo _modelo = null;
        public Modelo Modelo
        {
            get
            {
                if (_modelo != null)
                {
                    return _modelo;
                }
                else
                {
                    DAO.connect();
                    Modelo modelo = DAO.selectOne<Modelo>(new[] { "id = " + this.Modelo_Id });
                    DAO.closeConnection();
                    return modelo;
                }
            }
        }

        private Fabricante _fabricante = null;
        public Fabricante Fabricante
        {
            get
            {
                if (_fabricante != null)
                {
                    return _fabricante;
                }
                else
                {
                    DAO.connect();
                    Fabricante fabricante = DAO.selectOne<Fabricante>(new[] { "id = " + this.Fabricante_Id });
                    DAO.closeConnection();
                    return fabricante;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Aeronave";

    }

}
