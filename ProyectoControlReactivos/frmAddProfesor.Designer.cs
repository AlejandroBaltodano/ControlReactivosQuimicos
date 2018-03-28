namespace ProyectoControlReactivos
{
    partial class frmAddProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProfesor));
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido1Profesor = new System.Windows.Forms.TextBox();
            this.txtCedulaProfesor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido2Profesor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProfeciones = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.btnAgregarEmail = new System.Windows.Forms.Button();
            this.btnAgregarProfecion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataGridViewProfesor = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nuevo Profesor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.AccessibleDescription = "";
            this.txtNombreProfesor.Location = new System.Drawing.Point(353, 116);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(140, 21);
            this.txtNombreProfesor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primer Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // txtApellido1Profesor
            // 
            this.txtApellido1Profesor.AccessibleDescription = "";
            this.txtApellido1Profesor.Location = new System.Drawing.Point(353, 146);
            this.txtApellido1Profesor.Name = "txtApellido1Profesor";
            this.txtApellido1Profesor.Size = new System.Drawing.Size(140, 21);
            this.txtApellido1Profesor.TabIndex = 7;
            // 
            // txtCedulaProfesor
            // 
            this.txtCedulaProfesor.AccessibleDescription = "";
            this.txtCedulaProfesor.Location = new System.Drawing.Point(353, 82);
            this.txtCedulaProfesor.Name = "txtCedulaProfesor";
            this.txtCedulaProfesor.Size = new System.Drawing.Size(140, 21);
            this.txtCedulaProfesor.TabIndex = 3;
            this.txtCedulaProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaProfesor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula:";
            // 
            // txtApellido2Profesor
            // 
            this.txtApellido2Profesor.AccessibleDescription = "";
            this.txtApellido2Profesor.Location = new System.Drawing.Point(353, 176);
            this.txtApellido2Profesor.Name = "txtApellido2Profesor";
            this.txtApellido2Profesor.Size = new System.Drawing.Size(140, 21);
            this.txtApellido2Profesor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Profesion:";
            // 
            // cmbProfeciones
            // 
            this.cmbProfeciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfeciones.FormattingEnabled = true;
            this.cmbProfeciones.Location = new System.Drawing.Point(353, 208);
            this.cmbProfeciones.Name = "cmbProfeciones";
            this.cmbProfeciones.Size = new System.Drawing.Size(140, 23);
            this.cmbProfeciones.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(221, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Datos Personales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "_______________________________________";
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.BackgroundImage = global::ProyectoControlReactivos.Properties.Resources.phone_add;
            this.btnAgregarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarTelefono.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarTelefono.Location = new System.Drawing.Point(850, 347);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(87, 27);
            this.btnAgregarTelefono.TabIndex = 17;
            this.btnAgregarTelefono.Text = "Telefono";
            this.btnAgregarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // btnAgregarEmail
            // 
            this.btnAgregarEmail.BackgroundImage = global::ProyectoControlReactivos.Properties.Resources.email_add;
            this.btnAgregarEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarEmail.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarEmail.Location = new System.Drawing.Point(756, 347);
            this.btnAgregarEmail.Name = "btnAgregarEmail";
            this.btnAgregarEmail.Size = new System.Drawing.Size(87, 27);
            this.btnAgregarEmail.TabIndex = 16;
            this.btnAgregarEmail.Text = "Email";
            this.btnAgregarEmail.UseVisualStyleBackColor = true;
            this.btnAgregarEmail.Click += new System.EventHandler(this.btnAgregarEmail_Click);
            // 
            // btnAgregarProfecion
            // 
            this.btnAgregarProfecion.BackgroundImage = global::ProyectoControlReactivos.Properties.Resources.book_add;
            this.btnAgregarProfecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProfecion.Location = new System.Drawing.Point(512, 205);
            this.btnAgregarProfecion.Name = "btnAgregarProfecion";
            this.btnAgregarProfecion.Size = new System.Drawing.Size(30, 29);
            this.btnAgregarProfecion.TabIndex = 12;
            this.btnAgregarProfecion.UseVisualStyleBackColor = true;
            this.btnAgregarProfecion.Click += new System.EventHandler(this.btnAgregarProfecion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(406, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::ProyectoControlReactivos.Properties.Resources.page_save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(311, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 27);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoControlReactivos.Properties.Resources.teacher_icon;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::ProyectoControlReactivos.Properties.Resources.user_delete;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBorrar.Location = new System.Drawing.Point(1039, 347);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(87, 27);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(756, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Profesores Registrados";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::ProyectoControlReactivos.Properties.Resources.user_edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditar.Location = new System.Drawing.Point(945, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 27);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridViewProfesor
            // 
            this.dataGridViewProfesor.AllowUserToAddRows = false;
            this.dataGridViewProfesor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesor.Location = new System.Drawing.Point(559, 62);
            this.dataGridViewProfesor.Name = "dataGridViewProfesor";
            this.dataGridViewProfesor.ReadOnly = true;
            this.dataGridViewProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProfesor.Size = new System.Drawing.Size(577, 278);
            this.dataGridViewProfesor.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1127, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________________";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::ProyectoControlReactivos.Properties.Resources.arrow_redo;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegresar.Location = new System.Drawing.Point(1039, 390);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(87, 27);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmAddProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 419);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridViewProfesor);
            this.Controls.Add(this.btnAgregarTelefono);
            this.Controls.Add(this.btnAgregarEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAgregarProfecion);
            this.Controls.Add(this.cmbProfeciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellido2Profesor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCedulaProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido1Profesor);
            this.Controls.Add(this.txtNombreProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Profesor";
            this.Load += new System.EventHandler(this.frmAddProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtApellido1Profesor;
        private System.Windows.Forms.TextBox txtCedulaProfesor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido2Profesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProfeciones;
        private System.Windows.Forms.Button btnAgregarProfecion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarEmail;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridViewProfesor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegresar;
    }
}