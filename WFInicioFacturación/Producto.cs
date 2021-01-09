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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.pForms.Controls.Count > 0)
                this.pForms.Controls.RemoveAt(0);
            AddProducto frAbrir = new AddProducto();
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
            Buscar_Prod frAbrir = new Buscar_Prod();
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
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
