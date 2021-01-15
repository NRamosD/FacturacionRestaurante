
namespace WFInicioFacturación
{
    partial class Reporte3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte3));
            this.AlimentosMasVendidosViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBD = new WFInicioFacturación.DataSetBD();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlimentosMasVendidosViewTableAdapter = new WFInicioFacturación.DataSetBDTableAdapters.AlimentosMasVendidosViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AlimentosMasVendidosViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).BeginInit();
            this.SuspendLayout();
            // 
            // AlimentosMasVendidosViewBindingSource
            // 
            this.AlimentosMasVendidosViewBindingSource.DataMember = "AlimentosMasVendidosView";
            this.AlimentosMasVendidosViewBindingSource.DataSource = this.DataSetBD;
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
            reportDataSource1.Value = this.AlimentosMasVendidosViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFInicioFacturación.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(409, 375);
            this.reportViewer1.TabIndex = 0;
            // 
            // AlimentosMasVendidosViewTableAdapter
            // 
            this.AlimentosMasVendidosViewTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 375);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte3";
            this.Text = "Reporte3";
            this.Load += new System.EventHandler(this.Reporte3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlimentosMasVendidosViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlimentosMasVendidosViewBindingSource;
        private DataSetBD DataSetBD;
        private DataSetBDTableAdapters.AlimentosMasVendidosViewTableAdapter AlimentosMasVendidosViewTableAdapter;
    }
}