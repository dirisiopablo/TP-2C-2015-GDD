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

    public partial class TableDialog : Form {

        public TableDialog(DataTable table, String title) {

            InitializeComponent();

            this.titleLabel.Text = title;
            this.datagrid.DataSource = table;

        }

    }

}
