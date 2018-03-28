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
    public partial class frmAddComponenteSolucion : Form
    {
        string IdSolucion;
        float cantidadreactivos = 0;
        string IdReactivo="";
        public frmAddComponenteSolucion(string CodigoUnico)
        {
            InitializeComponent();
            IdSolucion = CodigoUnico;
        }

        private void frmAddComponenteSolucion_Load(object sender, EventArgs e)
        {
            txtBuscarReactivo.Select();
            txtBuscarReactivo.Focus();
            LLenarInicioReactivosParaSolucion();
            LLenarInicioComponentesPorIdSolucion();
            PropiedadesGridReactivos();
            PropiedadesGridComponentesSolucion();
        }

        public void PropiedadesGridComponentesSolucion() {
            this.dataGridViewComponenteSolucion.Columns[1].Visible = false;
            this.dataGridViewComponenteSolucion.Columns[3].Visible = false;
            this.dataGridViewComponenteSolucion.Columns[0].HeaderText = "# Componente";
            this.dataGridViewComponenteSolucion.Columns[2].HeaderText = "Solución";
            this.dataGridViewComponenteSolucion.Columns[4].HeaderText = "Cod Reactivo";
            this.dataGridViewComponenteSolucion.Columns[5].HeaderText = "Cant. Reactivo Tomada";

        }
        public void PropiedadesGridReactivos()
        {
            this.dataGridViewReactivo.Columns[3].Visible = false;
            this.dataGridViewReactivo.Columns[4].Visible = false;
            this.dataGridViewReactivo.Columns[6].Visible = false;
            this.dataGridViewReactivo.Columns[7].Visible = false;
            this.dataGridViewReactivo.Columns[8].Visible = false;
            this.dataGridViewReactivo.Columns[10].Visible = false;
            this.dataGridViewReactivo.Columns[11].Visible = false;
            this.dataGridViewReactivo.Columns[0].HeaderText = "# Reactivo";
            this.dataGridViewReactivo.Columns[1].HeaderText = "Cod Reactivo";
            this.dataGridViewReactivo.Columns[2].HeaderText = "Reactivo";
            this.dataGridViewReactivo.Columns[5].HeaderText = "Existencias";
            this.dataGridViewReactivo.Columns[9].HeaderText = "Unidad";



        }

        public void LLenarInicioComponentesPorIdSolucion() {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarComponentesSolucionPorIdSolucion "+IdSolucion+"";
            conexion.LlenarGrid(query, dataGridViewComponenteSolucion);
        }

        public void LLenarInicioReactivosParaSolucion() {

            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosReactivosInventarioExistenciasMayorACero ";
            conexion.LlenarGrid(query, dataGridViewReactivo);


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      

        private void dataGridViewReactivo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
            IdReactivo= this.dataGridViewReactivo.CurrentRow.Cells[0].Value.ToString();
            txtCodigoReactivo.Text = this.dataGridViewReactivo.CurrentRow.Cells[1].Value.ToString();
            cantidadreactivos = float.Parse(this.dataGridViewReactivo.CurrentRow.Cells[5].Value.ToString());
            txtCantidadReacticoATomar.Select();
            txtCantidadReacticoATomar.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public void LimpiarCampos() {
            txtCodigoReactivo.Text = "";
            txtCantidadReacticoATomar.Text = "";


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidarCampos())
                {
                    float cantidadTomada = float.Parse(txtCantidadReacticoATomar.Text);

                    if (cantidadTomada > cantidadreactivos || cantidadTomada <= 0)
                    {
                        MessageBox.Show("Error. Verifique estas Opciones:\nLa cantidad a tomar no puede ser mayor a la existencia del reactivo\nLa cantidad a tomar no puede ser menor o igual a 0 ", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarComponentesSoluciones " + IdSolucion + "," + IdReactivo + "," + cantidadTomada + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarComponentesSolucionPorIdSolucion " + IdSolucion + "";
                        conexion.LlenarGrid(query, dataGridViewComponenteSolucion);
                        LLenarInicioReactivosParaSolucion();
                        PropiedadesGridReactivos();
                        LimpiarCampos();
                        MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Problemas al realizar la transaccion, Verifique que los campos no esten vacios", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewComponenteSolucion.Rows.Count == 0)
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

                        string Cod = this.dataGridViewComponenteSolucion.CurrentRow.Cells[0].Value.ToString();
                       
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec EliminarComponentesSolucion " + Cod + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarComponentesSolucionPorIdSolucion " + IdSolucion + "";
                        conexion.LlenarGrid(query, dataGridViewComponenteSolucion);
                        PropiedadesGridComponentesSolucion();
                        LLenarInicioReactivosParaSolucion();
                        PropiedadesGridReactivos();


                        MessageBox.Show("Transaccion realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Problemas al realizar Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtBuscarReactivo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
             
                    ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                    string query = "exec ConsultarTodosLosReactivosInventarioPorCodigo '%" + txtBuscarReactivo.Text + "%'";
                    conexion.LlenarGrid(query, dataGridViewReactivo);
                    PropiedadesGridReactivos();
                

            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarSolucionComponente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
          
                    ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                    string query = "exec ConsultarComponentesSolucionPorNombreSolucion '%" + txtBuscarSolucionComponente.Text + "%'";
                    conexion.LlenarGrid(query, dataGridViewComponenteSolucion);
                    PropiedadesGridComponentesSolucion();
               

            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtCantidadReacticoATomar.Text) && !string.IsNullOrEmpty(txtCodigoReactivo.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                string query = "exec ConsultarTodosLosReactivosInventarioPorNombre '%" + txtBuscarPorNombre.Text + "%'";
                conexion.LlenarGrid(query, dataGridViewReactivo);
                PropiedadesGridReactivos();


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
