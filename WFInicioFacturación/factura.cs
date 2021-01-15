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
        double total=0;
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
                txtCi.Text = "";
            }
            else
            {
                txtCi.Enabled = false;
                txtCi.Text = "0000000000";
            }
        }

        private void factura_Load(object sender, EventArgs e)
        {
            txtCi.Enabled = false;
            txtCi.Text = "0000000000";
            tbcvv.Enabled = false;
            tbNumTarjeta.Enabled = false;
            int i = 0;
            while (ordenfact[i,0]!=null)
            {
                //compra += ordenfact[i, 0]+" "+ ordenfact[i, 1] + " " + ordenfact[i, 2] + " " ;
                dgvFactura.Rows.Add(ordenfact[i,0], ordenfact[i, 1], ordenfact[i, 2]);
                total += double.Parse(ordenfact[i, 2]);
                i++;
            }
            lbtotal.Text = total.ToString();
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
                tbcvv.Text = "CVV";
                tbNumTarjeta.Text = "Número de Tarjeta";
            }
            else
            {
                tbcvv.Enabled = false;
                tbNumTarjeta.Enabled = false;
                tbcvv.Text = "";
                tbNumTarjeta.Text = "";
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
                string tipoPago;
                if (rbEfectivo.Checked == true)
                {
                    tipoPago = "E";
                }
                else
                {
                    tipoPago = "T";
                }
                //MessageBox.Show("el id "+id+"\ndatos del producto "+ordenfact[0,0]+" "+ordenfact[0, 1] + " "+ ordenfact[0, 2] + " "+ ordenfact[0, 3]);
                //InsertarOrden(string _id, string _idP, string _idC, string _cant, string _sub, string _pago)
                /*for(int i=0; ordenfact[i, 3] != null; i++)
                {
                    Log.InsertarOrden(id, ordenfact[i, 3], txtCi.Text, ordenfact[i, 1], ordenfact[i, 2], tipoPago);
                    //MessageBox.Show("Prodcuto "+i+" registrado.", "Listo");
                    i++;
                    //Task.Delay(500).Wait();
                }*/
                int i = 0;
                int ind = 0;
                while (ordenfact[i, 3] != null)
                {
                    //int id = Log.NuevaOrden();
                    //Task.Delay(1000).Wait();
                    //MessageBox.Show("Prodcuto " + i + " registrado. id " + id+" idp "+ ordenfact[ind, 3] + " " + txtCi.Text + " " + ordenfact[i, 1] + " " + ordenfact[i, 2] + " " + tipoPago, "Listo");
                    Log.InsertarOrden(id, ordenfact[ind, 3], txtCi.Text, ordenfact[i, 1], ordenfact[i, 2], tipoPago);
                    //Task.Delay(1000).Wait();
                    //MessageBox.Show("Prodcuto "+i+" registrado.", "Listo");
                    ind++;
                    i++;
                }
                MessageBox.Show("Orden registrada exitosamente.", "Listo");
                this.Close();
                Form1 o = new Form1();
                o.Show();

            }
            catch(Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error :(.", "Lo sentimos");
                Console.WriteLine("Error-> "+exc); 
            }
            //Log.InsertarOrden(string _id, string _idP, string _idC, string _cant, string _sub, string _pago);
            
        }

        private void rbConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void tbNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void tbcvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {
            if(txtCi.TextLength == 10)
            {
                DataTable tabla = new DataTable();
                tabla = Log.MostrarDatosCliente(txtCi.Text);
                lbNombre.Text = tabla.Rows[0][2].ToString() + " " + tabla.Rows[0][3].ToString();
            }
        }
    }
}
