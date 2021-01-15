using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicioFacturación
{
    public partial class FrmRecuContra : Form
    {
        string Nmascota = "Toby";
        public FrmRecuContra()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (textBox2.Text == Nmascota)
                    {
                        //habilitar boton y TXTBOX enviar correo 
                        TxtCorreo.Enabled = true;
                        BtnEnviar.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(TxtCorreo.Text);
            mmsg.Subject = "Recuperación de Conraseña By APP-El Palé";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = "La contraseña de la App es adminPALE";
            mmsg.BodyEncoding= System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("jhonriera1998@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("jhonriera1998@gmail.com", "jhonyr1998");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Correo enviado exitosamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("",error.Message);
            }

            FrmLogin ObjLog = new FrmLogin();
            ObjLog.ShowDialog();
            this.Close();
        }
    }
}
