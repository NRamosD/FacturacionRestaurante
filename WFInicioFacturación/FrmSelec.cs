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
using System.IO;

namespace WFInicioFacturación
{
    public partial class FrmSelec : Form
    {
        string[,] orden = new string[20,4];
        string clickid;

        int iorden = 0;
        double precioAlimento, cantidad, totalPorAlimento,acumuladorSubTotal=0;
        GroupBox AGB;
        //-------------------------------------------------
        OperacionesLogicas objA = new OperacionesLogicas();
        public FrmSelec()
        {
            InitializeComponent();
        }

        private void cBoxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidad = double.Parse(cBoxCantidad.SelectedItem.ToString());
            totalPorAlimento = precioAlimento * double.Parse(cBoxCantidad.SelectedItem.ToString());
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            factura o = new factura(orden);
            o.Show();
        }

        private void cBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void FrmSelec_Load(object sender, EventArgs e)
        {
            cBoxCantidad.SelectedIndex = 0;

            //dynamic controllers creator
            int totalProductos = objA.ObterTotalProd()+1;
            for (int i = 0; i < totalProductos; i++)
            {
                DataTable dt = new DataTable();
                dt = objA.MostrarDatosProducto(i);
                //id de producto
                //nombre de producto
                string nombre = dt.Rows[i][1].ToString();
                double m = Math.Round(double.Parse(dt.Rows[i][2].ToString()),2);
                string preciolb = m.ToString();
                Byte[] data = new Byte[0];
                data = (Byte[])(dt.Rows[i][5]);
                MemoryStream mem = new MemoryStream(data);
                if (i % 2 == 0)
                {
                    GroupBox gb = new GroupBox();
                    //gb.Name = "gb" + i;
                    //gb.Text = i.ToString();
                    gb.Text = nombre;
                    gb.Size = new Size(200, 200);
                    
                    gb.Location = new Point(20, (PanelAlimentos.Controls.Count * 230) / 2);
                    PanelAlimentos.Controls.Add(gb);
                    
                    PictureBox img = new PictureBox();
                    img.Image = Image.FromStream(mem);
                    img.Size = new Size(110,90);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Location = new Point(45,20);

                    Label lbNombre = new Label();
                    Label lbPrecio = new Label();
                    lbNombre.Text = "Precio";
                    lbNombre.Font = new Font("Rockwell", 12, FontStyle.Bold);
                    lbPrecio.Text = preciolb;
                    lbPrecio.Font = new Font("Rockwell", 12, FontStyle.Bold);

                    img.Location = new Point(45, 20);
                    lbNombre.Location = new Point(15,120);
                    lbPrecio.Location = new Point(80,145);

                    gb.Controls.Add(img);
                    gb.Controls.Add(lbNombre);
                    gb.Controls.Add(lbPrecio);

                    gb.Click += delegate
                    {
                        RestaurarColor();
                        clickid = dt.Rows[i - 1][0].ToString();
                        this.AGB = gb;
                        gb.BackColor = Color.FromArgb(255, 192, 100);
                        gb.BackColor = Color.FromArgb(255, 192, 139);
                        lbNombreAlimento.Text = gb.Text;
                        precioAlimento = double.Parse(lbPrecio.Text);
                        cantidad = double.Parse(cBoxCantidad.SelectedItem.ToString());
                        totalPorAlimento = Math.Round(precioAlimento * cantidad, 2);
                        
                    };

                }
                else
                {
                    GroupBox gb = new GroupBox();
                    gb.Text = nombre;
                    gb.Size = new Size(200, 200);
                    gb.Location = new Point(240, ((PanelAlimentos.Controls.Count * 230) - 230) / 2);
                    PanelAlimentos.Controls.Add(gb);

                    PictureBox img = new PictureBox();
                    img.Image = Image.FromStream(mem);
                    img.Size = new Size(110, 90);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Location = new Point(45, 20);

                    Label lbNombre = new Label();
                    Label lbPrecio = new Label();
                    lbNombre.Text = "Precio";
                    lbNombre.Font = new Font("Rockwell", 12, FontStyle.Bold);
                    lbPrecio.Text = preciolb;
                    lbPrecio.Font = new Font("Rockwell", 12, FontStyle.Bold);

                    img.Location = new Point(45, 20);
                    lbNombre.Location = new Point(15, 120);
                    lbPrecio.Location = new Point(80, 145);

                    gb.Controls.Add(img);
                    gb.Controls.Add(lbNombre);
                    gb.Controls.Add(lbPrecio);

                    gb.Click += delegate
                    {
                        RestaurarColor();
                        this.AGB = gb;
                        clickid = dt.Rows[i - 1][0].ToString();
                        gb.BackColor = Color.FromArgb(255, 192, 100);
                        gb.BackColor = Color.FromArgb(255,192,139);
                        lbNombreAlimento.Text = gb.Text;
                        precioAlimento = double.Parse(lbPrecio.Text);
                        cantidad = double.Parse(cBoxCantidad.SelectedItem.ToString());
                        totalPorAlimento = Math.Round(precioAlimento*cantidad,2);
                        

                    };

                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 o = new Form1();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orden[iorden, 0] = lbNombreAlimento.Text;
            orden[iorden, 1] = cantidad.ToString();
            orden[iorden, 2] = (totalPorAlimento).ToString();
            orden[iorden, 3] = clickid;
            string compra = lbNombreAlimento.Text + " ____ $" + (totalPorAlimento).ToString();
            acumuladorSubTotal += totalPorAlimento;
            lbSubtotal.Text = (acumuladorSubTotal).ToString();
            listAlimentos.Items.Add(compra);
            iorden++;
            
        }


        private void RestaurarColor()
        {
            if (this.AGB != null)
            {
                this.AGB.BackColor = Color.FromArgb(255, 171, 101);
            }

        }
        /*
        public bool comprobadorDeCompra(string id)
        {
            int i = 0,serepite=1;
            while(id != orden[i, 3] && orden[i, 3]!=null)
            {
                serepite = 0;
                i++;
            }
            if (serepite == 0)
            {
                return true;
            }
            
            return false;
        }*/

    }
}
