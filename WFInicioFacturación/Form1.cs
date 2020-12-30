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
    public partial class Form1 : Form
    {
        string unavariable;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "No me clickees";

            label1.Text = "que friegas";
            label1.BackColor = Color.AntiqueWhite;
            button2.Text = "Escribe bien\npendejo";
            button2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = "NO SE GUARDA MRDA";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Si se guardó we";
            unForm jaja = new unForm();
            jaja.Show();
        }
    }
}
