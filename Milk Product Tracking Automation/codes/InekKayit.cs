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
    public partial class InekKayit : Form
    {
        // SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        BaglantiSinifi bgl = new BaglantiSinifi();

        public InekKayit()
        {
            InitializeComponent();
            Goster();
        }

        private void Cikis_Butonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Saglik_Butonu_Click(object sender, EventArgs e)
        {
            SaglikKaydet sk = new SaglikKaydet();
            sk.ShowDialog();
            this.Hide();
        }

        private void Sut_Uretim_Butonu_Click(object sender, EventArgs e)
        {
            SutUretimKayit suk = new SutUretimKayit();
            suk.ShowDialog();
            this.Hide();
        }

        private void Sut_Satis_Butonu_Click(object sender, EventArgs e)
        {
            SutSatisKayit ssk = new SutSatisKayit();
            ssk.ShowDialog();
            this.Hide();
        }

        private void Finans_Butonu_Click(object sender, EventArgs e)
        {
            FinansKayit fk = new FinansKayit();
            fk.ShowDialog();
            this.Hide();
        }

        private void Goster()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            string query = "select * from Inek_Kayit";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            inek_liste_CustomDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Oturumu_Kapat_Buton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int yas = 0;
        private void inekKaydet_button_Click(object sender, EventArgs e)
        {
            if (inekAdi_Tb.Text == "" || inek_kulakEtiketi_Tb.Text == "" || inek_renk_Tb.Text == "" || inek_cins_Tb.Text == "" || inek_yas_Tb.Text == ""|| inek_dogumaralik_Tb.Text == "" || inek_otlak_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "insert into Inek_Kayit values ('" + inekAdi_Tb.Text + "','" + inek_kulakEtiketi_Tb.Text + "','" + inek_renk_Tb.Text + "','" + inek_cins_Tb.Text + "','" + yas + "','" + inek_dogumaralik_Tb.Text+ "','" + inek_otlak_Tb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İnek başarılı bir şekilde kaydedildi");

                    con.Close();

                    Goster();
                    Temizle();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

            
        }

        private void inek_tarih_dateTime_ValueChanged(object sender, EventArgs e)
        {
            yas = Convert.ToInt32((DateTime.Today.Date - inek_tarih_dateTime.Value.Date).Days)/365;

        }

        private void inek_tarih_dateTime_MouseLeave(object sender, EventArgs e)
        {
            yas = Convert.ToInt32((DateTime.Today.Date - inek_tarih_dateTime.Value.Date).Days) / 365;
            inek_yas_Tb.Text = "" + yas;
        }
        private void Temizle()
        {
            inekAdi_Tb.Text = "";
            inek_kulakEtiketi_Tb.Text = "";
            inek_renk_Tb.Text = "";
            inek_cins_Tb.Text = "";
            inek_yas_Tb.Text = "";
            inek_dogumaralik_Tb.Text = "";     
            inek_otlak_Tb.Text = "";

            tus = 0;
        }
        private void inekTemizle_button_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        int tus = 0;
        private void inek_liste_CustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            inekAdi_Tb.Text = inek_liste_CustomDataGrid.Rows[index].Cells[1].Value.ToString();
            inek_kulakEtiketi_Tb.Text = inek_liste_CustomDataGrid.Rows[index].Cells[2].Value.ToString();
            inek_renk_Tb.Text = inek_liste_CustomDataGrid.Rows[index].Cells[3].Value.ToString();
            inek_cins_Tb.Text = inek_liste_CustomDataGrid.Rows[index].Cells[4].Value.ToString();
            inek_dogumaralik_Tb.Text = inek_liste_CustomDataGrid.Rows[index].Cells[6].Value.ToString();
            inek_otlak_Tb.Text = inek_liste_CustomDataGrid.Rows[index].Cells[7].Value.ToString();

            if(inekAdi_Tb.Text == "")
            {
                tus = 0;
                yas = 0;
            }

            else
            {
                tus = Convert.ToInt32(inek_liste_CustomDataGrid.Rows[index].Cells[0].Value.ToString());
                yas = Convert.ToInt32(inek_liste_CustomDataGrid.Rows[index].Cells[5].Value.ToString());
            }
        }
        private void inekSil_button_Click(object sender, EventArgs e)
        {
            if (tus == 0)
            {
                MessageBox.Show("silmek için önce inek seçiniz");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "delete from Inek_Kayit where InekID=" + tus + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İnek başarılı bir şekilde silindi");
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

        private void inekDuzenle_button_Click(object sender, EventArgs e)
        {
            if (inekAdi_Tb.Text == "" || inek_kulakEtiketi_Tb.Text == "" || inek_renk_Tb.Text == "" || inek_cins_Tb.Text == "" || inek_yas_Tb.Text == "" || inek_dogumaralik_Tb.Text == "" || inek_otlak_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "update Inek_Kayit set InekAdi='"+inekAdi_Tb.Text+"',KulakEtiketi='"+inek_kulakEtiketi_Tb.Text+"',Renk='"+inek_renk_Tb.Text+"',Cins='"+inek_cins_Tb.Text+"',Yas='"+yas+"',DogumAralik='"+inek_dogumaralik_Tb.Text+"',Otlak='"+inek_otlak_Tb.Text+"' where InekID=" + tus + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İnek başarılı bir şekilde düzenlendi");

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

    }
}