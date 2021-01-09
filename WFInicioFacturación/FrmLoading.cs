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
    public partial class FrmLoading : Form
    {
        int[] lluviaVe = { 14, 15, 16, 13, 14, 15, 16, 17, 18, 11, 12, 13 };
        public FrmLoading()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ARVeg();
                pbxProgrss.Width += 5;

                if (pbxProgrss.Width >= 300)
                {
                    timer1.Stop();

                    FrmLogin ObjLog = new FrmLogin();
                    this.Hide();
                    ObjLog.ShowDialog(); 

                }
                
            }
            catch (Exception )
            {
                return;
            }
        }
        private void ARVeg()
        {

            for (int i = 0; i < 12; i++)
            {
                switch (i)
                {
                    case 0:
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + lluviaVe[i]);
                        if (pictureBox3.Location.Y > panel1.Size.Height + pictureBox3.Size.Height)
                        {
                            pictureBox3.Location = new Point(pictureBox3.Location.X, 0 - pictureBox3.Size.Height);
                        }
                        break;
                    case 1:
                        pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y + lluviaVe[i]);
                        if (pictureBox13.Location.Y > panel1.Size.Height + pictureBox13.Size.Height)
                        {
                            pictureBox13.Location = new Point(pictureBox13.Location.X, 0 - pictureBox13.Size.Height);
                        }
                        break;
                    case 2:
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + lluviaVe[i]);
                        if (pictureBox4.Location.Y > panel1.Size.Height + pictureBox4.Size.Height)
                        {
                            pictureBox4.Location = new Point(pictureBox4.Location.X, 0 - pictureBox4.Size.Height);
                        }
                        break;
                    case 3:
                        pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y + lluviaVe[i]);
                        if (pictureBox11.Location.Y > panel1.Size.Height + pictureBox11.Size.Height)
                        {
                            pictureBox11.Location = new Point(pictureBox11.Location.X, 0 - pictureBox11.Size.Height);
                        }
                        break;
                    case 4:
                        pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + lluviaVe[i]);
                        if (pictureBox6.Location.Y > panel1.Size.Height + pictureBox6.Size.Height)
                        {
                            pictureBox6.Location = new Point(pictureBox6.Location.X, 0 - pictureBox6.Size.Height);
                        }
                        break;
                    case 5:
                        pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + lluviaVe[i]);
                        if (pictureBox5.Location.Y > panel1.Size.Height + pictureBox5.Size.Height)
                        {
                            pictureBox5.Location = new Point(pictureBox5.Location.X, 0 - pictureBox5.Size.Height);
                        }
                        break;
                    case 6:
                        pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + lluviaVe[i]);
                        if (pictureBox8.Location.Y > panel1.Size.Height + pictureBox8.Size.Height)
                        {
                            pictureBox8.Location = new Point(pictureBox6.Location.X, 0 - pictureBox8.Size.Height);
                        }
                        break;
                    case 7:
                        pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + lluviaVe[i]);
                        if (pictureBox7.Location.Y > panel1.Size.Height + pictureBox7.Size.Height)
                        {
                            pictureBox7.Location = new Point(pictureBox7.Location.X, 0 - pictureBox7.Size.Height);
                        }
                        break;
                    case 8:
                        pictureBox14.Location = new Point(pictureBox14.Location.X, pictureBox14.Location.Y + lluviaVe[i]);
                        if (pictureBox14.Location.Y > panel1.Size.Height + pictureBox14.Size.Height)
                        {
                            pictureBox14.Location = new Point(pictureBox14.Location.X, 0 - pictureBox14.Size.Height);
                        }
                        break;
                    case 9:
                        pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + lluviaVe[i]);
                        if (pictureBox9.Location.Y > panel1.Size.Height + pictureBox9.Size.Height)
                        {
                            pictureBox9.Location = new Point(pictureBox9.Location.X, 0 - pictureBox9.Size.Height);
                        }
                        break;
                    case 10:
                        pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + lluviaVe[i]);
                        if (pictureBox10.Location.Y > panel1.Size.Height + pictureBox10.Size.Height)
                        {
                            pictureBox10.Location = new Point(pictureBox10.Location.X, 0 - pictureBox10.Size.Height);
                        }
                        break;
                    case 11:
                        pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y + lluviaVe[i]);
                        if (pictureBox12.Location.Y > panel1.Size.Height + pictureBox12.Size.Height)
                        {
                            pictureBox12.Location = new Point(pictureBox12.Location.X, 0 - pictureBox12.Size.Height);
                        }
                        break;
                }
            }
        }
    }
}
