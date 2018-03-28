using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoControlReactivos
{
    public partial class ReporteReactivos : Form
    {
        public ReporteReactivos()
        {
            InitializeComponent();
        }

        private void ReporteDiario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReactivos.Tabla_Reactivo_Inventario' table. You can move, or remove it, as needed.
            this.Tabla_Reactivo_InventarioTableAdapter.Fill(this.DataSetReactivos.Tabla_Reactivo_Inventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
