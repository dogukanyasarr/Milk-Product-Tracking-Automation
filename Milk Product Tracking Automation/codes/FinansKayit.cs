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
    public partial class FinansKayit : Form
    {
        // SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        BaglantiSinifi bgl = new BaglantiSinifi();
        public FinansKayit()
        {
            InitializeComponent();
            GosterHarcama();
            GosterGelir();
        }

        private void Finans_Buton_Click(object sender, EventArgs e)
        {

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

        private void SutSatis_Buton_Click(object sender, EventArgs e)
        {
            SutSatisKayit ssk = new SutSatisKayit();
            ssk.ShowDialog();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GosterHarcama()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            string query = "select * from Harcama_Kayit";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            finansHarcamalar_liste_CustomDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void TemizleHarcama()
        {
            finansHarcamalar_ToplamMiktar_Tb.Text = "";

        }

        private void finans_Kaydet_Button_Click(object sender, EventArgs e)
        {
            if (finansHarcamalar_Amaç_Cb.SelectedIndex == -1 || finansHarcamalar_ToplamMiktar_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "insert into Harcama_Kayit values ('" + finansHarcamalar_Tarih_dateTime.Value.Date + "','" + finansHarcamalar_Amaç_Cb.SelectedItem.ToString() + "','" + finansHarcamalar_ToplamMiktar_Tb.Text + "','" + calisanID_lbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Harcamalar başarılı bir şekilde kaydedildi");

                    con.Close();

                    GosterHarcama();
                    TemizleHarcama();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

            
        }
        private void GosterGelir()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            string query = "select * from Gelir_Kayit";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            finansGelirler_liste_CustomDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void TemizleGelir()
        {
            finansGelirler_Amac_Cb.SelectedIndex = -1;
            finansGelirler_ToplamMiktar_Tb.Text = "";

        }
        private void FinansGelirler_Kaydet_Button_Click(object sender, EventArgs e)
        {
            if (finansGelirler_Amac_Cb.SelectedIndex == -1 || finansGelirler_ToplamMiktar_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "insert into Gelir_Kayit values ('" + finansGelirler_Tarih_dateTime.Value.Date + "','" + finansGelirler_Amac_Cb.SelectedItem.ToString() + "','" + finansGelirler_ToplamMiktar_Tb.Text + "','" + calisanID_lbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gelirler başarılı bir şekilde kaydedildi");

                    con.Close();

                    GosterGelir();
                    TemizleGelir();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

            
        }

        private void gostergePaneli_Button_Click(object sender, EventArgs e)
        {
            GostergePaneliKayit gpk = new GostergePaneliKayit();
            gpk.ShowDialog();
            this.Hide();
        }
    }
}
