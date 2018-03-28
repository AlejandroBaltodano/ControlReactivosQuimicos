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
    public partial class frmSeleccionarProfesor : Form
    {
        ControlReactivos.Model.Usuario usuarioLogin;
        public frmSeleccionarProfesor(ControlReactivos.Model.Usuario nombreUsuario)
        {
            usuarioLogin = nombreUsuario;
            InitializeComponent();
        }

        private void frmSeleccionarProfesor_Load(object sender, EventArgs e)
        {
            txtBuscarProfesor.Select();
            txtBuscarProfesor.Focus();
            Refrescar();
            PropiedadesGrip();

        }
        public void Refrescar() {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosProfesores";
            conexion.LlenarGrid(query, dgvSeleccionarProfesor);

        }

        public void PropiedadesGrip()
        {


            this.dgvSeleccionarProfesor.Columns[4].Visible = false;
            this.dgvSeleccionarProfesor.Columns[5].Visible = false;
            this.dgvSeleccionarProfesor.Columns[6].Visible = false;
            this.dgvSeleccionarProfesor.Columns[7].Visible = false;
            this.dgvSeleccionarProfesor.Columns[0].HeaderText = "# Profesor";
            this.dgvSeleccionarProfesor.Columns[2].HeaderText = "Nombre";
            this.dgvSeleccionarProfesor.Columns[3].HeaderText = "Primer Apellido";
            this.dgvSeleccionarProfesor.Columns[8].HeaderText = "Profesión";

        }

        private void dgvSeleccionarProfesor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSeleccionarProfesor.SelectedRows.Count==1)
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

        private void btnNuevoProfesor_Click(object sender, EventArgs e)
        {
            new frmAddProfesor(usuarioLogin).ShowDialog();
            Refrescar();
        }

        private void txtBuscarProfesor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarTodosLosProfesoresPorNombre '%" + txtBuscarProfesor.Text + "%'";
                conexion.LlenarGrid(query, dgvSeleccionarProfesor);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
