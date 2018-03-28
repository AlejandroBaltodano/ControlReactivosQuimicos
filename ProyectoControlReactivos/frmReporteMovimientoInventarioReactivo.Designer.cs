namespace ProyectoControlReactivos
{
    partial class frmReporteMovimientoInventarioReactivo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMovimientoInventarioReactivo));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReactivos = new ProyectoControlReactivos.DataSetReactivos();
            this.dataSetReactivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabla_Movimiento_InventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabla_Movimiento_InventarioTableAdapter = new ProyectoControlReactivos.DataSetReactivosTableAdapters.Tabla_Movimiento_InventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReactivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Movimiento_InventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMovimientoInventario";
            reportDataSource1.Value = this.Tabla_Movimiento_InventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoControlReactivos.ReportMovimientoInventarioReactivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(654, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetReactivos
            // 
            this.dataSetReactivos.DataSetName = "DataSetReactivos";
            this.dataSetReactivos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetReactivosBindingSource
            // 
            this.dataSetReactivosBindingSource.DataSource = this.dataSetReactivos;
            this.dataSetReactivosBindingSource.Position = 0;
            // 
            // Tabla_Movimiento_InventarioBindingSource
            // 
            this.Tabla_Movimiento_InventarioBindingSource.DataMember = "Tabla_Movimiento_Inventario";
            this.Tabla_Movimiento_InventarioBindingSource.DataSource = this.dataSetReactivos;
            // 
            // Tabla_Movimiento_InventarioTableAdapter
            // 
            this.Tabla_Movimiento_InventarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteMovimientoInventarioReactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 343);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteMovimientoInventarioReactivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Movimiento Inventario Reactivo";
            this.Load += new System.EventHandler(this.frmReporteMovimientoInventarioReactivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReactivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Movimiento_InventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetReactivosBindingSource;
        private DataSetReactivos dataSetReactivos;
        private System.Windows.Forms.BindingSource Tabla_Movimiento_InventarioBindingSource;
        private DataSetReactivosTableAdapters.Tabla_Movimiento_InventarioTableAdapter Tabla_Movimiento_InventarioTableAdapter;
    }
}