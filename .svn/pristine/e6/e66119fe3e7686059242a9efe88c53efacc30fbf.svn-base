using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoControlReactivos
{
    public partial class frmAddCorreoProfesor : Form
    {
        public string IdProfesor;
        public frmAddCorreoProfesor(string IdProfe)
        {
            InitializeComponent();
            IdProfesor = IdProfe;
        }

        private void frmAddCorreoProfesor_Load(object sender, EventArgs e)
        {
            txtCorreoProfesor.Select();
            txtCorreoProfesor.Focus();
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCorreosProfesorPorIdProfesor " + IdProfesor + "";
            conexion.LlenarGrid(query, dataGridViewEmails);
            PropiedadesGrip();
       

        }
        public void PropiedadesGrip()
        {

            this.dataGridViewEmails.Columns[0].HeaderText = "# Consecutivo";
            this.dataGridViewEmails.Columns[1].HeaderText = "Nombre Profesor";
            this.dataGridViewEmails.Columns[2].HeaderText = "Correo Electrónico";


        }
        public void LimpiarDatos()
        {

            txtCorreoProfesor.Text = "";

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
                if (ValidarCorreo())
                {
                try
                {

                    ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                    string Query = "Exec InsertarCorreoProfesor " + IdProfesor + ",'" + txtCorreoProfesor.Text + "'";

                    conexion.Update(Query);

                    string query = "exec  ConsultarCorreosProfesorPorIdProfesor " + IdProfesor + "";

                    conexion.LlenarGrid(query, dataGridViewEmails);

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
                    MessageBox.Show("Ingrese un correo valido", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Problemas al realizar la transaccion, Verifique que los campos no esten vacios", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmails.Rows.Count == 0)
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
                        string CorreoOriginal = this.dataGridViewEmails.CurrentRow.Cells[2].Value.ToString();
                        string Query = "Exec EliminarCorreoProfesor " + IdProfesor + ",'" + CorreoOriginal + "'";

                        conexion.Update(Query);


                        try
                        {
                            string query = "exec ConsultarCorreosProfesorPorIdProfesor " + IdProfesor + "";
                            conexion.LlenarGrid(query, dataGridViewEmails);
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

            if (!string.IsNullOrEmpty(txtCorreoProfesor.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        public bool ValidarCorreo()
        {
            string correo = txtCorreoProfesor.Text;
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
   }
}
