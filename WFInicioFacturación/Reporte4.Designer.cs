
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AlimentosFechaDeterminadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBD = new WFInicioFacturación.DataSetBD();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.btnCargar = new FontAwesome.Sharp.IconButton();
            this.AlimentosFechaDeterminadaTableAdapter = new WFInicioFacturación.DataSetBDTableAdapters.AlimentosFechaDeterminadaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AlimentosFechaDeterminadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBD)).BeginInit();
            this.SuspendLayout();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txbCedula
            // 
            this.txbCedula.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCedula.ForeColor = System.Drawing.Color.DarkGray;
            this.txbCedula.Location = new System.Drawing.Point(8, 7);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(126, 23);
            this.txbCedula.TabIndex = 2;
            this.txbCedula.Text = "C.I  CLIENTE";
            this.txbCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCedula.Click += new System.EventHandler(this.txbCedula_Click);
            this.txbCedula.TextChanged += new System.EventHandler(this.txbCedula_TextChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnCargar.IconColor = System.Drawing.Color.Black;
            this.btnCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargar.IconSize = 35;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargar.Location = new System.Drawing.Point(354, 0);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(50, 38);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            this.btnCargar.MouseEnter += new System.EventHandler(this.btnCargar_MouseEnter);
            // 
            // AlimentosFechaDeterminadaTableAdapter
            // 
            this.AlimentosFechaDeterminadaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.AlimentosFechaDeterminadaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFInicioFacturación.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(411, 339);
            this.reportViewer1.TabIndex = 4;
            // 
            // Reporte4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(409, 375);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txbCedula);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox txbCedula;
        private FontAwesome.Sharp.IconButton btnCargar;
        private System.Windows.Forms.BindingSource AlimentosFechaDeterminadaBindingSource;
        private DataSetBD DataSetBD;
        private DataSetBDTableAdapters.AlimentosFechaDeterminadaTableAdapter AlimentosFechaDeterminadaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}