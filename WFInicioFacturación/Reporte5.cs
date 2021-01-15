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
    public partial class Reporte5 : Form
    {
        public Reporte5()
        {
            InitializeComponent();
        }

        private void Reporte5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBD.ClientesMayoresCompras' Puede moverla o quitarla según sea necesario.
            this.ClientesMayoresComprasTableAdapter.Fill(this.DataSetBD.ClientesMayoresCompras);

            this.reportViewer1.RefreshReport();
        }
    }
}
