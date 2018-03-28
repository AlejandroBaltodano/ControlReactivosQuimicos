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
    public partial class frmSeleccionarEstadoFisico : Form
    {
        public frmSeleccionarEstadoFisico()
        {
            InitializeComponent();
        }

        private void frmSeleccionarEstadoFisico_Load(object sender, EventArgs e)
        {
            txtBuscarEstadoFisico.Select();
            txtBuscarEstadoFisico.Focus();
            Refrescar();
            PropiedadesGrip();

        }
        public void Refrescar() {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoEstadoFisicoReactivo";
            conexion.LlenarGrid(query, dgvSeleccionarCategoriaEstadoFisico);
        }
        public void PropiedadesGrip()
        {

            this.dgvSeleccionarCategoriaEstadoFisico.Columns[0].HeaderText = "# Estado Fisico";
            this.dgvSeleccionarCategoriaEstadoFisico.Columns[1].HeaderText = "Estado Fisico";
        }

        private void dgvSeleccionarCategoriaEstadoFisico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSeleccionarCategoriaEstadoFisico.SelectedRows.Count==1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnNuevoEstadoFisico_Click(object sender, EventArgs e)
        {
            new frmAddCatalogoEstadoFisico().ShowDialog();
            Refrescar();
        }

        private void txtBuscarEstadoFisico_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarCatalogoEstadoFisicoReactivoParametro '%" + txtBuscarEstadoFisico.Text + "%'";
                conexion.LlenarGrid(query, dgvSeleccionarCategoriaEstadoFisico);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
