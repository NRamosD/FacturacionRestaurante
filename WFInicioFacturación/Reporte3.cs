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
    public partial class Reporte3 : Form
    {
        public Reporte3()
        {
            InitializeComponent();
        }

        private void Reporte3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBD.AlimentosMasVendidosView' Puede moverla o quitarla según sea necesario.
            this.AlimentosMasVendidosViewTableAdapter.Fill(this.DataSetBD.AlimentosMasVendidosView);

            this.reportViewer1.RefreshReport();
        }
    }
}
