
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.lblCi = new System.Windows.Forms.Label();
            this.gbTipoCliente = new System.Windows.Forms.GroupBox();
            this.rbConsumidorFinal = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNumTarjeta = new System.Windows.Forms.TextBox();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.tbcvv = new System.Windows.Forms.TextBox();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.gbDatosCliente.SuspendLayout();
            this.gbTipoCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFactura
            // 
            this.gbFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.gbFactura.Controls.Add(this.dgvFactura);
            this.gbFactura.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.Location = new System.Drawing.Point(0, 211);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(768, 264);
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
            this.dgvFactura.Size = new System.Drawing.Size(762, 235);
            this.dgvFactura.TabIndex = 0;
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.gbDatosCliente.Controls.Add(this.lbNombre);
            this.gbDatosCliente.Controls.Add(this.txtCi);
            this.gbDatosCliente.Controls.Add(this.lblCi);
            this.gbDatosCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.gbDatosCliente.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(12, 73);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(343, 140);
            this.gbDatosCliente.TabIndex = 3;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Información";
            this.gbDatosCliente.Enter += new System.EventHandler(this.gbDatosCliente_Enter);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(12, 83);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(82, 21);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // txtCi
            // 
            this.txtCi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(215)))));
            this.txtCi.Location = new System.Drawing.Point(54, 23);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(156, 30);
            this.txtCi.TabIndex = 0;
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(12, 26);
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
            this.gbTipoCliente.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoCliente.Location = new System.Drawing.Point(0, 0);
            this.gbTipoCliente.Name = "gbTipoCliente";
            this.gbTipoCliente.Size = new System.Drawing.Size(355, 61);
            this.gbTipoCliente.TabIndex = 4;
            this.gbTipoCliente.TabStop = false;
            this.gbTipoCliente.Text = "Tipo";
            this.gbTipoCliente.Enter += new System.EventHandler(this.gbTipoCliente_Enter);
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
            this.rbCliente.Location = new System.Drawing.Point(209, 28);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(93, 25);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total a Pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.groupBox1.Controls.Add(this.tbcvv);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbNumTarjeta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(373, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Pago";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEfectivo);
            this.groupBox2.Controls.Add(this.rbTarjeta);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método de Pago";
            // 
            // tbNumTarjeta
            // 
            this.tbNumTarjeta.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumTarjeta.Location = new System.Drawing.Point(15, 109);
            this.tbNumTarjeta.Name = "tbNumTarjeta";
            this.tbNumTarjeta.Size = new System.Drawing.Size(138, 25);
            this.tbNumTarjeta.TabIndex = 4;
            this.tbNumTarjeta.Text = "Número de tarjeta";
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEfectivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(6, 24);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(73, 20);
            this.rbEfectivo.TabIndex = 2;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTarjeta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeta.Location = new System.Drawing.Point(6, 48);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(66, 20);
            this.rbTarjeta.TabIndex = 3;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
            // 
            // tbcvv
            // 
            this.tbcvv.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcvv.Location = new System.Drawing.Point(15, 140);
            this.tbcvv.Name = "tbcvv";
            this.tbcvv.Size = new System.Drawing.Size(138, 25);
            this.tbcvv.TabIndex = 8;
            this.tbcvv.Text = "CVV";
            // 
            // factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(768, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbTipoCliente);
            this.Name = "factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "factura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.factura_FormClosed);
            this.Load += new System.EventHandler(this.factura_Load);
            this.gbFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbTipoCliente.ResumeLayout(false);
            this.gbTipoCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNumTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.TextBox tbcvv;
    }
}