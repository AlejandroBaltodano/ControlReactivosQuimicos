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
    public partial class frmAddTelefonoProfesor : Form
    {
        public string IdProfesor;
    
        public frmAddTelefonoProfesor( string IdProfe)
        {
            InitializeComponent();
            IdProfesor = IdProfe;
        }


        private void frmAddTelefonoProfesor_Load(object sender, EventArgs e)
        {
            txtNumeroTelefono.Select();
            txtNumeroTelefono.Focus();
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosTelefonosProfesorPorIdProfesor " + IdProfesor+ "";
            conexion.LlenarGrid(query, dataGridViewTelefonos);
            PropiedadesGrip();
        }


        public void PropiedadesGrip()
        {

            this.dataGridViewTelefonos.Columns[0].HeaderText = "# Consecutivo";
            this.dataGridViewTelefonos.Columns[1].HeaderText = "Nombre Profesor";
            this.dataGridViewTelefonos.Columns[2].HeaderText = "# Teléfono";


        }
        public void LimpiarDatos() {

            txtNumeroTelefono.Text = "";
          

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {

                    ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                    string Query = "Exec InsertarTelefonoProfesor " + IdProfesor + ",'" + txtNumeroTelefono.Text + "'";

                    conexion.Update(Query);

                    string query = "exec  ConsultarTodosTelefonosProfesorPorIdProfesor " + IdProfesor + "";

                    conexion.LlenarGrid(query, dataGridViewTelefonos);

                    LimpiarDatos();


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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTelefonos.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (MessageBox.Show("Desea Eliminar el Registro?", "Informacion Requerida",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      == DialogResult.Yes)
                {
                    try
                    {


                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                        string TelefonoOriginal = this.dataGridViewTelefonos.CurrentRow.Cells[2].Value.ToString();
                        string Query = "Exec EliminarTelefonoProfesor " + IdProfesor + ",'" + TelefonoOriginal + "'";

                        conexion.Update(Query);


                        try
                        {
                            string query = "exec ConsultarTodosTelefonosProfesorPorIdProfesor '" + IdProfesor + "'";
                            conexion.LlenarGrid(query, dataGridViewTelefonos);
                            MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Problemas con la integridad de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Problemas al realizar Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtNumeroTelefono.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
