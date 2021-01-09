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
    public partial class Buscar_Prod : Form
    {
        public Buscar_Prod()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Visualizar_Prod frmAbrir = new Visualizar_Prod();
            frmAbrir.Show();
        }
    }
}
