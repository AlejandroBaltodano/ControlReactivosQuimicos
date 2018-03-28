﻿using System;
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
    public partial class frmAddInventarioReactivo : Form
    {
        public Boolean Editar;
        public string CodigoUnico = "";
        ControlReactivos.Model.Usuario UsuarioLogin;
        public frmAddInventarioReactivo(ControlReactivos.Model.Usuario usuarioLogin)
        {
            UsuarioLogin = usuarioLogin;
            InitializeComponent();
        }

        private void frmAddInventarioReactivo_Load(object sender, EventArgs e)
        {
            txtCodigoReactivo.Select();
            txtCodigoReactivo.Focus();
            Editar = false;
            LlenarAlInicio();
        }
        public void LlenarAlInicio()
        {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosReactivosInventario";
            conexion.LlenarGrid(query, dataGridViewReactivosRegistrados);
            llenarComboBoxCategoriaClasificacion();
            llenarComboBoxEstadoFisico();
            llenarComboBoxUnidadAlmacenamiento();
            PropiedadesGrip();

        }

        public void PropiedadesGrip()
        {
            this.dataGridViewReactivosRegistrados.Columns[3].Visible = false;
            this.dataGridViewReactivosRegistrados.Columns[4].Visible = false;
            this.dataGridViewReactivosRegistrados.Columns[6].Visible = false;
            this.dataGridViewReactivosRegistrados.Columns[7].Visible = false;
            this.dataGridViewReactivosRegistrados.Columns[8].Visible = false;
            this.dataGridViewReactivosRegistrados.Columns[12].Visible = false;
            this.dataGridViewReactivosRegistrados.Columns[0].HeaderText = "# Reactivo";
            this.dataGridViewReactivosRegistrados.Columns[1].HeaderText = "Cod Reactivo";
            this.dataGridViewReactivosRegistrados.Columns[2].HeaderText = "Reactivo";
            this.dataGridViewReactivosRegistrados.Columns[5].HeaderText = "Existencias";
            this.dataGridViewReactivosRegistrados.Columns[9].HeaderText = "Unidad";
            this.dataGridViewReactivosRegistrados.Columns[10].HeaderText = "Ubicación";
            this.dataGridViewReactivosRegistrados.Columns[11].HeaderText  = "Comentario";

        }

        public void LimpiarDatos()
        {

            txtCodigoReactivo.Clear();
            txtNombreReactivo.Clear();
            txtNombreAlternativo.Clear();
            txtFormulaReactivo.Clear();
            txtCantidadExistencia.Clear();
            txtUbicacionFisica.Clear();
            txtComentario.Clear();
            DesbloquearCampos();
        }
        public void BloquearCampos()
        {

            txtCodigoReactivo.Enabled=false;
            txtNombreReactivo.Enabled=false;
            txtNombreAlternativo.Enabled=false;
            txtFormulaReactivo.Enabled=false;
            txtCantidadExistencia.Enabled=false;
            txtUbicacionFisica.Enabled=false;
            txtComentario.Enabled=false;
            cmbCategoriaClasificacion.Enabled = false;
            cmbEstadoFisico.Enabled = false;
            cmbUnidadAlmacenage.Enabled = false;
            btnGuardar.Enabled = false;
            btnAgregarCategoria.Enabled = false;
            btnAgregarEstadoFisico.Enabled = false;
            btnUnidadAlmacenamiento.Enabled = false;
        }
        public void DesbloquearCampos()
        {

            txtCodigoReactivo.Enabled = true;
            txtNombreReactivo.Enabled = true;
            txtNombreAlternativo.Enabled = true;
            txtFormulaReactivo.Enabled = true;
            txtCantidadExistencia.Enabled = true;
            txtUbicacionFisica.Enabled = true;
            txtComentario.Enabled = true;
            cmbCategoriaClasificacion.Enabled = true;
            cmbEstadoFisico.Enabled = true;
            cmbUnidadAlmacenage.Enabled = true;
            btnGuardar.Enabled = true;
            btnAgregarCategoria.Enabled = true;
            btnAgregarEstadoFisico.Enabled = true;
            btnUnidadAlmacenamiento.Enabled = true;
        }



        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtCodigoReactivo.Text) && !string.IsNullOrEmpty(txtNombreReactivo.Text) &&
            !string.IsNullOrEmpty(txtFormulaReactivo.Text) && !string.IsNullOrEmpty(txtCantidadExistencia.Text) && 
            !string.IsNullOrEmpty(txtUbicacionFisica.Text) && !string.IsNullOrEmpty(txtComentario.Text))
            {
                bandera = true;
            }

            return bandera;
        }

        private void txtCodigoReactivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBuscarSolucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void llenarComboBoxCategoriaClasificacion()
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string Query = "exec ConsultarCatalogoClasificacionReactivo";
            string id = "IdCatalogoClasificacionReactivos";
            string descripcion = "NombreClasificacion";
            string nombreTabla = "Tabla_Catalogo_Clasificacion_Reactivo";
            conexion.LlenarCombo(Query, cmbCategoriaClasificacion, id, descripcion, nombreTabla);
        }

        public void llenarComboBoxEstadoFisico()
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string Query = "exec ConsultarCatalogoEstadoFisicoReactivo";
            string id = "IdCatalogoEstadoFisicoReactivo";
            string descripcion = "NombreEstadoFisico";
            string nombreTabla = "Tabla_Catalogo_Estado_Fisico_Reactivo";
            conexion.LlenarCombo(Query, cmbEstadoFisico, id, descripcion, nombreTabla);
        }

        public void llenarComboBoxUnidadAlmacenamiento()
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string Query = "exec ConsultarCatalogoUnidadAlmacenamientoReactivo";
            string id = "IdCatalogoUnidadAlmacenamientoReactivo";
            string descripcion = "NombreUnidadAlmacenamiento";
            string nombreTabla = "Tabla_Catalogo_Unidad_Almacenamiento_Reactivo";
            conexion.LlenarCombo(Query, cmbUnidadAlmacenage, id, descripcion, nombreTabla);
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            Editar = false;
        }

        private void btnAgregarEstadoFisico_Click(object sender, EventArgs e)
        {
            frmSeleccionarEstadoFisico agregarEstadoFisico = new frmSeleccionarEstadoFisico();
            string nombreEstadofisico = "";
            string idEstadoFisico = "";

            if (agregarEstadoFisico.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataGridViewRow item in agregarEstadoFisico.dgvSeleccionarCategoriaEstadoFisico.SelectedRows)
                {
                    idEstadoFisico = item.Cells[0].Value.ToString();
                    nombreEstadofisico = item.Cells[1].Value.ToString();
                    llenarComboBoxEstadoFisico();

                }
                cmbEstadoFisico.Text = nombreEstadofisico;


            }
        }

        private void btnUnidadAlmacenamiento_Click(object sender, EventArgs e)
        {
            frmSeleccionarUnidadAlmacenaje agregarUnidad = new frmSeleccionarUnidadAlmacenaje();
            string nombreUnidad = "";
            string idUnidad = "";

            if (agregarUnidad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataGridViewRow item in agregarUnidad.dgvSeleccionarUnidadAlmacenaje.SelectedRows)
                {
                    idUnidad = item.Cells[0].Value.ToString();
                    nombreUnidad = item.Cells[1].Value.ToString();
                    llenarComboBoxUnidadAlmacenamiento();

                }
                cmbUnidadAlmacenage.Text = nombreUnidad;


            }
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

                        string Query = "Exec ModificarReactivoInventario " + CodigoUnico + ",'" + txtCodigoReactivo.Text + "','" + txtNombreReactivo.Text + "','" + txtNombreAlternativo.Text + "','" + txtFormulaReactivo.Text + "'," + txtCantidadExistencia.Text + "," + cmbCategoriaClasificacion.SelectedValue + ""
                            + "," + cmbEstadoFisico.SelectedValue + "" + "," + cmbUnidadAlmacenage.SelectedValue + "" + ",'" + txtUbicacionFisica.Text + "','" + txtComentario.Text + "'," + UsuarioLogin.Id + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosReactivosInventario";
                        conexion.LlenarGrid(query, dataGridViewReactivosRegistrados);

                        LimpiarDatos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {
                       
                        string Compara = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[0].Value.ToString();
                        if (Compara.Equals(txtCodigoReactivo.Text))
                        {
                            MessageBox.Show("El codigo Reactivo ya existe", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                            string Query = "Exec InsertarReactivoInventario '" + txtCodigoReactivo.Text + "','" + txtNombreReactivo.Text + "','" + txtNombreAlternativo.Text + "','" + txtFormulaReactivo.Text + "'," + txtCantidadExistencia.Text + "," + cmbCategoriaClasificacion.SelectedValue + ""
                                + "," + cmbEstadoFisico.SelectedValue + "" + "," + cmbUnidadAlmacenage.SelectedValue + "" + ",'" + txtUbicacionFisica.Text + "','" + txtComentario.Text + "'," + UsuarioLogin.Id + "";

                            conexion.Update(Query);

                            string query = "exec ConsultarTodosLosReactivosInventario";
                            conexion.LlenarGrid(query, dataGridViewReactivosRegistrados);

                            LimpiarDatos();
                            MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    
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
            if (dataGridViewReactivosRegistrados.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Editar = true;


                CodigoUnico = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[0].Value.ToString();

                txtCodigoReactivo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[1].Value.ToString();
                txtNombreReactivo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[2].Value.ToString();
                txtNombreAlternativo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[3].Value.ToString();
                txtFormulaReactivo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[4].Value.ToString();
                txtCantidadExistencia.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[5].Value.ToString();
                cmbCategoriaClasificacion.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[6].Value.ToString();
                cmbEstadoFisico.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[7].Value.ToString();
                cmbUnidadAlmacenage.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[8].Value.ToString();
                txtUbicacionFisica.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[10].Value.ToString();
                txtComentario.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[11].Value.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Editar = false;
            if (dataGridViewReactivosRegistrados.Rows.Count == 0)
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
                        CodigoUnico = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[0].Value.ToString();

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec ModificarEstadoReactivoInventario " + CodigoUnico + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosReactivosInventario";
                        conexion.LlenarGrid(query, dataGridViewReactivosRegistrados);
                        PropiedadesGrip();

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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarSolucion_KeyUp(object sender, KeyEventArgs e)
        {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

            string query = "ConsultarTodosLosReactivosInventarioPorCodigo '%" + txtBuscarReactivo.Text + "%'";

            conexion.LlenarGrid(query, dataGridViewReactivosRegistrados);
        }

        private void txtBuscarReactivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmSeleccionarCategoriaClasificacion agregarClasificacion = new frmSeleccionarCategoriaClasificacion();
            string nombreClasificacion = "";
            string idClasificacion = "";

            if (agregarClasificacion.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataGridViewRow item in agregarClasificacion.dgvSeleccionarCategoriaSeleccion.SelectedRows)
                {
                    idClasificacion = item.Cells[0].Value.ToString();
                    nombreClasificacion = item.Cells[1].Value.ToString();
                    llenarComboBoxCategoriaClasificacion();

                }
                cmbCategoriaClasificacion.Text = nombreClasificacion;


            }

        }

        private void txtBuscarPorNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarTodosLosReactivosInventarioPorNombre '%" + txtBuscarPorNombre.Text + "%'";
                conexion.LlenarGrid(query, dataGridViewReactivosRegistrados);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerReactivo_Click(object sender, EventArgs e)
        {
            if (dataGridViewReactivosRegistrados.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Editar = false;
                BloquearCampos();


                CodigoUnico = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[0].Value.ToString();

                txtCodigoReactivo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[1].Value.ToString();
                txtNombreReactivo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[2].Value.ToString();
                txtNombreAlternativo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[3].Value.ToString();
                txtFormulaReactivo.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[4].Value.ToString();
                txtCantidadExistencia.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[5].Value.ToString();
                cmbCategoriaClasificacion.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[6].Value.ToString();
                cmbEstadoFisico.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[7].Value.ToString();
                cmbUnidadAlmacenage.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[8].Value.ToString();
                txtUbicacionFisica.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[10].Value.ToString();
                txtComentario.Text = this.dataGridViewReactivosRegistrados.CurrentRow.Cells[11].Value.ToString();
            }
        }
    }
}
