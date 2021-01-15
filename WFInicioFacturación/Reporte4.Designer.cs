
namespace WFInicioFacturación
{
    partial class Reporte4
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCargar = new FontAwesome.Sharp.IconButton();
            this.AlimentosFechaDeterminadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBD = new WFInicioFacturación.DataSetBD();
            this.AlimentosFechaDeterminadaTableAdapter = new WFInicioFacturación.DataSetBDTableAdapters.AlimentosFechaDeterminadaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AlimentosFechaDeterminadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCargar.IconColor = System.Drawing.Color.Black;
            this.btnCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargar.Location = new System.Drawing.Point(521, 41);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "iconButton1";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // AlimentosFechaDeterminadaBindingSource
            // 
            this.AlimentosFechaDeterminadaBindingSource.DataMember = "AlimentosFechaDeterminada";
            this.AlimentosFechaDeterminadaBindingSource.DataSource = this.DataSetBD;
            // 
            // DataSetBD
            // 
            this.DataSetBD.DataSetName = "DataSetBD";
            this.DataSetBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlimentosFechaDeterminadaTableAdapter
            // 
            this.AlimentosFechaDeterminadaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AlimentosFechaDeterminadaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFInicioFacturación.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(516, 246);
            this.reportViewer1.TabIndex = 4;
            // 
            // Reporte4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Reporte4";
            this.Text = "Reporte4";
            this.Load += new System.EventHandler(this.Reporte4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlimentosFechaDeterminadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnCargar;
        private System.Windows.Forms.BindingSource AlimentosFechaDeterminadaBindingSource;
        private DataSetBD DataSetBD;
        private DataSetBDTableAdapters.AlimentosFechaDeterminadaTableAdapter AlimentosFechaDeterminadaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}