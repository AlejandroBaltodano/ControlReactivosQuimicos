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
    public partial class frmAddCatalogoEstadoFisico : Form
    {
        Boolean Editar;
        string CodigoUnico = "";
        public frmAddCatalogoEstadoFisico()
        {
            InitializeComponent();
        }

        private void frmAddCatalogoEstadoFisico_Load(object sender, EventArgs e)
        {
            Editar = false;
            txtEstadoFisico.Select();
            txtEstadoFisico.Focus();
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoEstadoFisicoReactivo";
            conexion.LlenarGrid(query, dataGridViewEstadoFisico);
            PropiedadesGrip();
        }
        public void PropiedadesGrip()
        {

            this.dataGridViewEstadoFisico.Columns[0].HeaderText = "# Estado Fisico";
            this.dataGridViewEstadoFisico.Columns[1].HeaderText = "Estado Fisico";
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
         
            Close();
        }
        public void LimpiarDatos()
        {
            txtEstadoFisico.Clear();
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

                        string Query = "Exec ModificarCatalogoEstadoFisicoReactivo '" + CodigoUnico + "','" + txtEstadoFisico.Text + "'";
                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoEstadoFisicoReactivo";
                        conexion.LlenarGrid(query, dataGridViewEstadoFisico);

                        LimpiarDatos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarCatalogoEstadoFisicoReactivo '" + txtEstadoFisico.Text + "'";

                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoEstadoFisicoReactivo";

                        conexion.LlenarGrid(query, dataGridViewEstadoFisico);

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
            if (dataGridViewEstadoFisico.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Editar = true;

                CodigoUnico = this.dataGridViewEstadoFisico.CurrentRow.Cells[0].Value.ToString();
                txtEstadoFisico.Text = this.dataGridViewEstadoFisico.CurrentRow.Cells[1].Value.ToString();

            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstadoFisico.Rows.Count == 0)
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
                        CodigoUnico = this.dataGridViewEstadoFisico.CurrentRow.Cells[0].Value.ToString();

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec EliminarCatalogoEstadoFisicoReactivo " + CodigoUnico;

                        conexion.Update(Query);


                        try
                        {
                            string query = "exec ConsultarCatalogoEstadoFisicoReactivo";
                            conexion.LlenarGrid(query, dataGridViewEstadoFisico);
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

            if (!string.IsNullOrEmpty(txtEstadoFisico.Text))
            {
                bandera = true;
            }

            return bandera;

        }

       
    }
}
