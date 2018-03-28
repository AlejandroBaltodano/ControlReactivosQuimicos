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
    public partial class frmSeleccionarCatalogoProfesion : Form
    {
        public frmSeleccionarCatalogoProfesion()
        {
            InitializeComponent();
        }

        private void frmSeleccionarCatalogoProfesion_Load(object sender, EventArgs e)
        {
            txtBuscarProfesion.Select();
            txtBuscarProfesion.Focus();
            Refrescar();
            PropiedadesGrip();

        }
        public void Refrescar() {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoProfesion";
            conexion.LlenarGrid(query, dgvSeleccionarProfesion);
        }
        public void PropiedadesGrip()
        {

            this.dgvSeleccionarProfesion.Columns[0].HeaderText = "# Profesión";
            this.dgvSeleccionarProfesion.Columns[1].HeaderText = "Profesión";

        }

        private void dgvSeleccionarProfesion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSeleccionarProfesion.SelectedRows.Count==1)
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

        private void btnNuevaProfesion_Click(object sender, EventArgs e)
        {
            new frmAddCatalogoProfesion().ShowDialog();
            Refrescar();
        }

        private void txtBuscarProfesion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarCatalogoProfesionParametro '%" + txtBuscarProfesion.Text + "%'";
                conexion.LlenarGrid(query, dgvSeleccionarProfesion);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
