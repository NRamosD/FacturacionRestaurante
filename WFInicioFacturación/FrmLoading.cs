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
        public FrmLoading()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pbxProgrss.Width += 5;

                if (pbxProgrss.Width >= 345)
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
    }
}
