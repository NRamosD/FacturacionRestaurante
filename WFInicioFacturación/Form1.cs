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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelOptions.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSelec sas = new FrmSelec();
            sas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cl = new Cliente();
            cl.Show();
        }

        private void pbNuevaOrden_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSelec obj = new FrmSelec();
            obj.Show();
        }

        private void pbOptions_Click(object sender, EventArgs e)
        {
            if (PanelOptions.Visible == false)
            {
                PanelOptions.Visible = true;
            }
            else
            {
                PanelOptions.Visible = false;
            }
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Producto O = new Producto();
            O.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
