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
    public partial class SaglikKaydet : Form
    {
        //SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        BaglantiSinifi bgl = new BaglantiSinifi();
        public SaglikKaydet()
        {
            InitializeComponent();
            EkleInekID();
            Goster();
        }

        private void inek_kayit_buton_Click(object sender, EventArgs e)
        {
            InekKayit ik = new InekKayit();
            ik.ShowDialog();
            this.Hide();
        }

        private void Cikis_Butonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sut_uretim_buton_Click(object sender, EventArgs e)
        {
            SutUretimKayit suk = new SutUretimKayit();
            suk.ShowDialog();
            this.Hide();
        }

        private void Sut_Satis_Buton_Click(object sender, EventArgs e)
        {
            SutSatisKayit ssk = new SutSatisKayit();
            ssk.ShowDialog();
            this.Hide();
        }

        private void Finans_Buton_Click(object sender, EventArgs e)
        {
            FinansKayit fk = new FinansKayit();
            fk.ShowDialog();
            this.Hide();
        }
        private void EkleInekID()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();

            SqlCommand com = new SqlCommand("select InekID from Inek_Kayit", con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("InekID", typeof(int));
            dt.Load(rdr);
            saglik_InekID_Cb.ValueMember = "InekID";
            saglik_InekID_Cb.DataSource = dt;

            con.Close();
        }
        private void Goster()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            string query = "select * from Saglik_Kayit1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            saglik_liste_CustomDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void GetInekAdi()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();

            string query = "select * from Inek_Kayit where InekID=" + saglik_InekID_Cb.SelectedValue.ToString() + "";
            SqlCommand com = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                saglik_InekAdi_Tb.Text = dr["InekAdi"].ToString();
            }

            con.Close();
        }

        private void SaglikKaydet_Load(object sender, EventArgs e)
        {

        }

        private void saglik_InekID_Cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetInekAdi();
        }

        private void Temizle()
        {
            saglik_TemsilciID_Tb.Text = "";
            saglik_InekAdi_Tb.Text = "";
            saglik_Durum_Tb.Text = "";
            saglik_TedaviMaliyet_Tb.Text = "";
            saglik_Teshis_Tb.Text = "";
            saglik_VetAdi_Tb.Text = "";
            saglik_Tedavi_Tb.Text = "";

            tus = 0;
        }

        private void saglik_Kaydet_Button_Click(object sender, EventArgs e)
        {
            if (saglik_InekID_Cb.SelectedIndex == -1 || saglik_InekAdi_Tb.Text == "" || saglik_Durum_Tb.Text == "" || saglik_TedaviMaliyet_Tb.Text == "" || saglik_VetAdi_Tb.Text == "" || saglik_Teshis_Tb.Text == ""||saglik_Tedavi_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "insert into Saglik_Kayit1 values ('" + saglik_InekID_Cb.SelectedValue.ToString() + "','" + saglik_InekAdi_Tb.Text + "','" + saglik_Tarih_dateTime.Value.Date + "','" + saglik_Durum_Tb.Text + "','" + saglik_Teshis_Tb.Text + "','" + saglik_Tedavi_Tb.Text + "','" + saglik_TedaviMaliyet_Tb.Text + "','" + saglik_VetAdi_Tb.Text+"')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saglık sorunu başarılı bir şekilde kaydedildi.");

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

        private void saglik_Guncelle_Button_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        int tus = 0;
        private void saglik_liste_CustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            saglik_TemsilciID_Tb.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[0].Value.ToString();
            saglik_InekID_Cb.SelectedValue = saglik_liste_CustomDataGrid.Rows[index].Cells[1].Value.ToString();
            saglik_InekAdi_Tb.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[2].Value.ToString();
            saglik_Tarih_dateTime.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[3].Value.ToString();
            saglik_Durum_Tb.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[4].Value.ToString();
            saglik_Teshis_Tb.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[5].Value.ToString();
            saglik_Tedavi_Tb.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[6].Value.ToString();
            saglik_TedaviMaliyet_Tb.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[7].Value.ToString();
            saglik_VetAdi_Tb.Text = saglik_liste_CustomDataGrid.Rows[index].Cells[8].Value.ToString();
            

            if (saglik_InekAdi_Tb.Text == "")
            {
                tus = 0;
            }

            else
            {
                tus = Convert.ToInt32(saglik_liste_CustomDataGrid.Rows[index].Cells[0].Value.ToString());
            }

        }

        private void saglik_Sil_Button_Click(object sender, EventArgs e)
        {
            if (tus == 0)
            {
                MessageBox.Show("silmek için önce sağlık durumu kayıtlı bir inek seçiniz");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "delete from Saglik_Kayit1 where TemsilciID=" + tus + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("sağlık durumu kayıtlı bir inek başarılı bir şekilde silindi");
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

        private void Saglik_Duzenle_Button_Click(object sender, EventArgs e)
        {
            if (saglik_InekID_Cb.SelectedIndex == -1 || saglik_InekAdi_Tb.Text == "" || saglik_Durum_Tb.Text == "" || saglik_TedaviMaliyet_Tb.Text == "" || saglik_VetAdi_Tb.Text == "" || saglik_Teshis_Tb.Text == "" || saglik_Tedavi_Tb.Text == "" || saglik_TemsilciID_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "update Saglik_Kayit1 set InekID=@InekID, InekAdi=@InekAdi, TemsilciTarih=@TemsilciTarih, Durum=@Durum, Teshis=@Teshis, Tedavi=@Tedavi, Maliyet=@Maliyet, VetAdi=@VetAdi where TemsilciID = @TemsilciID";

                    SqlCommand cmd = new SqlCommand(Query, con);

                    
                    cmd.Parameters.AddWithValue("@InekID", saglik_InekID_Cb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@InekAdi", saglik_InekAdi_Tb.Text);
                    cmd.Parameters.AddWithValue("@TemsilciTarih", saglik_Tarih_dateTime.Value.Date);
                    cmd.Parameters.AddWithValue("@Durum", saglik_Durum_Tb.Text);
                    cmd.Parameters.AddWithValue("@Teshis", saglik_Teshis_Tb.Text);
                    cmd.Parameters.AddWithValue("@Tedavi", saglik_Tedavi_Tb.Text);
                    cmd.Parameters.AddWithValue("@Maliyet", saglik_TedaviMaliyet_Tb.Text);
                    cmd.Parameters.AddWithValue("@VetAdi", saglik_VetAdi_Tb.Text);
                    cmd.Parameters.AddWithValue("@TemsilciID", saglik_TemsilciID_Tb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İneklerin sağlığı başarılı bir şekilde düzenlendi");

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
