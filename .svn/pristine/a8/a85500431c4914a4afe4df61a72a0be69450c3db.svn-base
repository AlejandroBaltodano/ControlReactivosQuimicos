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
    public partial class frmMovimientoInventarioSolucion : Form
    {
        public Boolean Editar;
        public string CodigoUnico = "";
        public float cantidadSolucion = 0;
        public string tipoMovimiento = "";
        public ControlReactivos.Model.Usuario usuarioLogin;
        public frmMovimientoInventarioSolucion(ControlReactivos.Model.Usuario usuario)
        {
            InitializeComponent();
            usuarioLogin = usuario;
        }

        private void frmMovimientoInventarioSolucion_Load(object sender, EventArgs e)
        {
            Editar = false;
            txtBuscarPorNombre.Select();
            txtBuscarPorNombre.Focus();
            LLenarSolucionesReactivos();
        }

        public void LLenarSolucionesReactivos()
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosSolucionesReactivosInventario";
            conexion.LlenarGrid(query, dataGridViewSoluciones);
            llenarComboBoxTipoMovimiento();
            llenarComboBoxNombreProfesor();
            PropiedadesGrip();
        }

        public void PropiedadesGrip()
        {
            this.dataGridViewSoluciones.Columns[2].Visible = false;
            this.dataGridViewSoluciones.Columns[6].Visible = false;
            this.dataGridViewSoluciones.Columns[10].Visible = false;
            this.dataGridViewSoluciones.Columns[0].HeaderText = "# Solución";
            this.dataGridViewSoluciones.Columns[1].HeaderText = "Solución";
            this.dataGridViewSoluciones.Columns[3].HeaderText = "Existencias";
            this.dataGridViewSoluciones.Columns[4].HeaderText = "Clasificacion";
            this.dataGridViewSoluciones.Columns[5].HeaderText = "Estado Fisico";
            this.dataGridViewSoluciones.Columns[7].HeaderText = "Unidad";
            this.dataGridViewSoluciones.Columns[8].HeaderText = "Ubicación";
            this.dataGridViewSoluciones.Columns[9].HeaderText = "Comentario";

        }
        public void PropiedadesGripMovimientos()
        {
            this.dataGridViewMovimientosSolucion.Columns[1].Visible = false;
            this.dataGridViewMovimientosSolucion.Columns[3].Visible = false;
            this.dataGridViewMovimientosSolucion.Columns[5].Visible = false;
            this.dataGridViewMovimientosSolucion.Columns[7].Visible = false;
            this.dataGridViewMovimientosSolucion.Columns[10].Visible = false;
            this.dataGridViewMovimientosSolucion.Columns[12].Visible = false;
            this.dataGridViewMovimientosSolucion.Columns[13].Visible = false;
            this.dataGridViewMovimientosSolucion.Columns[0].HeaderText = "# Movimiento";
            this.dataGridViewMovimientosSolucion.Columns[2].HeaderText = "Profesor";
            this.dataGridViewMovimientosSolucion.Columns[4].HeaderText = "Usuario";
            this.dataGridViewMovimientosSolucion.Columns[6].HeaderText = "Solución";
            this.dataGridViewMovimientosSolucion.Columns[8].HeaderText = "Movimiento";
            this.dataGridViewMovimientosSolucion.Columns[9].HeaderText = "Fecha Transaccion";
            this.dataGridViewMovimientosSolucion.Columns[11].HeaderText = "Cant Movimiento";
            this.dataGridViewMovimientosSolucion.Columns[14].HeaderText = "Unidad";

        }
        public void LimpiarCampos()
        {
            txtNombreSolucion.Text = "";
            txtCantidadDelMovimiento.Text = "";
            txtDetalleMovimiento.Text = "";
            lblUnidadAlmacenamiento.Text = "";

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

            if (!string.IsNullOrEmpty(txtNombreSolucion.Text) && !string.IsNullOrEmpty(txtCantidadDelMovimiento.Text) &&
            !string.IsNullOrEmpty(txtDetalleMovimiento.Text))
            {
                bandera = true;
            }

            return bandera;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Editar = false;
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

        private void dataGridViewSoluciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewSoluciones.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            CodigoUnico = this.dataGridViewSoluciones.CurrentRow.Cells[0].Value.ToString();
            txtNombreSolucion.Text = this.dataGridViewSoluciones.CurrentRow.Cells[1].Value.ToString();
            cantidadSolucion = float.Parse(this.dataGridViewSoluciones.CurrentRow.Cells[3].Value.ToString());
            lblUnidadAlmacenamiento.Text = this.dataGridViewSoluciones.CurrentRow.Cells[7].Value.ToString();

            LLenarMovimientoPorIdSolucion(CodigoUnico);
                 }
        }

        public void LLenarMovimientoPorIdSolucion(string id)
        {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosMovimientosSolucionPorSolucionReactivo " + id + "";
            conexion.LlenarGrid(query, dataGridViewMovimientosSolucion);

            PropiedadesGripMovimientos();



        }

        private void txtBuscarPorNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
 ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

            string query = "exec ConsultarTodosLosSolucionesReactivosInventarioPorNombreSolucion '%" + txtBuscarPorNombre.Text + "%'";

            conexion.LlenarGrid(query, dataGridViewSoluciones);
            PropiedadesGrip();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            CodigoUnico = "";
            if (!string.IsNullOrEmpty(txtNombreSolucion.Text))
            {
                CodigoUnico = this.dataGridViewSoluciones.CurrentRow.Cells[0].Value.ToString();
                if (ValidarCampos())
                {
                    float cantidadMovimiento = float.Parse(txtCantidadDelMovimiento.Text);
                    if (cmbTipoMovimiento.Text== "Entrada")
                    {
                        if (cantidadMovimiento <=0)
                        {
                            MessageBox.Show("Error. Verifique estas Opciones:\n\nLa cantidad del Movimiento Entrada no puede ser menor o igual a 0 ", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                                string Query = "Exec InsertarMovimientoSolucion " + cmbNombreProfesor.SelectedValue + "," + usuarioLogin.Id + "," + CodigoUnico + "," + cmbTipoMovimiento.SelectedValue + ",'" + txtDetalleMovimiento.Text + "'," + txtCantidadDelMovimiento.Text + "";

                                conexion.Update(Query);

                                LLenarMovimientoPorIdSolucion(CodigoUnico);

                                LimpiarCampos();
                                LLenarSolucionesReactivos();
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

                        if (cantidadMovimiento > cantidadSolucion || cantidadMovimiento <= 0)
                        {
                            MessageBox.Show("Error. Verifique estas Opciones:\nLa cantidad de Movimiento Salida no puede ser mayor a la existencia de la Solución\nLa cantidad del Movimiento Salida no puede ser menor o igual a 0 ", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                                string Query = "Exec InsertarMovimientoSolucion " + cmbNombreProfesor.SelectedValue + "," + usuarioLogin.Id + "," + CodigoUnico + "," + cmbTipoMovimiento.SelectedValue + ",'" + txtDetalleMovimiento.Text + "'," + txtCantidadDelMovimiento.Text + "";

                                conexion.Update(Query);

                                LLenarMovimientoPorIdSolucion(CodigoUnico);

                                LimpiarCampos();
                                LLenarSolucionesReactivos();
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

        private void txtBuscarPorNombreMovimiento_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                CodigoUnico = this.dataGridViewSoluciones.CurrentRow.Cells[0].Value.ToString();
                string query = "exec ConsultarTodosLosMovimientosSolucionPorTipoMovimiento "+CodigoUnico+", '%" + txtBuscarPorNombreMovimiento.Text + "%'";

                conexion.LlenarGrid(query, dataGridViewMovimientosSolucion);
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
                CodigoUnico = this.dataGridViewSoluciones.CurrentRow.Cells[0].Value.ToString();
                string query = "exec ConsultarTodosLosMovimientosSolucionPorProfesor " + CodigoUnico + ", '%" + txtBuscarPorProfesor.Text + "%'";

                conexion.LlenarGrid(query, dataGridViewMovimientosSolucion);
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

                ControlReactivos.Model.MovimientoSolucion movimientoSolucion = new ControlReactivos.Model.MovimientoSolucion();
                movimientoSolucion.NumeroMovimiento = int.Parse(this.dataGridViewMovimientosSolucion.CurrentRow.Cells[0].Value.ToString());
                movimientoSolucion.NombreProfesor = this.dataGridViewMovimientosSolucion.CurrentRow.Cells[2].Value.ToString();
                movimientoSolucion.NombreUsuario = this.dataGridViewMovimientosSolucion.CurrentRow.Cells[4].Value.ToString();
                movimientoSolucion.NombreSolucion = this.dataGridViewMovimientosSolucion.CurrentRow.Cells[6].Value.ToString();
                movimientoSolucion.NombreMovimiento = this.dataGridViewMovimientosSolucion.CurrentRow.Cells[8].Value.ToString();
                movimientoSolucion.FechaTransaccion = Convert.ToDateTime(this.dataGridViewMovimientosSolucion.CurrentRow.Cells[9].Value.ToString());
                movimientoSolucion.CantidadMovimiento = float.Parse(this.dataGridViewMovimientosSolucion.CurrentRow.Cells[11].Value.ToString());
                movimientoSolucion.UnidadAlmacenamiento = this.dataGridViewMovimientosSolucion.CurrentRow.Cells[14].Value.ToString();
               
                frmReporteDeUnMovimientoSolucion reporte = new frmReporteDeUnMovimientoSolucion();
                reporte.Detail.Add(movimientoSolucion);

                reporte.ShowDialog();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
