
namespace WFInicioFacturación
{
    partial class factura
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
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.lblCi = new System.Windows.Forms.Label();
            this.gbTipoCliente = new System.Windows.Forms.GroupBox();
            this.rbConsumidorFinal = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.gbDatosCliente.SuspendLayout();
            this.gbTipoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFactura
            // 
            this.gbFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.gbFactura.Controls.Add(this.dgvFactura);
            this.gbFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFactura.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.Location = new System.Drawing.Point(0, 125);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(634, 336);
            this.gbFactura.TabIndex = 5;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(215)))));
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactura.Location = new System.Drawing.Point(3, 26);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(628, 307);
            this.dgvFactura.TabIndex = 0;
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.gbDatosCliente.Controls.Add(this.txtCi);
            this.gbDatosCliente.Controls.Add(this.lblCi);
            this.gbDatosCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.gbDatosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatosCliente.Enabled = false;
            this.gbDatosCliente.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(0, 61);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(634, 64);
            this.gbDatosCliente.TabIndex = 3;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Información";
            // 
            // txtCi
            // 
            this.txtCi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(215)))));
            this.txtCi.Location = new System.Drawing.Point(91, 23);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(317, 30);
            this.txtCi.TabIndex = 0;
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(26, 26);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(36, 21);
            this.lblCi.TabIndex = 1;
            this.lblCi.Text = "Ci:";
            // 
            // gbTipoCliente
            // 
            this.gbTipoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.gbTipoCliente.Controls.Add(this.rbConsumidorFinal);
            this.gbTipoCliente.Controls.Add(this.rbCliente);
            this.gbTipoCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbTipoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTipoCliente.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoCliente.Location = new System.Drawing.Point(0, 0);
            this.gbTipoCliente.Name = "gbTipoCliente";
            this.gbTipoCliente.Size = new System.Drawing.Size(634, 61);
            this.gbTipoCliente.TabIndex = 4;
            this.gbTipoCliente.TabStop = false;
            this.gbTipoCliente.Text = "Tipo";
            // 
            // rbConsumidorFinal
            // 
            this.rbConsumidorFinal.AutoSize = true;
            this.rbConsumidorFinal.Checked = true;
            this.rbConsumidorFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbConsumidorFinal.Location = new System.Drawing.Point(6, 28);
            this.rbConsumidorFinal.Name = "rbConsumidorFinal";
            this.rbConsumidorFinal.Size = new System.Drawing.Size(181, 25);
            this.rbConsumidorFinal.TabIndex = 0;
            this.rbConsumidorFinal.TabStop = true;
            this.rbConsumidorFinal.Text = "Consumidor final";
            this.rbConsumidorFinal.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCliente.Location = new System.Drawing.Point(238, 28);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(93, 25);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbTipoCliente);
            this.Name = "factura";
            this.Text = "factura";
            this.gbFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbTipoCliente.ResumeLayout(false);
            this.gbTipoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.GroupBox gbTipoCliente;
        private System.Windows.Forms.RadioButton rbConsumidorFinal;
        private System.Windows.Forms.RadioButton rbCliente;
    }
}