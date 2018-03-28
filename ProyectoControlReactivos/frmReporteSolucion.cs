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
    public partial class frmReporteSolucion : Form
    {
        public frmReporteSolucion()
        {
            InitializeComponent();
        }

        private void frmReporteSolucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReactivos.Tabla_Solucion_Reactivo' table. You can move, or remove it, as needed.
            this.Tabla_Solucion_ReactivoTableAdapter.Fill(this.DataSetReactivos.Tabla_Solucion_Reactivo);

            this.reportViewer1.RefreshReport();
        }
    }
}
