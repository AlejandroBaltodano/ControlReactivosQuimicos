namespace ProyectoControlReactivos
{
    partial class frmMovimientoInventarioSolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientoInventarioSolucion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewMovimientosSolucion = new System.Windows.Forms.DataGridView();
            this.txtNombreSolucion = new System.Windows.Forms.TextBox();
            this.dataGridViewSoluciones = new System.Windows.Forms.DataGridView();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.cmbNombreProfesor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDetalleMovimiento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labael = new System.Windows.Forms.Label();
            this.txtCantidadDelMovimiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblUnidadAlmacenamiento = new System.Windows.Forms.Label();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.txtBuscarPorProfesor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBuscarPorNombreMovimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImprimirMovimiento = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientosSolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-199, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 185;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 401);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(616, 15);
            this.label14.TabIndex = 184;
            this.label14.Text = "_________________________________________________________________________________" +
    "______";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(410, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 183;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(363, 162);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(134, 23);
            this.cmbTipoMovimiento.TabIndex = 181;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 180;
            this.label13.Text = "Selecionar tipo:";
            // 
            // dataGridViewMovimientosSolucion
            // 
            this.dataGridViewMovimientosSolucion.AllowUserToAddRows = false;
            this.dataGridViewMovimientosSolucion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMovimientosSolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimientosSolucion.Location = new System.Drawing.Point(623, 388);
            this.dataGridViewMovimientosSolucion.Name = "dataGridViewMovimientosSolucion";
            this.dataGridViewMovimientosSolucion.ReadOnly = true;
            this.dataGridViewMovimientosSolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovimientosSolucion.Size = new System.Drawing.Size(724, 217);
            this.dataGridViewMovimientosSolucion.TabIndex = 177;
            // 
            // txtNombreSolucion
            // 
            this.txtNombreSolucion.Enabled = false;
            this.txtNombreSolucion.Location = new System.Drawing.Point(363, 100);
            this.txtNombreSolucion.Name = "txtNombreSolucion";
            this.txtNombreSolucion.Size = new System.Drawing.Size(134, 21);
            this.txtNombreSolucion.TabIndex = 176;
            // 
            // dataGridViewSoluciones
            // 
            this.dataGridViewSoluciones.AllowUserToAddRows = false;
            this.dataGridViewSoluciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoluciones.Location = new System.Drawing.Point(622, 86);
            this.dataGridViewSoluciones.Name = "dataGridViewSoluciones";
            this.dataGridViewSoluciones.ReadOnly = true;
            this.dataGridViewSoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSoluciones.Size = new System.Drawing.Size(724, 224);
            this.dataGridViewSoluciones.TabIndex = 175;
            this.dataGridViewSoluciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSoluciones_MouseDoubleClick);
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarMovimiento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAgregarMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovimiento.Image = global::ProyectoControlReactivos.Properties.Resources.add;
            this.btnAgregarMovimiento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(329, 437);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(75, 27);
            this.btnAgregarMovimiento.TabIndex = 174;
            this.btnAgregarMovimiento.Text = "Agregar";
            this.btnAgregarMovimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregarMovimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarMovimiento.UseVisualStyleBackColor = false;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // cmbNombreProfesor
            // 
            this.cmbNombreProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreProfesor.FormattingEnabled = true;
            this.cmbNombreProfesor.Location = new System.Drawing.Point(363, 262);
            this.cmbNombreProfesor.Name = "cmbNombreProfesor";
            this.cmbNombreProfesor.Size = new System.Drawing.Size(134, 23);
            this.cmbNombreProfesor.TabIndex = 173;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 172;
            this.label11.Text = "Profesor :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 171;
            this.label10.Text = "Datos del Profesor:";
            // 
            // txtDetalleMovimiento
            // 
            this.txtDetalleMovimiento.Location = new System.Drawing.Point(222, 323);
            this.txtDetalleMovimiento.Multiline = true;
            this.txtDetalleMovimiento.Name = "txtDetalleMovimiento";
            this.txtDetalleMovimiento.Size = new System.Drawing.Size(275, 75);
            this.txtDetalleMovimiento.TabIndex = 170;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 169;
            this.label9.Text = "Detalle Movimiento:";
            // 
            // labael
            // 
            this.labael.AutoSize = true;
            this.labael.Location = new System.Drawing.Point(221, 103);
            this.labael.Name = "labael";
            this.labael.Size = new System.Drawing.Size(136, 15);
            this.labael.TabIndex = 168;
            this.labael.Text = "Nombre de la Solución:";
            // 
            // txtCantidadDelMovimiento
            // 
            this.txtCantidadDelMovimiento.Location = new System.Drawing.Point(363, 201);
            this.txtCantidadDelMovimiento.Name = "txtCantidadDelMovimiento";
            this.txtCantidadDelMovimiento.Size = new System.Drawing.Size(134, 21);
            this.txtCantidadDelMovimiento.TabIndex = 167;
            this.txtCantidadDelMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDelMovimiento_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 15);
            this.label8.TabIndex = 166;
            this.label8.Text = "Cantidad del Movimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 165;
            this.label7.Text = "Tipo de Movimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 28);
            this.label5.TabIndex = 164;
            this.label5.Text = "Tarjeta de Movimiento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 16);
            this.label2.TabIndex = 163;
            this.label2.Text = "Buscar Solución por Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 162;
            this.label1.Text = "Datos de la Solución:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 186;
            this.pictureBox2.TabStop = false;
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(854, 62);
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(170, 21);
            this.txtBuscarPorNombre.TabIndex = 187;
            this.txtBuscarPorNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPorNombre_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(882, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 28);
            this.label3.TabIndex = 190;
            this.label3.Text = "Lista de Soluciónes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 28);
            this.label4.TabIndex = 191;
            this.label4.Text = "Movimientos de la Solución Seleccionada";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::ProyectoControlReactivos.Properties.Resources.home_brown16_h;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegresar.Location = new System.Drawing.Point(1272, 612);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 32);
            this.btnRegresar.TabIndex = 192;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblUnidadAlmacenamiento
            // 
            this.lblUnidadAlmacenamiento.AutoSize = true;
            this.lblUnidadAlmacenamiento.Location = new System.Drawing.Point(503, 204);
            this.lblUnidadAlmacenamiento.Name = "lblUnidadAlmacenamiento";
            this.lblUnidadAlmacenamiento.Size = new System.Drawing.Size(16, 15);
            this.lblUnidadAlmacenamiento.TabIndex = 193;
            this.lblUnidadAlmacenamiento.Text = "...";
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProfesor.Image = global::ProyectoControlReactivos.Properties.Resources.book_add;
            this.btnAgregarProfesor.Location = new System.Drawing.Point(506, 258);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(30, 29);
            this.btnAgregarProfesor.TabIndex = 194;
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // txtBuscarPorProfesor
            // 
            this.txtBuscarPorProfesor.Location = new System.Drawing.Point(1132, 366);
            this.txtBuscarPorProfesor.Name = "txtBuscarPorProfesor";
            this.txtBuscarPorProfesor.Size = new System.Drawing.Size(171, 21);
            this.txtBuscarPorProfesor.TabIndex = 211;
            this.txtBuscarPorProfesor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPorProfesor_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(976, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 16);
            this.label15.TabIndex = 210;
            this.label15.Text = "Buscar por Profesor:";
            // 
            // txtBuscarPorNombreMovimiento
            // 
            this.txtBuscarPorNombreMovimiento.Location = new System.Drawing.Point(799, 366);
            this.txtBuscarPorNombreMovimiento.Name = "txtBuscarPorNombreMovimiento";
            this.txtBuscarPorNombreMovimiento.Size = new System.Drawing.Size(171, 21);
            this.txtBuscarPorNombreMovimiento.TabIndex = 209;
            this.txtBuscarPorNombreMovimiento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPorNombreMovimiento_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 208;
            this.label6.Text = "Buscar por Movimiento:";
            // 
            // btnImprimirMovimiento
            // 
            this.btnImprimirMovimiento.Image = global::ProyectoControlReactivos.Properties.Resources.script_add;
            this.btnImprimirMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirMovimiento.Location = new System.Drawing.Point(622, 612);
            this.btnImprimirMovimiento.Name = "btnImprimirMovimiento";
            this.btnImprimirMovimiento.Size = new System.Drawing.Size(248, 37);
            this.btnImprimirMovimiento.TabIndex = 213;
            this.btnImprimirMovimiento.Text = "Imprimir Movimiento Seleccionado";
            this.btnImprimirMovimiento.UseVisualStyleBackColor = true;
            this.btnImprimirMovimiento.Click += new System.EventHandler(this.btnImprimirMovimiento_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoControlReactivos.Properties.Resources.search16_h;
            this.pictureBox3.Location = new System.Drawing.Point(1030, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 21);
            this.pictureBox3.TabIndex = 214;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoControlReactivos.Properties.Resources.search16_h;
            this.pictureBox4.Location = new System.Drawing.Point(1309, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 21);
            this.pictureBox4.TabIndex = 215;
            this.pictureBox4.TabStop = false;
            // 
            // frmMovimientoInventarioSolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1354, 661);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnImprimirMovimiento);
            this.Controls.Add(this.txtBuscarPorProfesor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBuscarPorNombreMovimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.lblUnidadAlmacenamiento);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscarPorNombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbTipoMovimiento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridViewMovimientosSolucion);
            this.Controls.Add(this.txtNombreSolucion);
            this.Controls.Add(this.dataGridViewSoluciones);
            this.Controls.Add(this.btnAgregarMovimiento);
            this.Controls.Add(this.cmbNombreProfesor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDetalleMovimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labael);
            this.Controls.Add(this.txtCantidadDelMovimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovimientoInventarioSolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento Inventario Solucion";
            this.Load += new System.EventHandler(this.frmMovimientoInventarioSolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientosSolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewMovimientosSolucion;
        private System.Windows.Forms.TextBox txtNombreSolucion;
        private System.Windows.Forms.DataGridView dataGridViewSoluciones;
        private System.Windows.Forms.Button btnAgregarMovimiento;
        private System.Windows.Forms.ComboBox cmbNombreProfesor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDetalleMovimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labael;
        private System.Windows.Forms.TextBox txtCantidadDelMovimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblUnidadAlmacenamiento;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.TextBox txtBuscarPorProfesor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBuscarPorNombreMovimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImprimirMovimiento;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}