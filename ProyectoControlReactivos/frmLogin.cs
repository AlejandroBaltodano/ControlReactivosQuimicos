﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoControlReactivos
{
    public partial class frmLogin : Form
    {
        ControlReactivos.Model.Usuario usuarioLogin;
        public frmLogin()
        {
            usuarioLogin = new ControlReactivos.Model.Usuario();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (ValidarCampos())
                    {
                        ControlReactivos.AccesoADatos.Conexion conexion = new ControlReactivos.AccesoADatos.Conexion();
                        string query = "";

                        query = "exec ValidarUsuario '" + txtUsuario.Text + "','" + txtContraseña.Text + "'";

                        SqlDataReader reader = conexion.Query(query);

                        if ((reader.HasRows))
                        {

                            while (reader.Read())
                            {
                                usuarioLogin.Id = reader.GetInt32(0);
                                usuarioLogin.Cedula = reader.GetString(1);
                            }
                            usuarioLogin.NombreUsuarioSql = txtUsuario.Text;
                            string Query = "Exec InsertarInicioSesionUsuario '" + usuarioLogin.NombreUsuarioSql + "','" + usuarioLogin.Cedula + "'," + usuarioLogin.Id + "";
                            conexion.Update(Query);
                            txtUsuario.Clear();
                            txtContraseña.Clear();
                            new frmPrincipal(usuarioLogin).Show();
                            reader.Close();
                            this.Visible = false;



                        }
                        else if ((txtUsuario.Text.Equals("admin") && (txtContraseña.Text.Equals("admin"))))
                        {
                           
                                //esto es por si se entra con el usuario generico para poder restaurar
                                usuarioLogin.Cedula = "0";
                                usuarioLogin.NombreUsuarioSql = "Usuario Generico";
                                usuarioLogin.Id = 0;
                                txtUsuario.Clear();
                                txtContraseña.Clear();
                                new frmPrincipal(usuarioLogin).Show();
                                this.Visible = false;

                        }
                        else
                        {
                            txtUsuario.Clear();
                            txtContraseña.Clear();
                            MessageBox.Show("Usuario no Registrado", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Problemas al realizar la transaccion, Verifique que los campos no esten vacios", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    MessageBox.Show("Usuario no Registrado", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                


            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al Realizar la Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
            txtUsuario.Focus();

        }
        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
            {
                bandera = true;
            }

            return bandera;

        }
    }
}
