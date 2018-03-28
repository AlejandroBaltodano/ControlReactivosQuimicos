namespace ProyectoControlReactivos
{
    partial class frmSeleccionarCategoriaClasificacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBuscarClasificacion = new System.Windows.Forms.TextBox();
            this.dgvSeleccionarCategoriaSeleccion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaClasificacion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarCategoriaSeleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNuevaClasificacion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtBuscarClasificacion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 62);
            this.panel2.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 16);
            this.label18.TabIndex = 206;
            this.label18.Text = "Buscar Clasificación:";
            // 
            // txtBuscarClasificacion
            // 
            this.txtBuscarClasificacion.Location = new System.Drawing.Point(162, 25);
            this.txtBuscarClasificacion.Name = "txtBuscarClasificacion";
            this.txtBuscarClasificacion.Size = new System.Drawing.Size(184, 21);
            this.txtBuscarClasificacion.TabIndex = 207;
            this.txtBuscarClasificacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarClasificacion_KeyUp);
            // 
            // dgvSeleccionarCategoriaSeleccion
            // 
            this.dgvSeleccionarCategoriaSeleccion.AllowUserToAddRows = false;
            this.dgvSeleccionarCategoriaSeleccion.AllowUserToDeleteRows = false;
            this.dgvSeleccionarCategoriaSeleccion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSeleccionarCategoriaSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionarCategoriaSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeleccionarCategoriaSeleccion.Location = new System.Drawing.Point(0, 62);
            this.dgvSeleccionarCategoriaSeleccion.Name = "dgvSeleccionarCategoriaSeleccion";
            this.dgvSeleccionarCategoriaSeleccion.ReadOnly = true;
            this.dgvSeleccionarCategoriaSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionarCategoriaSeleccion.Size = new System.Drawing.Size(600, 314);
            this.dgvSeleccionarCategoriaSeleccion.TabIndex = 2;
            this.dgvSeleccionarCategoriaSeleccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSeleccionarCategoriaSeleccion_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 209;
            this.label1.Text = "Nueva Clasificación:";
            // 
            // btnNuevaClasificacion
            // 
            this.btnNuevaClasificacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevaClasificacion.Image = global::ProyectoControlReactivos.Properties.Resources.add;
            this.btnNuevaClasificacion.Location = new System.Drawing.Point(532, 12);
            this.btnNuevaClasificacion.Name = "btnNuevaClasificacion";
            this.btnNuevaClasificacion.Size = new System.Drawing.Size(56, 44);
            this.btnNuevaClasificacion.TabIndex = 210;
            this.btnNuevaClasificacion.UseVisualStyleBackColor = false;
            this.btnNuevaClasificacion.Click += new System.EventHandler(this.btnNuevaClasificacion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoControlReactivos.Properties.Resources.search16_h;
            this.pictureBox3.Location = new System.Drawing.Point(352, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 23);
            this.pictureBox3.TabIndex = 208;
            this.pictureBox3.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::ProyectoControlReactivos.Properties.Resources.arrow_redo;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegresar.Location = new System.Drawing.Point(479, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 36);
            this.btnRegresar.TabIndex = 33;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmSeleccionarCategoriaClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.dgvSeleccionarCategoriaSeleccion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSeleccionarCategoriaClasificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Categoria Clasificacion";
            this.Load += new System.EventHandler(this.frmSeleccionarCategoriaClasificacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarCategoriaSeleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvSeleccionarCategoriaSeleccion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBuscarClasificacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaClasificacion;
    }
}