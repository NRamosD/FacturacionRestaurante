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
    public partial class FrmSelec : Form
    {

        double precioAlimento, cantidad, totalPorAlimento,acumuladorSubTotal=0;


        public FrmSelec()
        {
            InitializeComponent();
        }

        private void cBoxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPorAlimento = precioAlimento * double.Parse(cBoxCantidad.SelectedItem.ToString());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            factura o = new factura();
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
            //el i debe ser el número de elementos en productos
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    GroupBox gb = new GroupBox();
                    //gb.Name = "gb" + i;
                    gb.Text = i.ToString();
                    gb.Size = new Size(200, 200);
                    
                    gb.Location = new Point(20, (PanelAlimentos.Controls.Count * 230) / 2);
                    PanelAlimentos.Controls.Add(gb);
                    
                    PictureBox img = new PictureBox();
                    img.Image = Properties.Resources.platodeprueba;
                    img.Size = new Size(110,90);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Location = new Point(45,20);

                    Label lbNombre = new Label();
                    Label lbPrecio = new Label();
                    lbNombre.Text = "Picadita "+i;
                    lbNombre.Font = new Font("Rockwell", 12, FontStyle.Bold);
                    lbPrecio.Text = i.ToString();
                    lbPrecio.Font = new Font("Rockwell", 12, FontStyle.Bold);

                    img.Location = new Point(45, 20);
                    lbNombre.Location = new Point(50,120);
                    lbPrecio.Location = new Point(80,145);

                    gb.Controls.Add(img);
                    gb.Controls.Add(lbNombre);
                    gb.Controls.Add(lbPrecio);

                    gb.Click += delegate
                    {
                        //this.Refresh();
                        //MessageBox.Show("Este es mi nombre " + gb.Name);
                        //FrmCantidad selection = new FrmCantidad(lbNombre.Text, double.Parse(lbPrecio.Text));
                        gb.BackColor = Color.FromArgb(255, 192, 139);
                        lbNombreAlimento.Text = lbNombre.Text;
                        precioAlimento = double.Parse(lbPrecio.Text);
                        cantidad = double.Parse(cBoxCantidad.SelectedItem.ToString());
                        totalPorAlimento = Math.Round(precioAlimento * cantidad, 2);
                        
                    };

                }
                else
                {
                    GroupBox gb = new GroupBox();
                    gb.Text = i.ToString();
                    gb.Size = new Size(200, 200);
                    /*gb.Click += delegate
                    {
                        //MessageBox.Show("Este es mi nombre " + gb.Name);
                        FrmCantidad selection = new FrmCantidad(lbNombre.Text, double.Parse(lbPrecio.Text));
                        selection.Show();
                    };*/
                    gb.Location = new Point(240, ((PanelAlimentos.Controls.Count * 230) - 230) / 2);
                    PanelAlimentos.Controls.Add(gb);

                    PictureBox img = new PictureBox();
                    img.Image = Properties.Resources.platodeprueba;
                    img.Size = new Size(110, 90);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Location = new Point(45, 20);

                    Label lbNombre = new Label();
                    Label lbPrecio = new Label();
                    lbNombre.Text = "Picadita " + i;
                    lbNombre.Font = new Font("Rockwell", 12, FontStyle.Bold);
                    lbPrecio.Text = i.ToString();
                    lbPrecio.Font = new Font("Rockwell", 12, FontStyle.Bold);

                    img.Location = new Point(45, 20);
                    lbNombre.Location = new Point(50, 120);
                    lbPrecio.Location = new Point(80, 145);

                    gb.Controls.Add(img);
                    gb.Controls.Add(lbNombre);
                    gb.Controls.Add(lbPrecio);

                    gb.Click += delegate
                    {
                        //this.Refresh();
                        //MessageBox.Show("Este es mi nombre " + gb.Name);
                        //FrmCantidad selection = new FrmCantidad(lbNombre.Text, double.Parse(lbPrecio.Text));
                        gb.BackColor = Color.FromArgb(255,192,139);
                        lbNombreAlimento.Text = lbNombre.Text;
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
            string compra = lbNombreAlimento.Text+" ____ $"+(totalPorAlimento).ToString();
            acumuladorSubTotal += totalPorAlimento;
            lbSubtotal.Text = (acumuladorSubTotal).ToString();
            listAlimentos.Items.Add(compra);
        }
    }
}
