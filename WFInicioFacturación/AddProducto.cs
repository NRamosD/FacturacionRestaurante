﻿using System;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd =new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxProd.Image = Image.FromFile(ofd.FileName);
                    pbxProd.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Image img = pbxProd.Image;
            byte [] arr;
            ImageConverter ic = new ImageConverter();
            arr = (byte[])ic.ConvertTo(img, typeof(byte[]));

            string categoria = cbCateogria.SelectedItem.ToString();
            objA.InsertarProducto(int.Parse(txbCod.Text), txbNombre.Text, txbPrecio.Text, categoria[0].ToString(), arr);
            MessageBox.Show(cbCateogria.SelectedItem.ToString());
        }

        private void cbCateogria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProducto_Load(object sender, EventArgs e)
        {
            cbCateogria.SelectedItem = "Comida";
        }
    }
}
