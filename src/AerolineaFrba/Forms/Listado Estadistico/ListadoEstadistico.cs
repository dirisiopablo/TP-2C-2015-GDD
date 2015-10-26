using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Forms.Listado_Estadistico {

    public partial class ListadoEstadistico : Form {

        private static ListadoEstadistico _instance = null;

        private ListadoEstadistico() {
            this.InitializeComponent();
        }

        public static ListadoEstadistico getInstance() {

            if (_instance == null) {
                _instance = new ListadoEstadistico();
            }

            return _instance;
        }

    }

}
