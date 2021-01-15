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
    public partial class AddProducto : Form
    {
        OperacionesLogicas objA = new OperacionesLogicas();
        public AddProducto()
        {
            InitializeComponent();
            cbCateogria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            using (ofd)
            {
                //ofd.Filter = "Imágenes|*.txt|*.jpg|*.jpeg|*.png|All files (.)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxProd.Image = Image.FromFile(ofd.FileName);
                    pbxProd.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbxProd.Image!=null)
                {
                    Image img = pbxProd.Image;
                    byte[] arr;
                    ImageConverter ic = new ImageConverter();
                    arr = (byte[])ic.ConvertTo(img, typeof(byte[]));
                    objA.InsertarProducto(txbCod.Text, txbNombre.Text, txbPrecio.Text, cbCateogria.SelectedItem.ToString(), arr);
                    MessageBox.Show("Datos ingresados con éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese una imagen");
                }
            }
            catch
            {
                MessageBox.Show("No se puede almacenar los datos ingresados");
            }

        }

        private void cbCateogria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProducto_Load(object sender, EventArgs e)
        {
            txbCod.Text = objA.NuevoProd().ToString();
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
