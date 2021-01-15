using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;



namespace WFInicioFacturación
{
    public partial class AddCliente : Form
    {
        
        public AddCliente()
        {
            InitializeComponent();
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        OperacionesLogicas objA = new OperacionesLogicas();
        private void AddCliente_Load(object sender, EventArgs e)
        {
            txbCod.Text = objA.ObtenerCodCliente().ToString();
            txbID.Focus();
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                objA.OpInsertarCliente(txbCod.Text, txbID.Text, txbNombre.Text, txbApellido.Text, txbTelef.Text, tbCorreo.Text, txbDireecion.Text, cbSexo.Text);
                MessageBox.Show("Datos ingresados con éxito");
           
            }
            catch
            {
                MessageBox.Show("No se puede almacenar los datos ingresados");
            }
        }

        private void txbID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }

        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txbTelef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
            
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if (txbID.TextLength == 10)
            {
                string Cedula = txbID.Text;
                char[] vect = Cedula.ToArray();
                int res =objA.Verificar(vect);
                if (res < 0)
                {
                    //Si la Cédula Ingresada Es Incorrecta
                    MessageBox.Show("Cédula Incorrecta");
                    txbID.Text = "";
                }
            }
        }
    }
}
