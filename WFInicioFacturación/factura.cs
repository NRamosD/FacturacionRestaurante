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
    public partial class factura : Form
    {
        public factura()
        {
            InitializeComponent();
        }

        private void gbTipoCliente_Enter(object sender, EventArgs e)
        {

        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCliente.Checked == true)
            {
                txtCi.Enabled=true;
            }
            else
            {
                txtCi.Enabled = false;
            }
        }

        private void factura_Load(object sender, EventArgs e)
        {
            txtCi.Enabled = false;
            tbcvv.Enabled = false;
            tbNumTarjeta.Enabled = false;
        }

        private void gbDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked == true)
            {
                tbcvv.Enabled = true;
                tbNumTarjeta.Enabled = true;
            }
            else
            {
                tbcvv.Enabled = false;
                tbNumTarjeta.Enabled = false;
            }
        }

        private void factura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 o = new Form1();
            o.Show();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 o = new Form1();
            o.Show();
        }
    }
}
