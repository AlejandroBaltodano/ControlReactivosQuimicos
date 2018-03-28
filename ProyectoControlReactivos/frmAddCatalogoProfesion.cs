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
    public partial class frmAddCatalogoProfesion : Form
    {
        Boolean Editar;
        string CodigoUnico = "";
   
        public frmAddCatalogoProfesion()
        {
            InitializeComponent();
        }

        private void frmAddCatalogoProfesion_Load(object sender, EventArgs e)
        {
            txtNombreProfesor.Select();
            txtNombreProfesor.Focus();
            Editar = false;
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoProfesion";
            conexion.LlenarGrid(query, dataGridViewProfeciones);
            PropiedadesGrip();
        }

        public void PropiedadesGrip() {

            this.dataGridViewProfeciones.Columns[0].HeaderText = "# Profesión";
            this.dataGridViewProfeciones.Columns[1].HeaderText = "Profesión";

        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LimpiarDatos()
        {
            txtNombreProfesor.Clear(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            Editar = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    if (Editar)
                    {
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec ModificarCatalogoProfesion '" + CodigoUnico + "','" + txtNombreProfesor.Text + "'";
                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoProfesion";
                        conexion.LlenarGrid(query, dataGridViewProfeciones);

                        LimpiarDatos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarCatalogoProfesion '" + txtNombreProfesor.Text + "'";

                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoProfesion";

                        conexion.LlenarGrid(query, dataGridViewProfeciones);

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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfeciones.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Editar = true;

                CodigoUnico = this.dataGridViewProfeciones.CurrentRow.Cells[0].Value.ToString();
                txtNombreProfesor.Text = this.dataGridViewProfeciones.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfeciones.Rows.Count == 0)
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
                        CodigoUnico = this.dataGridViewProfeciones.CurrentRow.Cells[0].Value.ToString();

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec EliminarCatalogoProfesion " + CodigoUnico;

                        conexion.Update(Query);


                        try
                        {
                            string query = "exec ConsultarCatalogoProfesion";
                            conexion.LlenarGrid(query, dataGridViewProfeciones);
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

            if (!string.IsNullOrEmpty(txtNombreProfesor.Text))
            {
                bandera = true;
            }

            return bandera;

        }
    }
}
