﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte5));
            this.ClientesMayoresComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBD = new WFInicioFacturación.DataSetBD();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientesMayoresComprasTableAdapter = new WFInicioFacturación.DataSetBDTableAdapters.ClientesMayoresComprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesMayoresComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesMayoresComprasBindingSource
            // 
            this.ClientesMayoresComprasBindingSource.DataMember = "ClientesMayoresCompras";
            this.ClientesMayoresComprasBindingSource.DataSource = this.DataSetBD;
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
            reportDataSource1.Value = this.ClientesMayoresComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFInicioFacturación.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(575, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientesMayoresComprasTableAdapter
            // 
            this.ClientesMayoresComprasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 416);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte5";
            this.Text = "Reporte5";
            this.Load += new System.EventHandler(this.Reporte5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesMayoresComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientesMayoresComprasBindingSource;
        private DataSetBD DataSetBD;
        private DataSetBDTableAdapters.ClientesMayoresComprasTableAdapter ClientesMayoresComprasTableAdapter;
    }
}