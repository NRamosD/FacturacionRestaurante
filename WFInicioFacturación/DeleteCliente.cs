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
    public partial class DeleteCliente : Form
    {
        public DeleteCliente()
        {
            InitializeComponent();
        }
        OperacionesLogicas objOp = new OperacionesLogicas();

        private void DeleteCliente_Load(object sender, EventArgs e)
        {
            txbID.Focus();
        }

        private void txbID_TextChanged_1(object sender, EventArgs e)
        {
            if (txbID.Text.Length == 10)
            {
                objOp.MostrarDatosCliente(txbID.Text);
                DataTable tabla = new DataTable();
                tabla = objOp.MostrarDatosCliente(txbID.Text);
                if (tabla.Rows.Count > 0)
                {
                    txbCod.Text = tabla.Rows[0][0].ToString();
                    txbID.Text = tabla.Rows[0][1].ToString();
                    txbNombre.Text = tabla.Rows[0][2].ToString();
                    txbApellido.Text = tabla.Rows[0][3].ToString();
                    txbTelef.Text = tabla.Rows[0][4].ToString();
                    tbCorreo.Text = tabla.Rows[0][5].ToString();
                    txbDireecion.Text = tabla.Rows[0][6].ToString();
                    txbSexo.Text = tabla.Rows[0][7].ToString();
                    btnConfirmar.Visible = true;

                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                    txbID.Clear();
                }
            }
                
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Está seguro que desea eliminar los datos del cliente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    objOp.EliminarCliente(txbCod.Text);
                    MessageBox.Show("Cliente eliminado con éxito");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("No se puede realizar esta acción");
            }
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
