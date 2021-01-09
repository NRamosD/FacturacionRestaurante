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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TxtUsuario.Text = "";
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            TxtPass.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuContra ObjRecup = new FrmRecuContra();
            ObjRecup.ShowDialog();
            this.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUsuario.Text == "admin" && TxtPass.Text == "adminPALE")
                {
                    this.Close();
                    Form1 obj = new Form1();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("El Usuario o la Contraseña no coinciden ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
