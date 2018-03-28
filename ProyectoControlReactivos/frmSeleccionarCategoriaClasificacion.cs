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
    public partial class frmSeleccionarCategoriaClasificacion : Form
    {
        public frmSeleccionarCategoriaClasificacion()
        {
            InitializeComponent();
        }

        private void frmSeleccionarCategoriaClasificacion_Load(object sender, EventArgs e)
        {
            txtBuscarClasificacion.Select();
            txtBuscarClasificacion.Focus();
            Refrescar();
            PropiedadesGrip();
        }
        public void Refrescar() {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoClasificacionReactivo";
            conexion.LlenarGrid(query, dgvSeleccionarCategoriaSeleccion);


        }
        public void PropiedadesGrip()
        {
            this.dgvSeleccionarCategoriaSeleccion.Columns[0].HeaderText = "# Clasificacion";
            this.dgvSeleccionarCategoriaSeleccion.Columns[1].HeaderText = "Clasificacion";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void dgvSeleccionarCategoriaSeleccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSeleccionarCategoriaSeleccion.SelectedRows.Count==1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void txtBuscarClasificacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarCatalogoClasificacionReactivoParametro '%" + txtBuscarClasificacion.Text + "%'";
                conexion.LlenarGrid(query, dgvSeleccionarCategoriaSeleccion);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaClasificacion_Click(object sender, EventArgs e)
        {
            new frmAddCatalogoClasificacionReactivo().ShowDialog();
            Refrescar();

        }

       
    }
}
