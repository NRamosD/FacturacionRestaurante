using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicioFacturación
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnReporte5_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            Reporte5 frAbrir = new Reporte5();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            Reporte1 frAbrir = new Reporte1();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {

            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            Reporte2 frAbrir = new Reporte2();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            Reporte3 frAbrir = new Reporte3();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            Reporte4 frAbrir = new Reporte4();
            frAbrir.TopLevel = false;
            frAbrir.FormBorderStyle = FormBorderStyle.None;
            frAbrir.Dock = DockStyle.Fill;
            this.pForms.Controls.Add(frAbrir);
            frAbrir.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pForms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
