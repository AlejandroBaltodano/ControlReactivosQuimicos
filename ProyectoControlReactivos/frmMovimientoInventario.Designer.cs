namespace ProyectoControlReactivos
{
    partial class frmMovimientoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientoInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarPorCodigo = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadDelMovimiento = new System.Windows.Forms.TextBox();
            this.labael = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDetalleMovimiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbNombreProfesor = new System.Windows.Forms.ComboBox();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.dataGridViewReactivos = new System.Windows.Forms.DataGridView();
            this.txtCodigoReactivo = new System.Windows.Forms.TextBox();
            this.dataGridViewMovimientosDelReactivo = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lblUnidadAlmacemaniento = new System.Windows.Forms.Label();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegregar = new System.Windows.Forms.Button();
            this.txtBuscarporNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnImprimirMovimiento = new System.Windows.Forms.Button();
            this.txtBuscarPorNombreMovimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarPorProfesor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientosDelReactivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Datos del Reactivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(891, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 28);
            this.label3.TabIndex = 64;
            this.label3.Text = "Lista de Reactivos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Buscar por CAS:";
            // 
            // txtBuscarPorCodigo
            // 
            this.txtBuscarPorCodigo.Location = new System.Drawing.Point(703, 72);
            this.txtBuscarPorCodigo.Name = "txtBuscarPorCodigo";
            this.txtBuscarPorCodigo.Size = new System.Drawing.Size(171, 21);
            this.txtBuscarPorCodigo.TabIndex = 67;
            this.txtBuscarPorCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoReactivo_KeyPress);
            this.txtBuscarPorCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPorCodigo_KeyUp);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegresar.Location = new System.Drawing.Point(1430, 653);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(87, 27);
            this.btnRegresar.TabIndex = 62;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 28);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tarjeta de Movimiento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tipo de Movimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 15);
            this.label8.TabIndex = 80;
            this.label8.Text = "Cantidad del Movimiento:";
            // 
            // txtCantidadDelMovimiento
            // 
            this.txtCantidadDelMovimiento.Location = new System.Drawing.Point(365, 218);
            this.txtCantidadDelMovimiento.Name = "txtCantidadDelMovimiento";
            this.txtCantidadDelMovimiento.Size = new System.Drawing.Size(156, 21);
            this.txtCantidadDelMovimiento.TabIndex = 81;
            this.txtCantidadDelMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDelMovimiento_KeyPress);
            // 
            // labael
            // 
            this.labael.AutoSize = true;
            this.labael.Location = new System.Drawing.Point(197, 105);
            this.labael.Name = "labael";
            this.labael.Size = new System.Drawing.Size(153, 15);
            this.labael.TabIndex = 83;
            this.labael.Text = "Codigo del Reactivo (CAS):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Detalle Movimiento:";
            // 
            // txtDetalleMovimiento
            // 
            this.txtDetalleMovimiento.Location = new System.Drawing.Point(200, 377);
            this.txtDetalleMovimiento.Multiline = true;
            this.txtDetalleMovimiento.Name = "txtDetalleMovimiento";
            this.txtDetalleMovimiento.Size = new System.Drawing.Size(320, 86);
            this.txtDetalleMovimiento.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Datos del Profesor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 88;
            this.label11.Text = "Profesor :";
            // 
            // cmbNombreProfesor
            // 
            this.cmbNombreProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreProfesor.FormattingEnabled = true;
            this.cmbNombreProfesor.Location = new System.Drawing.Point(365, 294);
            this.cmbNombreProfesor.Name = "cmbNombreProfesor";
            this.cmbNombreProfesor.Size = new System.Drawing.Size(156, 23);
            this.cmbNombreProfesor.TabIndex = 89;
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarMovimiento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAgregarMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovimiento.Image = global::ProyectoControlReactivos.Properties.Resources.add;
            this.btnAgregarMovimiento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(325, 486);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(87, 31);
            this.btnAgregarMovimiento.TabIndex = 90;
            this.btnAgregarMovimiento.Text = "Agregar";
            this.btnAgregarMovimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregarMovimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarMovimiento.UseVisualStyleBackColor = false;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // dataGridViewReactivos
            // 
            this.dataGridViewReactivos.AllowUserToAddRows = false;
            this.dataGridViewReactivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReactivos.Location = new System.Drawing.Point(579, 99);
            this.dataGridViewReactivos.Name = "dataGridViewReactivos";
            this.dataGridViewReactivos.ReadOnly = true;
            this.dataGridViewReactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReactivos.Size = new System.Drawing.Size(713, 223);
            this.dataGridViewReactivos.TabIndex = 140;
            this.dataGridViewReactivos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewReactivos_MouseDoubleClick);
            // 
            // txtCodigoReactivo
            // 
            this.txtCodigoReactivo.Enabled = false;
            this.txtCodigoReactivo.Location = new System.Drawing.Point(365, 102);
            this.txtCodigoReactivo.Name = "txtCodigoReactivo";
            this.txtCodigoReactivo.Size = new System.Drawing.Size(156, 21);
            this.txtCodigoReactivo.TabIndex = 152;
            this.txtCodigoReactivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoReactivo_KeyPress);
            // 
            // dataGridViewMovimientosDelReactivo
            // 
            this.dataGridViewMovimientosDelReactivo.AllowUserToAddRows = false;
            this.dataGridViewMovimientosDelReactivo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMovimientosDelReactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimientosDelReactivo.Location = new System.Drawing.Point(579, 402);
            this.dataGridViewMovimientosDelReactivo.Name = "dataGridViewMovimientosDelReactivo";
            this.dataGridViewMovimientosDelReactivo.ReadOnly = true;
            this.dataGridViewMovimientosDelReactivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovimientosDelReactivo.Size = new System.Drawing.Size(713, 239);
            this.dataGridViewMovimientosDelReactivo.TabIndex = 153;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 156;
            this.label13.Text = "Selecionar tipo:";
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(365, 173);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(156, 23);
            this.cmbTipoMovimiento.TabIndex = 157;
            // 
            // lblUnidadAlmacemaniento
            // 
            this.lblUnidadAlmacemaniento.AutoSize = true;
            this.lblUnidadAlmacemaniento.Location = new System.Drawing.Point(528, 222);
            this.lblUnidadAlmacemaniento.Name = "lblUnidadAlmacemaniento";
            this.lblUnidadAlmacemaniento.Size = new System.Drawing.Size(19, 15);
            this.lblUnidadAlmacemaniento.TabIndex = 158;
            this.lblUnidadAlmacemaniento.Text = "....";
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarUsuario.Image")));
            this.btnCancelarUsuario.Location = new System.Drawing.Point(420, 486);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(101, 31);
            this.btnCancelarUsuario.TabIndex = 159;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.btnCancelarUsuario_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(329, 15);
            this.label14.TabIndex = 160;
            this.label14.Text = "______________________________________________";
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProfesor.Image = global::ProyectoControlReactivos.Properties.Resources.book_add;
            this.btnAgregarProfesor.Location = new System.Drawing.Point(528, 289);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(35, 33);
            this.btnAgregarProfesor.TabIndex = 195;
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(785, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 28);
            this.label6.TabIndex = 196;
            this.label6.Text = "Movimientos del Reactivo Seleccionado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegregar
            // 
            this.btnRegregar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegregar.Image = global::ProyectoControlReactivos.Properties.Resources.home_brown16_h;
            this.btnRegregar.Location = new System.Drawing.Point(1210, 653);
            this.btnRegregar.Name = "btnRegregar";
            this.btnRegregar.Size = new System.Drawing.Size(75, 23);
            this.btnRegregar.TabIndex = 197;
            this.btnRegregar.Text = "Regresar";
            this.btnRegregar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRegregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegregar.UseVisualStyleBackColor = false;
            this.btnRegregar.Click += new System.EventHandler(this.btnRegregar_Click);
            // 
            // txtBuscarporNombre
            // 
            this.txtBuscarporNombre.Location = new System.Drawing.Point(1035, 72);
            this.txtBuscarporNombre.Name = "txtBuscarporNombre";
            this.txtBuscarporNombre.Size = new System.Drawing.Size(171, 21);
            this.txtBuscarporNombre.TabIndex = 199;
            this.txtBuscarporNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarporNombre_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(883, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 198;
            this.label12.Text = "Buscar por Nombre:";
            // 
            // btnImprimirMovimiento
            // 
            this.btnImprimirMovimiento.Image = global::ProyectoControlReactivos.Properties.Resources.script_add;
            this.btnImprimirMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirMovimiento.Location = new System.Drawing.Point(579, 647);
            this.btnImprimirMovimiento.Name = "btnImprimirMovimiento";
            this.btnImprimirMovimiento.Size = new System.Drawing.Size(248, 37);
            this.btnImprimirMovimiento.TabIndex = 200;
            this.btnImprimirMovimiento.Text = "Imprimir Movimiento Seleccionado";
            this.btnImprimirMovimiento.UseVisualStyleBackColor = true;
            this.btnImprimirMovimiento.Click += new System.EventHandler(this.btnImprimirMovimiento_Click);
            // 
            // txtBuscarPorNombreMovimiento
            // 
            this.txtBuscarPorNombreMovimiento.Location = new System.Drawing.Point(756, 377);
            this.txtBuscarPorNombreMovimiento.Name = "txtBuscarPorNombreMovimiento";
            this.txtBuscarPorNombreMovimiento.Size = new System.Drawing.Size(171, 21);
            this.txtBuscarPorNombreMovimiento.TabIndex = 203;
            this.txtBuscarPorNombreMovimiento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPorNombreMovimiento_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 202;
            this.label4.Text = "Buscar por Movimiento:";
            // 
            // txtBuscarPorProfesor
            // 
            this.txtBuscarPorProfesor.Location = new System.Drawing.Point(1089, 377);
            this.txtBuscarPorProfesor.Name = "txtBuscarPorProfesor";
            this.txtBuscarPorProfesor.Size = new System.Drawing.Size(171, 21);
            this.txtBuscarPorProfesor.TabIndex = 205;
            this.txtBuscarPorProfesor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPorProfesor_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(933, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 16);
            this.label15.TabIndex = 204;
            this.label15.Text = "Buscar por Profesor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoControlReactivos.Properties.Resources.Education_18_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 208;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoControlReactivos.Properties.Resources.search16_h;
            this.pictureBox3.Location = new System.Drawing.Point(1212, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 21);
            this.pictureBox3.TabIndex = 209;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoControlReactivos.Properties.Resources.search16_h;
            this.pictureBox2.Location = new System.Drawing.Point(1265, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 21);
            this.pictureBox2.TabIndex = 210;
            this.pictureBox2.TabStop = false;
            // 
            // frmMovimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1301, 688);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarPorProfesor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBuscarPorNombreMovimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImprimirMovimiento);
            this.Controls.Add(this.txtBuscarporNombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRegregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.lblUnidadAlmacemaniento);
            this.Controls.Add(this.cmbTipoMovimiento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridViewMovimientosDelReactivo);
            this.Controls.Add(this.txtCodigoReactivo);
            this.Controls.Add(this.dataGridViewReactivos);
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
            this.Controls.Add(this.txtBuscarPorCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovimientoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento Inventario";
            this.Load += new System.EventHandler(this.frmMovimientoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientosDelReactivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarPorCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadDelMovimiento;
        private System.Windows.Forms.Label labael;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDetalleMovimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbNombreProfesor;
        private System.Windows.Forms.Button btnAgregarMovimiento;
        private System.Windows.Forms.DataGridView dataGridViewReactivos;
        private System.Windows.Forms.TextBox txtCodigoReactivo;
        private System.Windows.Forms.DataGridView dataGridViewMovimientosDelReactivo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.Label lblUnidadAlmacemaniento;
        private System.Windows.Forms.Button btnCancelarUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegregar;
        private System.Windows.Forms.TextBox txtBuscarporNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnImprimirMovimiento;
        private System.Windows.Forms.TextBox txtBuscarPorNombreMovimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarPorProfesor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}