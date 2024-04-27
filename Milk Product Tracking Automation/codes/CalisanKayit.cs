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
    public partial class CalisanKayit : Form
    {
        // SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        BaglantiSinifi bgl = new BaglantiSinifi();
        public CalisanKayit()
        {
            InitializeComponent();
            Goster();
        }
        private void Cikis_Butonu_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void Goster()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            string query = "select * from Calisan_Kayit";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            calisan_liste_CustomDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Temizle()
        {
            calisan_Telefon_Tb.Text = "";
            calisan_CalisanAdi_Tb.Text = "";
            calisan_Adres_Tb.Text = "";
            calisan_Cinsiyet_Cb.SelectedIndex = -1;

            tus = 0;
            calisan_Sifre_Tb.Text = "";
        }

        private void calisan_Kaydet_Button_Click(object sender, EventArgs e)
        {
            if (calisan_CalisanAdi_Tb.Text == ""|| calisan_Cinsiyet_Cb.SelectedIndex == -1 || calisan_Telefon_Tb.Text == "" || calisan_Adres_Tb.Text == "" || calisan_Sifre_Tb.Text =="")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "insert into Calisan_Kayit values ('" + calisan_CalisanAdi_Tb.Text + "','" + Calisan_DogumTarih_dateTime.Value.Date + "','" + calisan_Cinsiyet_Cb.SelectedItem.ToString() + "','" + calisan_Telefon_Tb.Text + "','" + calisan_Adres_Tb.Text + "','" + calisan_Sifre_Tb.Text+"')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Çalışan başarılı bir şekilde kaydedildi");

                    con.Close();

                    Goster();
                    //Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }


        }
        int tus = 0;
        private void calisan_liste_CustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            calisan_CalisanAdi_Tb.Text = calisan_liste_CustomDataGrid.Rows[index].Cells[1].Value.ToString();
            Calisan_DogumTarih_dateTime.Text = calisan_liste_CustomDataGrid.Rows[index].Cells[2].Value.ToString();
            calisan_Cinsiyet_Cb.Text = calisan_liste_CustomDataGrid.Rows[index].Cells[3].Value.ToString();
            calisan_Telefon_Tb.Text = calisan_liste_CustomDataGrid.Rows[index].Cells[4].Value.ToString();
            calisan_Adres_Tb.Text = calisan_liste_CustomDataGrid.Rows[index].Cells[5].Value.ToString();
            calisan_Sifre_Tb.Text = calisan_liste_CustomDataGrid.Rows[index].Cells[6].Value.ToString();

            if (calisan_CalisanAdi_Tb.Text == "")
            {
                tus = 0;
            }

            else
            {
                tus = Convert.ToInt32(calisan_liste_CustomDataGrid.Rows[index].Cells[0].Value.ToString());
            }
        }

        private void calisan_Temizle_Button_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void calisan_Sil_Button_Click(object sender, EventArgs e)
        {
            if (tus == 0)
            {
                MessageBox.Show("Silmek için önce bir çalışan seçiniz");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "delete from Calisan_Kayit where CalisanID=" + tus + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçmiş olduğunuz çalışan başarılı bir şekilde silindi");
                    con.Close();

                    Goster();
                    Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void calisan_Duzenle_Button_Click(object sender, EventArgs e)
        {
            if (calisan_CalisanAdi_Tb.Text == "" || calisan_Cinsiyet_Cb.SelectedIndex == -1 || calisan_Telefon_Tb.Text == "" || calisan_Adres_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "update Calisan_Kayit set CalisanAdi='" + calisan_CalisanAdi_Tb.Text + "',CalisanDogumTarih='" + Calisan_DogumTarih_dateTime.Value.Date + "',Cinsiyet='" + calisan_Cinsiyet_Cb.SelectedItem.ToString() + "',Telefon='" + calisan_Telefon_Tb.Text + "',Adres='" + calisan_Adres_Tb.Text + "',CalisanSifre='" + calisan_Sifre_Tb.Text + "' where CalisanID=" + tus + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçilen çalışan başarılı bir şekilde düzenlendi");

                    con.Close();

                    Goster();
                    Temizle();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }

        private void inekler_buton_Click(object sender, EventArgs e)
        {
            InekKayit ik = new InekKayit();
            ik.ShowDialog();
            this.Hide();

        }

        private void Saglik_buton_Click(object sender, EventArgs e)
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

        private void SutSatis_buton_Click(object sender, EventArgs e)
        {
            SutSatisKayit ssk = new SutSatisKayit();
            ssk.ShowDialog();
            this.Hide();
        }

        private void Finans_buton_Click(object sender, EventArgs e)
        {
            FinansKayit fk = new FinansKayit();
            fk.ShowDialog();
            this.Hide();
        }
    }
}
