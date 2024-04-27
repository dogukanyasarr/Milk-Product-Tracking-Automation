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
    public partial class SutSatisKayit : Form
    {
        //SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        BaglantiSinifi bgl = new BaglantiSinifi();
        public SutSatisKayit()
        {
            InitializeComponent();
            EkleCalisanID();
            Goster();
        }

        private void Inek_Buton_Click(object sender, EventArgs e)
        {
            InekKayit ik = new InekKayit();
            ik.ShowDialog();
            this.Hide();
        }

        private void Saglik_Buton_Click(object sender, EventArgs e)
        {
            SaglikKaydet sk = new SaglikKaydet();
            sk.ShowDialog();
            this.Hide();
        }

        private void SutUretim_Buton_Click(object sender, EventArgs e)
        {
            SutUretimKayit suk = new SutUretimKayit();
            suk.ShowDialog();
            this.Hide();
        }

        private void Finans_Buton_Click(object sender, EventArgs e)
        {
            FinansKayit fk = new FinansKayit();
            fk.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Oturumu_Kapat_Buton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EkleCalisanID()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();

            SqlCommand com = new SqlCommand("select CalisanID from Calisan_Kayit", con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CalisanID", typeof(int));
            dt.Load(rdr);
            ss_CalisanID_Cb.ValueMember = "CalisanID";
            ss_CalisanID_Cb.DataSource = dt;

            con.Close();
        }

        private void SutSatisKayit_Load(object sender, EventArgs e)
        {

        }

        private void ss_Miktar_Tb_Leave(object sender, EventArgs e)
        {
            int toplam = Convert.ToInt32(ss_Fıyat_Tb.Text) * Convert.ToInt32(ss_Miktar_Tb.Text);
            ss_Toplam_Tb.Text = "" + toplam;
        }
        private void Goster()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            string query = "select * from Sut_Satis_Kayit_Tablosu1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sutSatis_liste_CustomDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Temizle()
        {
            ss_Fıyat_Tb.Text = "";
            ss_Miktar_Tb.Text = "";
            ss_MusteriAdi_Tb.Text = "";
            ss_MusterTelefon_Tb.Text = "";
            ss_Toplam_Tb.Text = "";
        }
        private void KaydetmeIslemi()
        {
            //finans kısmına bağlantı sağlama

                try
                {
                string Satislar = "Satislar";
                SqlConnection con = new SqlConnection(bgl.Adres);
                con.Open();
                    string Query = "insert into Gelir_Kayit values ('" + ss_Tarih_dateTime.Value.Date + "','" + Satislar + "','" + ss_Toplam_Tb.Text +  "','" + ss_CalisanID_Cb.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gelirler başarılı bir şekilde kaydedildi");
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            

            
        }
        private void ss_Kaydet_Button_Click(object sender, EventArgs e)
        {
            if (ss_CalisanID_Cb.SelectedIndex == -1 || ss_Fıyat_Tb.Text == "" || ss_MusteriAdi_Tb.Text == "" || ss_MusterTelefon_Tb.Text == "" || ss_Miktar_Tb.Text == "" || ss_Fıyat_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "insert into Sut_Satis_Kayit_Tablosu1 values ('" + ss_Tarih_dateTime.Value.Date + "','" + ss_Fıyat_Tb.Text + "','" + ss_MusteriAdi_Tb.Text + "','" + ss_MusterTelefon_Tb.Text + "','" + ss_Miktar_Tb.Text + "','" + ss_CalisanID_Cb.SelectedValue.ToString() + "','" + ss_Toplam_Tb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Süt satışı başarılı bir şekilde kaydedildi");

                    con.Close();
                    KaydetmeIslemi();
                    Goster();

                    Temizle();
                    

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

            
        }

        private void ss_Temizle_Button_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
