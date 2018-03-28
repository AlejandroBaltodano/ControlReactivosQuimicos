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
    public partial class frmMovimientoInventario : Form
    {
        public Boolean Editar;
        public string CodigoUnico = "";
        public float cantidadExistenciaReactivo = 0;
        public string tipoMovimiento = "";

        ControlReactivos.Model.Usuario usuarioLogin;
        public frmMovimientoInventario(ControlReactivos.Model.Usuario nombreUsuario)
        {
            InitializeComponent();
            usuarioLogin = nombreUsuario;
        }

        private void frmMovimientoInventario_Load(object sender, EventArgs e)
        {
            txtBuscarPorCodigo.Focus();
            txtBuscarPorCodigo.Select();
            LlenarAlInicio();
        }


        public void LlenarAlInicio() {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosReactivosInventario";
            conexion.LlenarGrid(query, dataGridViewReactivos);

            llenarComboBoxTipoMovimiento();
            llenarComboBoxNombreProfesor();
            PropiedadesGrip();
        }

        public void PropiedadesGrip()
        {
            this.dataGridViewReactivos.Columns[3].Visible = false;
            this.dataGridViewReactivos.Columns[4].Visible = false;
            this.dataGridViewReactivos.Columns[6].Visible = false;
            this.dataGridViewReactivos.Columns[7].Visible = false;
            this.dataGridViewReactivos.Columns[8].Visible = false;
            this.dataGridViewReactivos.Columns[12].Visible = false;
            this.dataGridViewReactivos.Columns[0].HeaderText = "# Reactivo";
            this.dataGridViewReactivos.Columns[1].HeaderText = "Cod Reactivo";
            this.dataGridViewReactivos.Columns[2].HeaderText = "Reactivo";
            this.dataGridViewReactivos.Columns[5].HeaderText = "Existencias";
            this.dataGridViewReactivos.Columns[9].HeaderText = "Unidad";
            this.dataGridViewReactivos.Columns[10].HeaderText = "Ubicación";
            this.dataGridViewReactivos.Columns[11].HeaderText = "Comentario";

        }

        public void PropiedadesGripMovimientos()
        {
            this.dataGridViewMovimientosDelReactivo.Columns[1].Visible = false;
            this.dataGridViewMovimientosDelReactivo.Columns[3].Visible = false;
            this.dataGridViewMovimientosDelReactivo.Columns[5].Visible = false;
            this.dataGridViewMovimientosDelReactivo.Columns[8].Visible = false;
            this.dataGridViewMovimientosDelReactivo.Columns[13].Visible = false;
            this.dataGridViewMovimientosDelReactivo.Columns[14].Visible = false;
            this.dataGridViewMovimientosDelReactivo.Columns[0].HeaderText = "# Movimiento";
            this.dataGridViewMovimientosDelReactivo.Columns[2].HeaderText = "Nombre Profesor";
            this.dataGridViewMovimientosDelReactivo.Columns[4].HeaderText = "Nombre Usuario";
            this.dataGridViewMovimientosDelReactivo.Columns[6].HeaderText = "CAS";
            this.dataGridViewMovimientosDelReactivo.Columns[7].HeaderText = "Nombre Reactivo";
            this.dataGridViewMovimientosDelReactivo.Columns[9].HeaderText = "Tipo Movimiento";
            this.dataGridViewMovimientosDelReactivo.Columns[10].HeaderText = "Fecha Transaccion";
            this.dataGridViewMovimientosDelReactivo.Columns[11].HeaderText = "Comentario";
            this.dataGridViewMovimientosDelReactivo.Columns[12].HeaderText = "Cantida del Movimiento";
            this.dataGridViewMovimientosDelReactivo.Columns[15].HeaderText = "Unidad";

        }

        public void llenarComboBoxTipoMovimiento()
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string Query = "exec ConsultarCatalogoMovimientoInventario";
            string id = "IdCatalogoMovimientoInventario";
            string descripcion = "NombreMovimiento";
            string nombreTabla = "Tabla_Catalogo_Movimiento_Inventario";
            conexion.LlenarCombo(Query, cmbTipoMovimiento, id, descripcion, nombreTabla);


        }
        public void llenarComboBoxNombreProfesor()
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string Query = "exec ConsultarTodosLosProfesores";
            string id = "IdProfesor";
            string descripcion = "NombreProfesor";
            string nombreTabla = "Tabla_Profesor";
            conexion.LlenarCombo(Query, cmbNombreProfesor, id, descripcion, nombreTabla);

        }

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtCodigoReactivo.Text) && !string.IsNullOrEmpty(txtCantidadDelMovimiento.Text) &&
            !string.IsNullOrEmpty(txtDetalleMovimiento.Text))
            {
                bandera = true;
            }

            return bandera;
        }

        public void LimpiarDatos()
        {
            txtCodigoReactivo.Clear();
            txtCantidadDelMovimiento.Clear();
            txtBuscarPorCodigo.Clear();
            txtDetalleMovimiento.Clear();
            lblUnidadAlmacemaniento.Text = "";
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarPorCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

            string query = "ConsultarTodosLosReactivosInventarioPorCodigo '%" + txtBuscarPorCodigo.Text + "%'";

            conexion.LlenarGrid(query, dataGridViewReactivos);
            PropiedadesGrip();
        }

        private void dataGridViewReactivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewReactivos.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CodigoUnico = this.dataGridViewReactivos.CurrentRow.Cells[0].Value.ToString();
                txtCodigoReactivo.Text = this.dataGridViewReactivos.CurrentRow.Cells[1].Value.ToString();
                cantidadExistenciaReactivo = float.Parse(this.dataGridViewReactivos.CurrentRow.Cells[5].Value.ToString());
                lblUnidadAlmacemaniento.Text = this.dataGridViewReactivos.CurrentRow.Cells[9].Value.ToString();
                tipoMovimiento = cmbTipoMovimiento.SelectedText;

                LLenarMovimientoPorIdReactivo(CodigoUnico);
            }

        }

        public void LLenarMovimientoPorIdReactivo(string id) {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosMovimientosPorReactivo " + id+"";
            conexion.LlenarGrid(query, dataGridViewMovimientosDelReactivo);

            PropiedadesGripMovimientos();



        }

        private void txtCantidadDelMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            CodigoUnico = "";
            if (!string.IsNullOrEmpty(txtCodigoReactivo.Text))
            {
                CodigoUnico = this.dataGridViewReactivos.CurrentRow.Cells[0].Value.ToString();
                if (ValidarCampos())
                {
                    float cantidadMovimiento = float.Parse(txtCantidadDelMovimiento.Text);
                    if (cmbTipoMovimiento.Text == "Entrada")
                    {
                        if (cantidadMovimiento <= 0)
                        {
                            MessageBox.Show("Error. Verifique estas Opciones:\n\nLa cantidad del Movimiento Entrada no puede ser menor o igual a 0 ", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                                string Query = "Exec InsertarMovimientoInventario " + cmbNombreProfesor.SelectedValue + "," + usuarioLogin.Id + "," + CodigoUnico + "," + cmbTipoMovimiento.SelectedValue + ",'" + txtDetalleMovimiento.Text + "'," + txtCantidadDelMovimiento.Text + "";

                                conexion.Update(Query);

                                LLenarMovimientoPorIdReactivo(CodigoUnico);

                                LimpiarDatos();
                                LlenarAlInicio();
                                MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            catch (Exception)
                            {
                                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {

                        if (cantidadMovimiento > cantidadExistenciaReactivo || cantidadMovimiento <= 0)
                        {
                            MessageBox.Show("Error. Verifique estas Opciones:\nLa cantidad de Movimiento Salida no puede ser mayor a la existencia del Reactivo\nLa cantidad del Movimiento Salida no puede ser menor o igual a 0 ", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                                string Query = "Exec InsertarMovimientoInventario " + cmbNombreProfesor.SelectedValue + "," + usuarioLogin.Id + "," + CodigoUnico + "," + cmbTipoMovimiento.SelectedValue + ",'" + txtDetalleMovimiento.Text + "'," + txtCantidadDelMovimiento.Text + "";

                                conexion.Update(Query);

                                LLenarMovimientoPorIdReactivo(CodigoUnico);

                                LimpiarDatos();
                                LlenarAlInicio();
                                MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            catch (Exception)
                            {
                                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Problemas al realizar la transaccion, Verifique que los campos no esten vacios", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede ingresar un movimiento sin un Nombre de Solución.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            frmSeleccionarProfesor agregarProfesor = new frmSeleccionarProfesor(usuarioLogin);
            string nombreProfesor = "";
            string idProfesor = "";

            if (agregarProfesor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataGridViewRow item in agregarProfesor.dgvSeleccionarProfesor.SelectedRows)
                {
                    idProfesor = item.Cells[0].Value.ToString();
                    nombreProfesor = item.Cells[2].Value.ToString();
                    llenarComboBoxNombreProfesor();

                }
                cmbNombreProfesor.Text = nombreProfesor;


            }
        }

        private void btnRegregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarporNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarTodosLosReactivosInventarioPorNombre '%" + txtBuscarporNombre.Text + "%'";
                conexion.LlenarGrid(query, dataGridViewReactivos);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirMovimiento_Click(object sender, EventArgs e)
        {
            try
            {

                ControlReactivos.Model.MovimientoReactivo movimientoReactivo = new ControlReactivos.Model.MovimientoReactivo();
                movimientoReactivo.NumeroMovimiento =int.Parse( this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[0].Value.ToString());
                movimientoReactivo.NombreProfesor =  this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[2].Value.ToString();
                movimientoReactivo.NombreUsuario = this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[4].Value.ToString();
                movimientoReactivo.CAS = CodigoUnico = this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[6].Value.ToString();
                movimientoReactivo.NombreReactivo= this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[7].Value.ToString();
                movimientoReactivo.NombreMovimiento= this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[9].Value.ToString();
                movimientoReactivo.FechaTransaccion= Convert.ToDateTime( this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[10].Value.ToString());
                movimientoReactivo.CantidadMovimiento = float.Parse(this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[12].Value.ToString());
                movimientoReactivo.UnidadAlmacenamiento= this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[15].Value.ToString();
                movimientoReactivo.Comentario= this.dataGridViewMovimientosDelReactivo.CurrentRow.Cells[11].Value.ToString();

                frmReporteDeUnMovimientoReactivo reporte = new frmReporteDeUnMovimientoReactivo();
                reporte.Detail.Add(movimientoReactivo);

                reporte.ShowDialog();


            }
            catch (Exception)
            {

             MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarPorNombreMovimiento_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                CodigoUnico = this.dataGridViewReactivos.CurrentRow.Cells[0].Value.ToString();
                string query = "exec ConsultarTodosLosMovimientosPorTipoDeMovimiento "+CodigoUnico+",'%" + txtBuscarPorNombreMovimiento.Text + "%'";
                conexion.LlenarGrid(query, dataGridViewMovimientosDelReactivo);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarPorProfesor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                CodigoUnico = this.dataGridViewReactivos.CurrentRow.Cells[0].Value.ToString();
                string query = "exec ConsultarTodosLosMovimientosPorProfesor "+CodigoUnico+",'%" + txtBuscarPorProfesor.Text + "%'";
                conexion.LlenarGrid(query, dataGridViewMovimientosDelReactivo);
                PropiedadesGrip();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
 