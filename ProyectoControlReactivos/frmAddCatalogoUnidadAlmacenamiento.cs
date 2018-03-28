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
    public partial class frmAddCatalogoUnidadAlmacenamiento : Form
    {
        Boolean Editar;
        string CodigoUnico = "";
        public frmAddCatalogoUnidadAlmacenamiento()
        {
            InitializeComponent();
        }

        private void frmAddCatalogoUnidadAlmacenamiento_Load(object sender, EventArgs e)
        {
            Editar = false;
            txtNombreUnidad.Select();
            txtNombreUnidad.Focus();
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarCatalogoUnidadAlmacenamientoReactivo";
            conexion.LlenarGrid(query, dataGridViewUnidad);
            PropiedadesGrip();

        }

        public void PropiedadesGrip()
        {

            this.dataGridViewUnidad.Columns[0].HeaderText = "# Unidad";
            this.dataGridViewUnidad.Columns[1].HeaderText = "Unidad";
            this.dataGridViewUnidad.Columns[2].HeaderText = "Simbolo Unidad";
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LimpiarDatos()
        {
            txtNombreUnidad.Clear();
            txtSimbolo.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            Editar = false;
        }

        private void btnGuardarUnidad_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    if (Editar)
                    {
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec ModificarCatalogoUnidadAlmacenamiento '" + CodigoUnico + "','" + txtNombreUnidad.Text + "','" + txtSimbolo.Text + "'";
                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoUnidadAlmacenamientoReactivo";
                        conexion.LlenarGrid(query, dataGridViewUnidad);

                        LimpiarDatos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarCatalogoUnidadAlmacenamiento '" + txtNombreUnidad.Text + "','" + txtSimbolo.Text + "'";

                        conexion.Update(Query);

                        string query = "exec ConsultarCatalogoUnidadAlmacenamientoReactivo";

                        conexion.LlenarGrid(query, dataGridViewUnidad);

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
            if (dataGridViewUnidad.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Editar = true;

                CodigoUnico = this.dataGridViewUnidad.CurrentRow.Cells[0].Value.ToString();
                txtNombreUnidad.Text = this.dataGridViewUnidad.CurrentRow.Cells[1].Value.ToString();
                txtSimbolo.Text = this.dataGridViewUnidad.CurrentRow.Cells[2].Value.ToString();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnidad.Rows.Count == 0)
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
                        CodigoUnico = this.dataGridViewUnidad.CurrentRow.Cells[0].Value.ToString();

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec EliminarCatalogoUnidadAlmacenamiento " + CodigoUnico;

                        conexion.Update(Query);


                        try
                        {
                            string query = "exec ConsultarCatalogoUnidadAlmacenamientoReactivo";
                            conexion.LlenarGrid(query, dataGridViewUnidad);
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

            if (!string.IsNullOrEmpty(txtNombreUnidad.Text) && !string.IsNullOrEmpty(txtSimbolo.Text))
            {
                bandera = true;
            }

            return bandera;

        }
    }
}
