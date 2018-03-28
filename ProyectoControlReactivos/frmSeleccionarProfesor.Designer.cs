namespace ProyectoControlReactivos
{
    partial class frmSeleccionarProfesor
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
            this.btnNuevoProfesor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvSeleccionarProfesor = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNuevoProfesor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtBuscarProfesor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 62);
            this.panel2.TabIndex = 2;
            // 
            // btnNuevoProfesor
            // 
            this.btnNuevoProfesor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoProfesor.Image = global::ProyectoControlReactivos.Properties.Resources.add;
            this.btnNuevoProfesor.Location = new System.Drawing.Point(504, 12);
            this.btnNuevoProfesor.Name = "btnNuevoProfesor";
            this.btnNuevoProfesor.Size = new System.Drawing.Size(56, 44);
            this.btnNuevoProfesor.TabIndex = 210;
            this.btnNuevoProfesor.UseVisualStyleBackColor = false;
            this.btnNuevoProfesor.Click += new System.EventHandler(this.btnNuevoProfesor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 209;
            this.label1.Text = "Nuevo Profesor:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoControlReactivos.Properties.Resources.search16_h;
            this.pictureBox3.Location = new System.Drawing.Point(345, 23);
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
            this.label18.Size = new System.Drawing.Size(146, 16);
            this.label18.TabIndex = 206;
            this.label18.Text = "Buscar por Nombre:";
            // 
            // txtBuscarProfesor
            // 
            this.txtBuscarProfesor.Location = new System.Drawing.Point(155, 25);
            this.txtBuscarProfesor.Name = "txtBuscarProfesor";
            this.txtBuscarProfesor.Size = new System.Drawing.Size(184, 21);
            this.txtBuscarProfesor.TabIndex = 207;
            this.txtBuscarProfesor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProfesor_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 42);
            this.panel1.TabIndex = 3;
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
            // dgvSeleccionarProfesor
            // 
            this.dgvSeleccionarProfesor.AllowUserToAddRows = false;
            this.dgvSeleccionarProfesor.AllowUserToDeleteRows = false;
            this.dgvSeleccionarProfesor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSeleccionarProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionarProfesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeleccionarProfesor.Location = new System.Drawing.Point(0, 62);
            this.dgvSeleccionarProfesor.Name = "dgvSeleccionarProfesor";
            this.dgvSeleccionarProfesor.ReadOnly = true;
            this.dgvSeleccionarProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionarProfesor.Size = new System.Drawing.Size(601, 370);
            this.dgvSeleccionarProfesor.TabIndex = 4;
            this.dgvSeleccionarProfesor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSeleccionarProfesor_MouseDoubleClick);
            // 
            // frmSeleccionarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(601, 474);
            this.Controls.Add(this.dgvSeleccionarProfesor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSeleccionarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Profesor";
            this.Load += new System.EventHandler(this.frmSeleccionarProfesor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionarProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevoProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBuscarProfesor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.DataGridView dgvSeleccionarProfesor;
    }
}