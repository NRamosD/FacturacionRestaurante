
namespace WFInicioFacturación
{
    partial class Reporte2
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
            this.GananciasPorFechasViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GananciasPorFechasViewTableAdapter = new WFInicioFacturación.DataSetBDTableAdapters.GananciasPorFechasViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciasPorFechasViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GananciasPorFechasViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFInicioFacturación.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(154, 57);
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
            // GananciasPorFechasViewBindingSource
            // 
            this.GananciasPorFechasViewBindingSource.DataMember = "GananciasPorFechasView";
            this.GananciasPorFechasViewBindingSource.DataSource = this.DataSetBD;
            // 
            // GananciasPorFechasViewTableAdapter
            // 
            this.GananciasPorFechasViewTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte2";
            this.Text = "Reporte2";
            this.Load += new System.EventHandler(this.Reporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciasPorFechasViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GananciasPorFechasViewBindingSource;
        private DataSetBD DataSetBD;
        private DataSetBDTableAdapters.GananciasPorFechasViewTableAdapter GananciasPorFechasViewTableAdapter;
    }
}