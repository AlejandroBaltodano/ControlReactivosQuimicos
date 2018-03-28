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
    public partial class frmSeleccionarUnidadAlmacenaje : Form
    {
        public frmSeleccionarUnidadAlmacenaje()
        {
            InitializeComponent();
        }

        private void frmSeleccionarUnidadAlmacenaje_Load(object sender, EventArgs e)
        {
            txtBuscarUnidadAlmacenaje.Select();
            txtBuscarUnidadAlmacenaje.Focus();
            Refrescar();
            PropiedadesGrip();
        }

        public void Refrescar() {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoUnidadAlmacenamientoReactivo";
            conexion.LlenarGrid(query, dgvSeleccionarUnidadAlmacenaje);
        }
        public void PropiedadesGrip()
        {

            this.dgvSeleccionarUnidadAlmacenaje.Columns[0].HeaderText = "# Unidad";
            this.dgvSeleccionarUnidadAlmacenaje.Columns[1].HeaderText = "Unidad";
            this.dgvSeleccionarUnidadAlmacenaje.Columns[2].HeaderText = "Simbolo Unidad";
        }

        private void dgvSeleccionarUnidadAlmacenaje_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSeleccionarUnidadAlmacenaje.SelectedRows.Count==1)
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

        private void btnNuevoUnidad_Click(object sender, EventArgs e)
        {
            new frmAddCatalogoUnidadAlmacenamiento().ShowDialog();
            Refrescar();
        }

        private void txtBuscarUnidadAlmacenaje_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarCatalogoUnidadAlmacenamientoReactivoParametro '%" + txtBuscarUnidadAlmacenaje.Text + "%'";
                conexion.LlenarGrid(query, dgvSeleccionarUnidadAlmacenaje);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
