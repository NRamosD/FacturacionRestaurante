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
    public partial class acerca : Form
    {
        public acerca()
        {
            InitializeComponent();
        }

        private void acerca_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 o = new Form1();
            o.Show();
        }
    }
}
