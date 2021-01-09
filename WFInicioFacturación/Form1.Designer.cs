namespace WFInicioFacturación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelOptions = new System.Windows.Forms.Panel();
            this.pbNuevaOrden = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnAlimentos = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.pbOptions = new FontAwesome.Sharp.IconPictureBox();
            this.PanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevaOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PanelOptions
            // 
            this.PanelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(61)))));
            this.PanelOptions.Controls.Add(this.btnReportes);
            this.PanelOptions.Controls.Add(this.btnAlimentos);
            this.PanelOptions.Controls.Add(this.btnCliente);
            this.PanelOptions.Location = new System.Drawing.Point(2, 33);
            this.PanelOptions.Name = "PanelOptions";
            this.PanelOptions.Size = new System.Drawing.Size(152, 189);
            this.PanelOptions.TabIndex = 2;
            // 
            // pbNuevaOrden
            // 
            this.pbNuevaOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNuevaOrden.BackColor = System.Drawing.Color.White;
            this.pbNuevaOrden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbNuevaOrden.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.pbNuevaOrden.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbNuevaOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbNuevaOrden.IconSize = 200;
            this.pbNuevaOrden.Location = new System.Drawing.Point(271, 28);
            this.pbNuevaOrden.Name = "pbNuevaOrden";
            this.pbNuevaOrden.Size = new System.Drawing.Size(200, 200);
            this.pbNuevaOrden.TabIndex = 3;
            this.pbNuevaOrden.TabStop = false;
            this.pbNuevaOrden.Click += new System.EventHandler(this.pbNuevaOrden_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 196);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnCliente
            // 
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnCliente.IconColor = System.Drawing.Color.Black;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.IconSize = 25;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(9, 13);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(131, 52);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnAlimentos.IconColor = System.Drawing.Color.Black;
            this.btnAlimentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlimentos.IconSize = 25;
            this.btnAlimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlimentos.Location = new System.Drawing.Point(9, 71);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Size = new System.Drawing.Size(131, 52);
            this.btnAlimentos.TabIndex = 1;
            this.btnAlimentos.Text = "Alimentos";
            this.btnAlimentos.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnReportes.IconColor = System.Drawing.Color.Black;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 25;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(9, 129);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(131, 52);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // pbOptions
            // 
            this.pbOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(61)))));
            this.pbOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbOptions.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.pbOptions.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbOptions.Location = new System.Drawing.Point(2, 1);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(32, 32);
            this.pbOptions.TabIndex = 5;
            this.pbOptions.TabStop = false;
            this.pbOptions.Click += new System.EventHandler(this.pbOptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pbOptions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbNuevaOrden);
            this.Controls.Add(this.PanelOptions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevaOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PanelOptions;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnAlimentos;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconPictureBox pbNuevaOrden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox pbOptions;
    }
}

