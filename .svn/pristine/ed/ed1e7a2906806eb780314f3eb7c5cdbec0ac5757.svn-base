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
    public partial class frmAddSolucionReactivo : Form
    {
        public Boolean Editar;
        public string CodigoUnico = "";


        ControlReactivos.Model.Usuario usuarioLogin;
        public frmAddSolucionReactivo(ControlReactivos.Model.Usuario nombreUsuario)
        {
            InitializeComponent();
            usuarioLogin = nombreUsuario;
        }

        private void frmAddSolucionReactivo_Load(object sender, EventArgs e)
        {
            Editar = false;
            LlenarAlInicio();
            
        }

        public void LlenarAlInicio() {
            txtNombreSolucion.Select();
            txtNombreSolucion.Focus();
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosSolucionesReactivosInventario";
            conexion.LlenarGrid(query, dataGridViewSolucion);
            llenarComboBoxCategoriaClasificacion();
            llenarComboBoxEstadoFisico();
            llenarComboBoxUnidadAlmacenamiento();
            PropiedadesGrip();

        }
        public void PropiedadesGrip()
        {
            this.dataGridViewSolucion.Columns[2].Visible = false;
            this.dataGridViewSolucion.Columns[6].Visible = false;
            this.dataGridViewSolucion.Columns[10].Visible = false;
            this.dataGridViewSolucion.Columns[0].HeaderText = "# Solución";
            this.dataGridViewSolucion.Columns[1].HeaderText = "Solución";
            this.dataGridViewSolucion.Columns[3].HeaderText = "Existencias";
            this.dataGridViewSolucion.Columns[4].HeaderText = "Clasificacion";
            this.dataGridViewSolucion.Columns[5].HeaderText = "Estado Fisico";
            this.dataGridViewSolucion.Columns[7].HeaderText = "Unidad";
            this.dataGridViewSolucion.Columns[8].HeaderText = "Ubicación";
            this.dataGridViewSolucion.Columns[9].HeaderText = "Comentario";

        }
        public void LimpiarCampos() {

            txtNombreSolucion.Text = "";
            txtCantidadExistencia.Text = "";
            txtComentarioSolucion.Text = "";
            txtFormulaSolucion.Text = "";
            txtUbicacionSolucion.Text = "";
            DesbloquearCampos();

        }
        public void BloquearCampos()
        {

    
            txtNombreSolucion.Enabled = false;
            txtFormulaSolucion.Enabled = false;
            txtCantidadExistencia.Enabled = false;
            txtUbicacionSolucion.Enabled = false;
            txtComentarioSolucion.Enabled = false;
            cmbCategoriaClasificacion.Enabled = false;
            cmbEstadoFisico.Enabled = false;
            cmbUnidadAlmacenamiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnAgregarCategoria.Enabled = false;
            btnAgregarEstadoFisico.Enabled = false;
            btnUnidadAlmacenamiento.Enabled = false;
        }
        public void DesbloquearCampos()
        {


            txtNombreSolucion.Enabled = true;
            txtFormulaSolucion.Enabled = true;
            txtCantidadExistencia.Enabled = true;
            txtUbicacionSolucion.Enabled = true;
            txtComentarioSolucion.Enabled = true;
            cmbCategoriaClasificacion.Enabled = true;
            cmbEstadoFisico.Enabled = true;
            cmbUnidadAlmacenamiento.Enabled = true;
            btnGuardar.Enabled = true;
            btnAgregarCategoria.Enabled = true;
            btnAgregarEstadoFisico.Enabled = true;
            btnUnidadAlmacenamiento.Enabled = true;
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
            conexion.LlenarCombo(Query, cmbUnidadAlmacenamiento, id, descripcion, nombreTabla);


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
                cmbUnidadAlmacenamiento.Text = nombreUnidad;


            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarComponentesSolucion_Click(object sender, EventArgs e)
        {
            CodigoUnico = this.dataGridViewSolucion.CurrentRow.Cells[0].Value.ToString();
            new frmAddComponenteSolucion(CodigoUnico).ShowDialog();
            CodigoUnico = "";
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

                        string Query = "Exec ModificarSolucion " + CodigoUnico + ",'" + txtNombreSolucion.Text + "','" + txtCantidadExistencia.Text + "','" + txtComentarioSolucion.Text + "','" + txtUbicacionSolucion.Text + "','" + txtFormulaSolucion.Text + "'," + cmbEstadoFisico.SelectedValue + ""
                            + "," + cmbCategoriaClasificacion.SelectedValue + "" + "," + cmbUnidadAlmacenamiento.SelectedValue + "" + "," + usuarioLogin.Id + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosSolucionesReactivosInventario";
                        conexion.LlenarGrid(query, dataGridViewSolucion);

                        LimpiarCampos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarSolucionReactivo '" + txtNombreSolucion.Text + "','" + txtCantidadExistencia.Text + "','" + txtComentarioSolucion.Text + "','" + txtUbicacionSolucion.Text + "','" + txtFormulaSolucion.Text + "'," + cmbEstadoFisico.SelectedValue + ""
                            + "," + cmbCategoriaClasificacion.SelectedValue + "" + "," + cmbUnidadAlmacenamiento.SelectedValue + "" + "," + usuarioLogin.Id + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosSolucionesReactivosInventario";
                        conexion.LlenarGrid(query, dataGridViewSolucion);

                        LimpiarCampos();

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
            if (dataGridViewSolucion.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Editar = true;

                CodigoUnico = this.dataGridViewSolucion.CurrentRow.Cells[0].Value.ToString();

                txtNombreSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[1].Value.ToString();
                txtFormulaSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[2].Value.ToString();
                txtCantidadExistencia.Text = this.dataGridViewSolucion.CurrentRow.Cells[3].Value.ToString();
                cmbCategoriaClasificacion.Text = this.dataGridViewSolucion.CurrentRow.Cells[4].Value.ToString();
                cmbEstadoFisico.Text = this.dataGridViewSolucion.CurrentRow.Cells[5].Value.ToString();
                cmbUnidadAlmacenamiento.Text = this.dataGridViewSolucion.CurrentRow.Cells[6].Value.ToString();
                txtUbicacionSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[8].Value.ToString();
                txtComentarioSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Editar = false;
            if (dataGridViewSolucion.Rows.Count == 0)
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
                        CodigoUnico = this.dataGridViewSolucion.CurrentRow.Cells[0].Value.ToString();

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec ModificarEstadoSolucionReactivo " + CodigoUnico + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosSolucionesReactivosInventario";
                        conexion.LlenarGrid(query, dataGridViewSolucion);

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

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtNombreSolucion.Text) && !string.IsNullOrEmpty(txtFormulaSolucion.Text) &&
            !string.IsNullOrEmpty(txtCantidadExistencia.Text) && !string.IsNullOrEmpty(txtCantidadExistencia.Text) &&
            !string.IsNullOrEmpty(txtUbicacionSolucion.Text) && !string.IsNullOrEmpty(txtComentarioSolucion.Text))
            {
                bandera = true;
            }

            return bandera;
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

        private void txtBuscarSolucion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
          
                    ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                    string query = "exec ConsultarTodosLosSolucionesReactivosInventarioPorNombreSolucion '%" + txtBuscarSolucion.Text + "%'";
                    conexion.LlenarGrid(query, dataGridViewSolucion);
                     PropiedadesGrip();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Editar = false;
        }

        private void btnVerSolucion_Click(object sender, EventArgs e)
        {
            if (dataGridViewSolucion.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Editar = false;
                BloquearCampos();

                CodigoUnico = this.dataGridViewSolucion.CurrentRow.Cells[0].Value.ToString();

                txtNombreSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[1].Value.ToString();
                txtFormulaSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[2].Value.ToString();
                txtCantidadExistencia.Text = this.dataGridViewSolucion.CurrentRow.Cells[3].Value.ToString();
                cmbCategoriaClasificacion.Text = this.dataGridViewSolucion.CurrentRow.Cells[4].Value.ToString();
                cmbEstadoFisico.Text = this.dataGridViewSolucion.CurrentRow.Cells[5].Value.ToString();
                cmbUnidadAlmacenamiento.Text = this.dataGridViewSolucion.CurrentRow.Cells[6].Value.ToString();
                txtUbicacionSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[8].Value.ToString();
                txtComentarioSolucion.Text = this.dataGridViewSolucion.CurrentRow.Cells[9].Value.ToString();
            }
        }
    }
}
