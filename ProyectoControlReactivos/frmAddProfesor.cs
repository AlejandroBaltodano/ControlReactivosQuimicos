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
    public partial class frmAddProfesor : Form
    {
        
      public  Boolean Editar;
      public string CodigoUnico = "";


        ControlReactivos.Model.Usuario usuarioLogin;
        public frmAddProfesor(ControlReactivos.Model.Usuario nombreUsuario)
        {
            usuarioLogin = nombreUsuario;
            InitializeComponent();
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

                        string Query = "Exec ModificarProfesor '" + CodigoUnico + "','" + txtCedulaProfesor.Text + "','" + txtNombreProfesor.Text + "','" + txtApellido1Profesor.Text + "','" + txtApellido2Profesor.Text + "'," + cmbProfeciones.SelectedValue + "," + usuarioLogin.Id + "";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosProfesores";
                        conexion.LlenarGrid(query, dataGridViewProfesor);

                        LimpiarDatos();

                        Editar = false;
                        CodigoUnico = "";
                    }

                    else
                    {
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                        string Query = "Exec InsertarProfesor '" + txtCedulaProfesor.Text + "','" + txtNombreProfesor.Text + "','" + txtApellido1Profesor.Text + "','" + txtApellido2Profesor.Text + "'," + cmbProfeciones.SelectedValue + ",'" + usuarioLogin.Id + "'";

                        conexion.Update(Query);

                        string query = "exec ConsultarTodosLosProfesores";
                        conexion.LlenarGrid(query, dataGridViewProfesor);

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

        private void frmAddProfesor_Load(object sender, EventArgs e)
        {
            Editar = false;
            txtCedulaProfesor.Select();
            txtCedulaProfesor.Focus();
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string query = "exec ConsultarTodosLosProfesores";
            conexion.LlenarGrid(query, dataGridViewProfesor);

            llenarComboBox();
            PropiedadesGrip();
        }

        public void LimpiarDatos()
        {

            txtCedulaProfesor.Clear();
            txtNombreProfesor.Clear();
            txtApellido1Profesor.Clear();
            txtApellido2Profesor.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            Editar = false;
        }

        private void btnAgregarProfecion_Click(object sender, EventArgs e)
        {
            frmSeleccionarCatalogoProfesion agregarProfesion = new frmSeleccionarCatalogoProfesion();
            string nombreProfesion = "";
            string idProfesion = "";

            if (agregarProfesion.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataGridViewRow item in agregarProfesion.dgvSeleccionarProfesion.SelectedRows)
                {
                    idProfesion = item.Cells[0].Value.ToString();
                    nombreProfesion = item.Cells[1].Value.ToString();
                    llenarComboBox();

                }
                cmbProfeciones.Text = nombreProfesion;


            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void llenarComboBox()
        {
            ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
            string Query = "exec ConsultarCatalogoProfesion";
            string id = "IdCatalogoProfesion";
            string descripcion = "NombreProfesion";
            string nombreTabla = "Tabla_Catalogo_Profesion";
            conexion.LlenarCombo(Query, cmbProfeciones, id, descripcion, nombreTabla);


        }
        public void PropiedadesGrip() {


            this.dataGridViewProfesor.Columns[4].Visible = false;
            this.dataGridViewProfesor.Columns[5].Visible = false;
            this.dataGridViewProfesor.Columns[6].Visible = false;
            this.dataGridViewProfesor.Columns[7].Visible = false;
            this.dataGridViewProfesor.Columns[0].HeaderText = "# Profesor";
            this.dataGridViewProfesor.Columns[2].HeaderText = "Nombre";
            this.dataGridViewProfesor.Columns[3].HeaderText = "Primer Apellido";
            this.dataGridViewProfesor.Columns[8].HeaderText = "Profesión";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfesor.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            Editar = true;
           

            CodigoUnico = this.dataGridViewProfesor.CurrentRow.Cells[0].Value.ToString();

            txtCedulaProfesor.Text = this.dataGridViewProfesor.CurrentRow.Cells[1].Value.ToString();
            txtNombreProfesor.Text = this.dataGridViewProfesor.CurrentRow.Cells[2].Value.ToString();
            txtApellido1Profesor.Text = this.dataGridViewProfesor.CurrentRow.Cells[3].Value.ToString();
            txtApellido2Profesor.Text = this.dataGridViewProfesor.CurrentRow.Cells[4].Value.ToString();
            cmbProfeciones.Text = this.dataGridViewProfesor.CurrentRow.Cells[8].Value.ToString();
        }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfesor.Rows.Count == 0)
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
                    CodigoUnico = this.dataGridViewProfesor.CurrentRow.Cells[0].Value.ToString();

                    ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();

                    string Query = "Exec ModificarEstadoProfesor '" + CodigoUnico + "'";

                    conexion.Update(Query);

                    string query = "exec ConsultarTodosLosProfesores";
                    conexion.LlenarGrid(query, dataGridViewProfesor);

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

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfesor.Rows.Count==0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CodigoUnico = this.dataGridViewProfesor.CurrentRow.Cells[0].Value.ToString();
                new frmAddTelefonoProfesor(CodigoUnico).ShowDialog();
                CodigoUnico = "";
            }
            
        }

        private void btnAgregarEmail_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfesor.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CodigoUnico = this.dataGridViewProfesor.CurrentRow.Cells[0].Value.ToString();
                new frmAddCorreoProfesor(CodigoUnico).ShowDialog();
                CodigoUnico = "";

            }
        }

        public bool ValidarCampos() {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtCedulaProfesor.Text) && !string.IsNullOrEmpty(txtNombreProfesor.Text)&&
            !string.IsNullOrEmpty(txtApellido1Profesor.Text)&& !string.IsNullOrEmpty(txtApellido2Profesor.Text))
            {
                bandera = true;
            }

            return bandera;
                 
        }

        private void txtCedulaProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
