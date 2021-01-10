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
    public partial class Modify_Producto : Form
    {
        public Modify_Producto()
        {
            InitializeComponent();
        }

        OperacionesLogicas objP = new OperacionesLogicas();
        private void Modify_Producto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

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
                cbCategoria.Text = tabla.Rows[0][3].ToString();
                arr = (byte[])tabla.Rows[0][5];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(arr);
                pbxProd.Image = Image.FromStream(ms);

                txbNombre.Enabled = true;
                txbPrecio.Enabled = true;
                cbCategoria.Enabled = true;
                btnCancelar.Visible = true;
                btnConfirmar.Visible = true;
                txbNombre.Focus();
            }
            else
            {
                MessageBox.Show("Producto no Encontrado");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Desea confirmar los cambios?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){
                    Image img = pbxProd.Image;
                    byte[] arr;
                    ImageConverter ic = new ImageConverter();
                    arr = (byte[])ic.ConvertTo(img, typeof(byte[]));
                    objP.EditarProducto(txbCod.Text, txbNombre.Text, txbPrecio.Text, arr);
                    MessageBox.Show("Cambios efectuados exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se han realizado los cambios");
                    this.Close();
                }  
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
