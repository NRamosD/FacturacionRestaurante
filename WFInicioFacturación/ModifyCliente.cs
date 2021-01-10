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
    public partial class ModifyCliente : Form
    {
        OperacionesLogicas objOp = new OperacionesLogicas();
        public ModifyCliente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Desea guardar los cambios?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){
                    objOp.EditarCliente(txbCod.Text, txbTelef.Text, tbCorreo.Text, txbDireecion.Text);
                    MessageBox.Show("Cambios Modificados exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No sean guardado los cambios");
                }
            }
            catch
            {
                MessageBox.Show("No se puede realizar esta acción");
            }
        }

        private void ModifyCliente_Load(object sender, EventArgs e)
        {
            txbID.Focus();
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if (txbID.Text.Length == 10)
            {
                DataTable tabla = new DataTable();
                tabla = objOp.MostrarDatosCliente(txbID.Text);
                if (tabla.Rows.Count>0)
                {
                    txbCod.Text = tabla.Rows[0][0].ToString();
                    txbNombre.Text = tabla.Rows[0][2].ToString();
                    txbApellido.Text = tabla.Rows[0][3].ToString();
                    txbTelef.Text = tabla.Rows[0][4].ToString();
                    tbCorreo.Text = tabla.Rows[0][5].ToString();
                    txbDireecion.Text = tabla.Rows[0][6].ToString();
                    txbSexo.Text = tabla.Rows[0][7].ToString();
                    txbTelef.Enabled = true;
                    txbDireecion.Enabled = true;
                    tbCorreo.Enabled = true;
                    txbTelef.Focus();
                    btnConfirmar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cliente no Encontrado");
                }
            }
        }
    }
}
