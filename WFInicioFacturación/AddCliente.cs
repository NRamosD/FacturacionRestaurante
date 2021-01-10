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
        }
        OperacionesLogicas objA = new OperacionesLogicas();
        private void AddCliente_Load(object sender, EventArgs e)
        {
            txbCod.Text = objA.ObtenerCodCliente().ToString();
            txbID.Focus();
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {

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
    }
}
