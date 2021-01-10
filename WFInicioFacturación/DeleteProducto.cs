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
    public partial class DeleteProducto : Form
    {
        public DeleteProducto()
        {
            InitializeComponent();
        }
        OperacionesLogicas objP = new OperacionesLogicas();
        private void txbCod_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = objP.MostrarDatosProducto(int.Parse(txbCod.Text));
            if (tabla.Rows.Count > 0)
            {
                byte[] arr;
                txbCod.Text = tabla.Rows[0][0].ToString();
                txbNombre.Text = tabla.Rows[0][1].ToString();
                txbPrecio.Text = tabla.Rows[0][2].ToString();
                txbCategoria.Text = tabla.Rows[0][3].ToString();
                arr = (byte[])tabla.Rows[0][5];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(arr);
                pbxProd.Image = Image.FromStream(ms);

            }
            else
            {
                MessageBox.Show("Producto no Encontrado");
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea eliminar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                objP.EliminarProducto(txbCod.Text);
                MessageBox.Show("Producto eliminado exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha eliminado el producto");
                this.Close();
            }  
        }
    }
}
