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
    public partial class Buscar_Visualizar : Form
    {
        public Buscar_Visualizar()
        {
            InitializeComponent();
        }
        OperacionesLogicas objOp = new OperacionesLogicas();

        private void Buscar_Visualizar_Load(object sender, EventArgs e)
        {
            txbID.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            objOp.MostrarDatosCliente(txbID.Text);
            Visualizar objA = new Visualizar();
            DataTable tabla = new DataTable();
            tabla = objOp.MostrarDatosCliente(txbID.Text);
            if(tabla.Rows.Count > 0){
                objA.txbCod.Text = tabla.Rows[0][0].ToString();
                objA.txbID.Text = tabla.Rows[0][1].ToString();
                objA.txbNombre.Text = tabla.Rows[0][2].ToString();
                objA.txbApellido.Text = tabla.Rows[0][3].ToString();
                objA.txbTelef.Text = tabla.Rows[0][4].ToString();
                objA.tbCorreo.Text = tabla.Rows[0][5].ToString();
                objA.txbDireecion.Text = tabla.Rows[0][6].ToString();
                objA.txbSexo.Text = tabla.Rows[0][7].ToString();
                objA.txbFecha.Text = tabla.Rows[0][8].ToString();
                objA.Show();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
                txbID.Clear();
            }

        }
    }
}
