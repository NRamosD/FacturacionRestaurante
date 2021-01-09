using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFInicioFacturación
{
    public partial class Cliente : WFInicioFacturación.Form1
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            AddCliente frAbrir = new AddCliente();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            Buscar_Visualizar frAbrir = new Buscar_Visualizar();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            ModifyCliente frAbrir = new ModifyCliente();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            DeleteCliente frAbrir = new DeleteCliente();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }
    }
}
