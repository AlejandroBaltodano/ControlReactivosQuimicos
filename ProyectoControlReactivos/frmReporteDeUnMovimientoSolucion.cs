using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteDeUnMovimientoSolucion : Form
    {
        public List<ControlReactivos.Model.MovimientoSolucion> Detail = new List<ControlReactivos.Model.MovimientoSolucion>();
        public frmReporteDeUnMovimientoSolucion()
        {
            InitializeComponent();
        }

        private void frmReporteDeUnMovimientoSolucion_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ControlMovimientoSolucion", Detail));
            this.reportViewer1.RefreshReport();
        }
    }
}
