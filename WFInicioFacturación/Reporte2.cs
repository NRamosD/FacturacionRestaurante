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
    public partial class Reporte2 : Form
    {
        public Reporte2()
        {
            InitializeComponent();
        }

        private void Reporte2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBD.GananciasPorFechasView' Puede moverla o quitarla según sea necesario.
            this.GananciasPorFechasViewTableAdapter.Fill(this.DataSetBD.GananciasPorFechasView);

            this.reportViewer1.RefreshReport();
        }
    }
}
