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
        public FrmSelec()
        {
            InitializeComponent();
        }

        private void FrmSelec_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {

                    GroupBox gb = new GroupBox();
                    //gb.Name = "gb" + i;
                    gb.Text = i.ToString();
                    gb.Size = new Size(200, 200);
                    gb.Click += delegate
                    {
                        //MessageBox.Show("Este es mi nombre " + gb.Name);
                        FrmCantidad selection = new FrmCantidad();
                        selection.Show();
                    };
                    gb.Location = new Point(20, (PanelAlimentos.Controls.Count * 230) / 2);
                    PanelAlimentos.Controls.Add(gb);
                    
                    PictureBox img = new PictureBox();
                    img.Image = Properties.Resources.platodeprueba;
                    img.Size = new Size(110,90);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Location = new Point(45,20);

                    Label lbNombre = new Label();
                    Label lbPrecio = new Label();
                    lbNombre.Text = "Picadita";
                    lbNombre.Font = new Font("Rockwell", 12, FontStyle.Bold);
                    lbPrecio.Text = "$" + " 1";
                    lbPrecio.Font = new Font("Rockwell", 12, FontStyle.Bold);

                    img.Location = new Point(45, 20);
                    lbNombre.Location = new Point(50,120);
                    lbPrecio.Location = new Point(80,145);

                    gb.Controls.Add(img);
                    gb.Controls.Add(lbNombre);
                    gb.Controls.Add(lbPrecio);
                    
                }
                else
                {
                    GroupBox gb = new GroupBox();
                    gb.Text = i.ToString();
                    gb.Size = new Size(200, 200);
                    gb.Click += delegate
                    {
                        //MessageBox.Show("Este es mi nombre " + gb.Name);
                        FrmCantidad selection = new FrmCantidad();
                        selection.Show();
                    };
                    gb.Location = new Point(240, ((PanelAlimentos.Controls.Count * 230) - 230) / 2);
                    PanelAlimentos.Controls.Add(gb);

                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
