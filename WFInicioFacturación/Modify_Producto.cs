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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxProd.Image = Image.FromFile(ofd.FileName);
                    pbxProd.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
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
                if (MessageBox.Show("¿Desea confirmar los cambios?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Image img = pbxProd.Image;
                    byte[] arr;
                    ImageConverter ic = new ImageConverter();
                    arr = (byte[])ic.ConvertTo(img, typeof(byte[]));
                    objP.EditarProducto(txbCod.Text, txbNombre.Text, txbPrecio.Text, cbCategoria.Text, arr);
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
                MessageBox.Show("No se puede realizar esta acción");
            }
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void txbCod_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
