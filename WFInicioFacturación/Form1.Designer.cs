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
            this.PanelOptions = new System.Windows.Forms.Panel();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnAlimentos = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.pbNuevaOrden = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbOptions = new FontAwesome.Sharp.IconPictureBox();
            this.btnAct = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevaOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).BeginInit();
            this.SuspendLayout();
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
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
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
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.BackColor = System.Drawing.Color.White;
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
            this.btnAlimentos.UseVisualStyleBackColor = false;
            this.btnAlimentos.Click += new System.EventHandler(this.btnAlimentos_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
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
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pbNuevaOrden
            // 
            this.pbNuevaOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNuevaOrden.BackColor = System.Drawing.Color.White;
            this.pbNuevaOrden.ForeColor = System.Drawing.Color.ForestGreen;
            this.pbNuevaOrden.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.pbNuevaOrden.IconColor = System.Drawing.Color.ForestGreen;
            this.pbNuevaOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbNuevaOrden.IconSize = 200;
            this.pbNuevaOrden.Location = new System.Drawing.Point(278, 46);
            this.pbNuevaOrden.Name = "pbNuevaOrden";
            this.pbNuevaOrden.Size = new System.Drawing.Size(200, 200);
            this.pbNuevaOrden.TabIndex = 3;
            this.pbNuevaOrden.TabStop = false;
            this.pbNuevaOrden.Click += new System.EventHandler(this.pbNuevaOrden_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 196);
            this.dataGridView1.TabIndex = 4;
            // 
            // pbOptions
            // 
            this.pbOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(61)))));
            this.pbOptions.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.pbOptions.IconColor = System.Drawing.Color.White;
            this.pbOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbOptions.Location = new System.Drawing.Point(2, 1);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(32, 32);
            this.pbOptions.TabIndex = 5;
            this.pbOptions.TabStop = false;
            this.pbOptions.Click += new System.EventHandler(this.pbOptions_Click);
            // 
            // btnAct
            // 
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAct.ForeColor = System.Drawing.Color.Transparent;
            this.btnAct.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnAct.IconColor = System.Drawing.Color.Black;
            this.btnAct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAct.Location = new System.Drawing.Point(645, 185);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(64, 49);
            this.btnAct.TabIndex = 6;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(61)))));
            this.panel1.Location = new System.Drawing.Point(33, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 32);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nueva Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actualizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ordenes recientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.pbOptions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbNuevaOrden);
            this.Controls.Add(this.PanelOptions);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevaOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelOptions;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnAlimentos;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconPictureBox pbNuevaOrden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox pbOptions;
        private FontAwesome.Sharp.IconButton btnAct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

