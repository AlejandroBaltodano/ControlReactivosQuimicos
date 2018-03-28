namespace ProyectoControlReactivos
{
    partial class ReporteReactivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteReactivos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReactivos = new ProyectoControlReactivos.DataSetReactivos();
            this.Tabla_Reactivo_InventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabla_Reactivo_InventarioTableAdapter = new ProyectoControlReactivos.DataSetReactivosTableAdapters.Tabla_Reactivo_InventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Reactivo_InventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tabla_Reactivo_InventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoControlReactivos.ReportMovimientoInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(952, 472);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReactivos
            // 
            this.DataSetReactivos.DataSetName = "DataSetReactivos";
            this.DataSetReactivos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tabla_Reactivo_InventarioBindingSource
            // 
            this.Tabla_Reactivo_InventarioBindingSource.DataMember = "Tabla_Reactivo_Inventario";
            this.Tabla_Reactivo_InventarioBindingSource.DataSource = this.DataSetReactivos;
            // 
            // Tabla_Reactivo_InventarioTableAdapter
            // 
            this.Tabla_Reactivo_InventarioTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteReactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 472);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteReactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Reactivos";
            this.Load += new System.EventHandler(this.ReporteDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Reactivo_InventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tabla_Reactivo_InventarioBindingSource;
        private DataSetReactivos DataSetReactivos;
        private DataSetReactivosTableAdapters.Tabla_Reactivo_InventarioTableAdapter Tabla_Reactivo_InventarioTableAdapter;
    }
}