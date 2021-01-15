namespace WFInicioFacturación
{
    partial class Cliente
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
            this.pBotones = new System.Windows.Forms.Panel();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnLeer = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.pClose = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBotones.SuspendLayout();
            this.pClose.SuspendLayout();
            this.pForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(85)))));
            this.pBotones.Controls.Add(this.btnBorrar);
            this.pBotones.Controls.Add(this.btnModificar);
            this.pBotones.Controls.Add(this.btnLeer);
            this.pBotones.Controls.Add(this.btnAgregar);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBotones.Location = new System.Drawing.Point(0, 0);
            this.pBotones.Margin = new System.Windows.Forms.Padding(2);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(178, 437);
            this.pBotones.TabIndex = 1;
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(171)))), ((int)(((byte)(101)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnBorrar.IconColor = System.Drawing.Color.White;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBorrar.Location = new System.Drawing.Point(10, 332);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(159, 48);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(171)))), ((int)(((byte)(101)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModificar.Location = new System.Drawing.Point(9, 241);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 47);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.FlatAppearance.BorderSize = 0;
            this.btnLeer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(171)))), ((int)(((byte)(101)))));
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.Color.White;
            this.btnLeer.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnLeer.IconColor = System.Drawing.Color.White;
            this.btnLeer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLeer.Location = new System.Drawing.Point(6, 155);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(147, 48);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Buscar";
            this.btnLeer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(171)))), ((int)(((byte)(101)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregar.Location = new System.Drawing.Point(12, 70);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 47);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pClose
            // 
            this.pClose.BackColor = System.Drawing.Color.White;
            this.pClose.Controls.Add(this.iconButton1);
            this.pClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pClose.Location = new System.Drawing.Point(178, 0);
            this.pClose.Margin = new System.Windows.Forms.Padding(2);
            this.pClose.Name = "pClose";
            this.pClose.Size = new System.Drawing.Size(478, 33);
            this.pClose.TabIndex = 7;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(439, 4);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(31, 31);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pForms
            // 
            this.pForms.Controls.Add(this.pictureBox1);
            this.pForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pForms.Location = new System.Drawing.Point(178, 33);
            this.pForms.Margin = new System.Windows.Forms.Padding(2);
            this.pForms.Name = "pForms";
            this.pForms.Size = new System.Drawing.Size(478, 404);
            this.pForms.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFInicioFacturación.Properties.Resources.Recurso_2_4x;
            this.pictureBox1.Location = new System.Drawing.Point(104, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(656, 437);
            this.Controls.Add(this.pForms);
            this.Controls.Add(this.pClose);
            this.Controls.Add(this.pBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cliente";
            this.Controls.SetChildIndex(this.pBotones, 0);
            this.Controls.SetChildIndex(this.pClose, 0);
            this.Controls.SetChildIndex(this.pForms, 0);
            this.pBotones.ResumeLayout(false);
            this.pClose.ResumeLayout(false);
            this.pForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBotones;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnLeer;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.Panel pClose;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pForms;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
