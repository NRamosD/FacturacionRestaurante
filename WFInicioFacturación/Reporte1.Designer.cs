namespace WFInicioFacturación
{
    partial class Reporte1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte1));
            this.ReporteConsumoClienteViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBD = new WFInicioFacturación.DataSetBD();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteConsumoClienteViewTableAdapter = new WFInicioFacturación.DataSetBDTableAdapters.ReporteConsumoClienteViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteConsumoClienteViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteConsumoClienteViewBindingSource
            // 
            this.ReporteConsumoClienteViewBindingSource.DataMember = "ReporteConsumoClienteView";
            this.ReporteConsumoClienteViewBindingSource.DataSource = this.DataSetBD;
            // 
            // DataSetBD
            // 
            this.DataSetBD.DataSetName = "DataSetBD";
            this.DataSetBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteConsumoClienteViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFInicioFacturación.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(409, 375);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteConsumoClienteViewTableAdapter
            // 
            this.ReporteConsumoClienteViewTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 375);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte1";
            this.Text = "Reporte1";
            this.Load += new System.EventHandler(this.Reporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteConsumoClienteViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteConsumoClienteViewBindingSource;
        private DataSetBD DataSetBD;
        private DataSetBDTableAdapters.ReporteConsumoClienteViewTableAdapter ReporteConsumoClienteViewTableAdapter;
    }
}