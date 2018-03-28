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
    public partial class frmReporteDeUnMovimientoReactivo : Form
    {
        public List<ControlReactivos.Model.MovimientoReactivo> Detail = new List<ControlReactivos.Model.MovimientoReactivo>();
        public frmReporteDeUnMovimientoReactivo()
        {
            InitializeComponent();
        }

        private void frmReporteDeUnMovimientoReactivo_Load(object sender, EventArgs e)
        {
      
            reportViewer1.LocalReport.DataSources.Clear();   
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ObjetoMovimientoInventario", Detail));
            this.reportViewer1.RefreshReport();
        }


    }
}
