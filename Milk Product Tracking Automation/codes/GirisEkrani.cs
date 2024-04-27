using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SutSatisOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        //SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        
        public GirisEkrani()
        {
            InitializeComponent();
        }
        BaglantiSinifi bgl = new BaglantiSinifi();
        private void cikis_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Sifremi_Unuttum_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreHatirlatma sh = new SifreHatirlatma();
            sh.ShowDialog();
            this.Hide();
        }

        private void sıfırla_Lbl_Click(object sender, EventArgs e)
        {
            kullanici_adi_textBox.Text = "";
            sifre_textBox2.Text = "";
        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            if (kullanici_adi_textBox.Text == "" || sifre_textBox2.Text == "")
            {
                MessageBox.Show("Admin kullanıcı adı ve şifresi girin.");
            } 
            else
            {
                if(roller_Cb.SelectedIndex > -1)
                {
                    if(roller_Cb.SelectedItem.ToString() == "admin") 
                    {
                        if(kullanici_adi_textBox.Text == "Admin" && sifre_textBox2.Text == "1234")
                        {
                            CalisanKayit ck = new CalisanKayit();
                            ck.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Eğer Adminseniz doğru kullanıcı adı ve şifreyi giriniz");
                        }
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(bgl.Adres);
                        con.Open();

                        SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from Calisan_Kayit where CalisanAdi='" + kullanici_adi_textBox.Text + "' and CalisanSifre='" + sifre_textBox2.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            InekKayit ik = new InekKayit();
                            ik.Show();
                            this.Hide();

                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Yanlış kullanıcı adı veya şifre");
                        }

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen önce bir rol seçiniz");
                }
                
            }
           
        }

    }
}
