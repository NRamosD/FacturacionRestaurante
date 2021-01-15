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
    public partial class Reporte4 : Form
    {
        public Reporte4()
        {
            InitializeComponent();
        }

        private void Reporte4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBD.AlimentosFechaDeterminada' Puede moverla o quitarla según sea necesario.
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.AlimentosFechaDeterminadaTableAdapter.Fill(this.DataSetBD.AlimentosFechaDeterminada, textBox1.Text, dateTimePicker1.Value);
            // TODO: esta línea de código carga datos en la tabla 'DataSetBD.AlimentosFechaDeterminada' Puede moverla o quitarla según sea necesario.
            this.reportViewer1.RefreshReport();
        }
    }
}
