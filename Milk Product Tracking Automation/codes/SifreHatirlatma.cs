using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SutSatisOtomasyonu
{
    public partial class SifreHatirlatma : Form
    {
        public SifreHatirlatma()
        {
            InitializeComponent();
        }
        private void cikis_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        void MailGonder()
        {
            MailMessage eposta = new MailMessage();

            eposta.From = new MailAddress("dogukanyasar.79@gmail.com");
            eposta.To.Add(mail_adres_Tb.Text.ToString());
            eposta.Subject =talep_Tb.Text.ToString();
            eposta.Body = "!! HATIRLATMA !! unuttuğunuz şifreniz = 1234";

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("dogukanyasar.79@gmail.com", "pahzvansazsiepdq");
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Send(eposta);
            MessageBox.Show("Mail Gönderildi");
            
        }

        private void gonder_Button_Click(object sender, EventArgs e)
        {
            MailGonder();

        }
    }
}
