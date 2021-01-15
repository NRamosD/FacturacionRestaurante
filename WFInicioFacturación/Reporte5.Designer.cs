
namespace WFInicioFacturación
{
    partial class Reporte5
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetBD = new WFInicioFacturación.DataSetBD();
            this.ClientesMayoresComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesMayoresComprasTableAdapter = new WFInicioFacturación.DataSetBDTableAdapters.ClientesMayoresComprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesMayoresComprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientesMayoresComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFInicioFacturación.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(96, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetBD
            // 
            this.DataSetBD.DataSetName = "DataSetBD";
            this.DataSetBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesMayoresComprasBindingSource
            // 
            this.ClientesMayoresComprasBindingSource.DataMember = "ClientesMayoresCompras";
            this.ClientesMayoresComprasBindingSource.DataSource = this.DataSetBD;
            // 
            // ClientesMayoresComprasTableAdapter
            // 
            this.ClientesMayoresComprasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte5";
            this.Text = "Reporte5";
            this.Load += new System.EventHandler(this.Reporte5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesMayoresComprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientesMayoresComprasBindingSource;
        private DataSetBD DataSetBD;
        private DataSetBDTableAdapters.ClientesMayoresComprasTableAdapter ClientesMayoresComprasTableAdapter;
    }
}