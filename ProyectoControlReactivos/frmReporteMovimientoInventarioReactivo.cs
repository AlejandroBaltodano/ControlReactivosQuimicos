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
    public partial class frmReporteMovimientoInventarioReactivo : Form
    {
        public frmReporteMovimientoInventarioReactivo()
        {
            InitializeComponent();
        }

        private void frmReporteMovimientoInventarioReactivo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReactivos.Tabla_Movimiento_Inventario' table. You can move, or remove it, as needed.
            this.Tabla_Movimiento_InventarioTableAdapter.Fill(this.dataSetReactivos.Tabla_Movimiento_Inventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
