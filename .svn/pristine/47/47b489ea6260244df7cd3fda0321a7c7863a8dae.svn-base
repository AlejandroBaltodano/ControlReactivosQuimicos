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
    public partial class frmAddCatalogoClasificacionReactivo : Form
    {
        Boolean Editar;
        string CodigoUnico = "";
        public frmAddCatalogoClasificacionReactivo()
        {
            InitializeComponent();
        }

        private void frmAddCatalogoClasificacionReactivo_Load(object sender, EventArgs e)
        {
            txtNombreClasificacion.Select();
            txtNombreClasificacion.Focus();
            Editar = false;
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoClasificacionReactivo";
            conexion.LlenarGrid(query, dataGridViewClasificacion);
            PropiedadesGrip();
        }

        public void PropiedadesGrip()
        {
            this.dataGridViewClasificacion.Columns[0].HeaderText = "# Clasificacion";
            this.dataGridViewClasificacion.Columns[1].HeaderText = "Clasificacion";
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
     
            Close();

        }
        public void LimpiarDatos()
        {
            txtNombreClasificacion.Clear();
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

                        string Query = "Exec ModificarCatalogoClasificacionReactivo '" + CodigoUnico + "','" + txtNombreClasificacion.Text + "'";
                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoClasificacionReactivo";
                        conexion.LlenarGrid(query, dataGridViewClasificacion);

                        LimpiarDatos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarCatalogoClasificacionReactivo '" + txtNombreClasificacion.Text + "'";

                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoClasificacionReactivo";

                        conexion.LlenarGrid(query, dataGridViewClasificacion);

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
            if (dataGridViewClasificacion.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Editar = true;

                CodigoUnico = this.dataGridViewClasificacion.CurrentRow.Cells[0].Value.ToString();
                txtNombreClasificacion.Text = this.dataGridViewClasificacion.CurrentRow.Cells[1].Value.ToString();

            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClasificacion.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                if (MessageBox.Show("Desea Eliminar el Registro?", "Informacion Requerida",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      == DialogResult.Yes)
                {

                    try
                    {
                        CodigoUnico = this.dataGridViewClasificacion.CurrentRow.Cells[0].Value.ToString();

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec EliminarCatalogoClasificacionReactivo " + CodigoUnico;

                        conexion.Update(Query);


                        try
                        {
                            string query = "exec ConsultarCatalogoClasificacionReactivo";
                            conexion.LlenarGrid(query, dataGridViewClasificacion);
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

            if (!string.IsNullOrEmpty(txtNombreClasificacion.Text))
            {
                bandera = true;
            }

            return bandera;

        }

    }
}
