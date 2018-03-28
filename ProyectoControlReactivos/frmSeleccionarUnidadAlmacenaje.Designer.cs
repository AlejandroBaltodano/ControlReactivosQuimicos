namespace ProyectoControlReactivos
{
    partial class frmSeleccionarUnidadAlmacenaje
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevoUnidad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBuscarUnidadAlmacenaje = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvSeleccionarUnidadAlmacenaje = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarUnidadAlmacenaje)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNuevoUnidad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtBuscarUnidadAlmacenaje);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 62);
            this.panel2.TabIndex = 3;
            // 
            // btnNuevoUnidad
            // 
            this.btnNuevoUnidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoUnidad.Image = global::ProyectoControlReactivos.Properties.Resources.add;
            this.btnNuevoUnidad.Location = new System.Drawing.Point(514, 12);
            this.btnNuevoUnidad.Name = "btnNuevoUnidad";
            this.btnNuevoUnidad.Size = new System.Drawing.Size(56, 44);
            this.btnNuevoUnidad.TabIndex = 210;
            this.btnNuevoUnidad.UseVisualStyleBackColor = false;
            this.btnNuevoUnidad.Click += new System.EventHandler(this.btnNuevoUnidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 209;
            this.label1.Text = "Nueva Unidad:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoControlReactivos.Properties.Resources.search16_h;
            this.pictureBox3.Location = new System.Drawing.Point(347, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 23);
            this.pictureBox3.TabIndex = 208;
            this.pictureBox3.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 16);
            this.label18.TabIndex = 206;
            this.label18.Text = "Buscar Unidad Alm.:";
            // 
            // txtBuscarUnidadAlmacenaje
            // 
            this.txtBuscarUnidadAlmacenaje.Location = new System.Drawing.Point(157, 25);
            this.txtBuscarUnidadAlmacenaje.Name = "txtBuscarUnidadAlmacenaje";
            this.txtBuscarUnidadAlmacenaje.Size = new System.Drawing.Size(184, 21);
            this.txtBuscarUnidadAlmacenaje.TabIndex = 207;
            this.txtBuscarUnidadAlmacenaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUnidadAlmacenaje_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 42);
            this.panel1.TabIndex = 4;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::ProyectoControlReactivos.Properties.Resources.arrow_redo;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegresar.Location = new System.Drawing.Point(470, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 36);
            this.btnRegresar.TabIndex = 33;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvSeleccionarUnidadAlmacenaje
            // 
            this.dgvSeleccionarUnidadAlmacenaje.AllowUserToAddRows = false;
            this.dgvSeleccionarUnidadAlmacenaje.AllowUserToDeleteRows = false;
            this.dgvSeleccionarUnidadAlmacenaje.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSeleccionarUnidadAlmacenaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionarUnidadAlmacenaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeleccionarUnidadAlmacenaje.Location = new System.Drawing.Point(0, 62);
            this.dgvSeleccionarUnidadAlmacenaje.Name = "dgvSeleccionarUnidadAlmacenaje";
            this.dgvSeleccionarUnidadAlmacenaje.ReadOnly = true;
            this.dgvSeleccionarUnidadAlmacenaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionarUnidadAlmacenaje.Size = new System.Drawing.Size(592, 344);
            this.dgvSeleccionarUnidadAlmacenaje.TabIndex = 5;
            this.dgvSeleccionarUnidadAlmacenaje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSeleccionarUnidadAlmacenaje_MouseDoubleClick);
            // 
            // frmSeleccionarUnidadAlmacenaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(592, 448);
            this.Controls.Add(this.dgvSeleccionarUnidadAlmacenaje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSeleccionarUnidadAlmacenaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Unidad Almacenamiento ";
            this.Load += new System.EventHandler(this.frmSeleccionarUnidadAlmacenaje_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarUnidadAlmacenaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevoUnidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBuscarUnidadAlmacenaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.DataGridView dgvSeleccionarUnidadAlmacenaje;
    }
}