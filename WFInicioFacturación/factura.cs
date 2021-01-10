using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace WFInicioFacturación
{
    public partial class factura : Form
    {
        string[,] ordenfact;
        string compra = "";
        OperacionesLogicas Log = new OperacionesLogicas();
        public factura(string [,] orden)
        {
            InitializeComponent();
            ordenfact = orden;
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
            int i = 0;
            while (ordenfact[i,0]!=null)
            {
                //compra += ordenfact[i, 0]+" "+ ordenfact[i, 1] + " " + ordenfact[i, 2] + " " ;
                dgvFactura.Rows.Add(ordenfact[i,0], ordenfact[i, 1], ordenfact[i, 2]);
                i++;
            }
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
            try
            {
                
                int id = Log.NuevaOrden();
                //Log.InsertarOrden(id, compra, txtCi.Text, ordenfact[i, 1], string _sub, string _pago);

                MessageBox.Show("Orden registrada exitosamente.", "Listo");
            }
            catch(Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error :(.", "Lo sentimos");
            }
            //Log.InsertarOrden(string _id, string _idP, string _idC, string _cant, string _sub, string _pago);
            this.Close();
            Form1 o = new Form1();
            o.Show();
        }
    }
}
