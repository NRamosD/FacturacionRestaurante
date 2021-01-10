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
    public partial class Buscar_Prod : Form
    {
        public Buscar_Prod()
        {
            InitializeComponent();
        }
        OperacionesLogicas objP = new OperacionesLogicas();
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Visualizar_Prod frmAbrir = new Visualizar_Prod();
                objP.MostrarDatosProducto(int.Parse(txbCod.Text)); Visualizar objA = new Visualizar();
                DataTable tabla = new DataTable();
                tabla = objP.MostrarDatosProducto(int.Parse(txbCod.Text));
                if (tabla.Rows.Count > 0)
                {

                    byte[] arr;
                    frmAbrir.txbCod.Text = tabla.Rows[0][0].ToString();
                    frmAbrir.txbNombre.Text = tabla.Rows[0][1].ToString();
                    frmAbrir.txbPrecio.Text = tabla.Rows[0][2].ToString();
                    frmAbrir.txbCategoria.Text = tabla.Rows[0][3].ToString();
                    arr = (byte[])tabla.Rows[0][5];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(arr);
                    frmAbrir.pbxProd.Image = Image.FromStream(ms);
                    frmAbrir.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                    txbCod.Clear();
                }
            }
            catch 
            {
                MessageBox.Show("Datos mal ingresados");
            }
        }
    }
}
