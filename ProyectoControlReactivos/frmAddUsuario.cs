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
    public partial class frmAddUsuario : Form
    {
        Boolean Editar;
        string CodigoUnico = "";
        ControlReactivos.Model.Usuario usuarioLogin;
        public frmAddUsuario(ControlReactivos.Model.Usuario nombreUsuario)
        {
            usuarioLogin = nombreUsuario;
            InitializeComponent();
        }

        private void frmAddUsuario_Load(object sender, EventArgs e)
        {
            txtNombreUsuarioSql.Select();
            txtNombreUsuarioSql.Focus();
            Editar = false;
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            //string query = "select * from Tabla_Usuario";
            string query = "exec ConsultarTodosLosUsuarios";
                  conexion.LlenarGrid(query,dataGridViewUsuario);
            PropiedadesGrip();

        }
        public void PropiedadesGrip() {
            this.dataGridViewUsuario.Columns[2].Visible = false;
            this.dataGridViewUsuario.Columns[3].Visible = false;
            this.dataGridViewUsuario.Columns[6].Visible = false;
            this.dataGridViewUsuario.Columns[7].Visible = false;
            this.dataGridViewUsuario.Columns[0].HeaderText = "# Usuario";
            this.dataGridViewUsuario.Columns[4].HeaderText = "Nombre";
            this.dataGridViewUsuario.Columns[5].HeaderText = "Primer Apellido";

        }
        public void LimpiarDatos() {

            txtNombreUsuarioSql.Clear();
            txtContraseñaUsuarioSql.Clear();
            txtCedulaUsuario.Clear();
            txtNombreUsuario.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    if (Editar)
                    {
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec ModificarUsuario '" + CodigoUnico + "','" + txtCedulaUsuario.Text + "','" + txtNombreUsuarioSql.Text + "','" + txtContraseñaUsuarioSql.Text + "','" + txtNombreUsuario.Text + "','" + txtApellido1.Text + "','" + txtApellido2.Text + "'";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosUsuarios";
                        conexion.LlenarGrid(query, dataGridViewUsuario);

                        LimpiarDatos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarUsuario '" + txtCedulaUsuario.Text + "','" + txtNombreUsuarioSql.Text + "','" + txtContraseñaUsuarioSql.Text + "','" + txtNombreUsuario.Text + "','" + txtApellido1.Text + "','" + txtApellido2.Text + "'";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosUsuarios";
                        conexion.LlenarGrid(query, dataGridViewUsuario);

                        LimpiarDatos();

                    }
                    MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Problemas al realizar la transaccion, Verifique que los campos no esten vacios", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            Editar = false; 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Editar = true;

                CodigoUnico = this.dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();

                txtCedulaUsuario.Text = this.dataGridViewUsuario.CurrentRow.Cells[1].Value.ToString();
                txtNombreUsuarioSql.Text = this.dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
                txtContraseñaUsuarioSql.Text = this.dataGridViewUsuario.CurrentRow.Cells[3].Value.ToString();
                txtNombreUsuario.Text = this.dataGridViewUsuario.CurrentRow.Cells[4].Value.ToString();
                txtApellido1.Text = this.dataGridViewUsuario.CurrentRow.Cells[5].Value.ToString();
                txtApellido2.Text = this.dataGridViewUsuario.CurrentRow.Cells[6].Value.ToString();
            }
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               int IdUsuario =int.Parse( this.dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString());
                if (usuarioLogin.Id == IdUsuario )
                {
                    MessageBox.Show("No puede Eliminar el usuario con el que esta logueado", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Desea Eliminar el Registro?", "Informacion Requerida",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      == DialogResult.Yes)
                    {
                        try
                        {
                            CodigoUnico = this.dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();

                            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                            string Query = "Exec ModificarEstadoUsuario '" + CodigoUnico + "'";

                            conexion.Update(Query);

                            string query = "exec ConsultarTodosLosUsuarios";
                            conexion.LlenarGrid(query, dataGridViewUsuario);

                            CodigoUnico = "";
                            MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Problemas al realizar Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtNombreUsuarioSql.Text) && !string.IsNullOrEmpty(txtContraseñaUsuarioSql.Text) &&
            !string.IsNullOrEmpty(txtCedulaUsuario.Text) && !string.IsNullOrEmpty(txtNombreUsuario.Text)
            && !string.IsNullOrEmpty(txtApellido1.Text) && !string.IsNullOrEmpty(txtApellido2.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        private void txtCedulaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
