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
    public partial class SutUretimKayit : Form
    {
        // SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        BaglantiSinifi bgl = new BaglantiSinifi();
        public SutUretimKayit()
        {
            InitializeComponent();
            EkleInekID();
            Goster();
        }

        private void Cikis_Butonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Oturumu_Kapat_Buton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            su_InekID_Cb.ValueMember = "InekID";
            su_InekID_Cb.DataSource = dt;

            con.Close();
        }
        private void Goster()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            string query = "select * from Sut_Uretim_Kayit";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sutUretim_liste_CustomDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Temizle()
        {
            su_InekAdi_Tb.Text = "";
            su_SabahSut_Tb.Text = "";
            su_OglenSut_Tb.Text = "";
            su_AksamSut_Tb.Text = "";
            su_ToplamSut_Tb.Text = "";

            tus = 0;

        }

        private void GetInekAdi()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();

            string query = "select * from Inek_Kayit where InekID=" + su_InekID_Cb.SelectedValue.ToString() + "";
            SqlCommand com = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                su_InekAdi_Tb.Text = dr["InekAdi"].ToString();
            }

            con.Close();
        }

        private void sutUretim_Kaydet_Button_Click(object sender, EventArgs e)
        {
            if (su_InekID_Cb.SelectedIndex == -1 || su_InekAdi_Tb.Text == "" || su_SabahSut_Tb.Text == "" || su_OglenSut_Tb.Text == "" || su_AksamSut_Tb.Text == "" || su_ToplamSut_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "insert into Sut_Uretim_Kayit values ('" + su_InekID_Cb.SelectedValue.ToString() + "','" + su_InekAdi_Tb.Text + "','" + su_SabahSut_Tb.Text + "','" + su_OglenSut_Tb.Text + "','" + su_AksamSut_Tb.Text + "','" + su_ToplamSut_Tb.Text + "','" + su_Tarih_dateTime.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("süt başarılı bir şekilde kaydedildi");

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

        private void sutUretim_Temizle_Button_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void su_InekID_Cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetInekAdi();
        }

        private void su_AksamSut_Tb_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void su_AksamSut_Tb_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            int toplam = Convert.ToInt32(su_SabahSut_Tb.Text) + Convert.ToInt32(su_OglenSut_Tb.Text) + Convert.ToInt32(su_AksamSut_Tb.Text);
            su_ToplamSut_Tb.Text = "" + toplam;

            con.Close();
        }

        int tus = 0;
        private void sutUretim_liste_CustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            su_InekID_Cb.SelectedValue = sutUretim_liste_CustomDataGrid.Rows[index].Cells[1].Value.ToString();
            su_InekAdi_Tb.Text = sutUretim_liste_CustomDataGrid.Rows[index].Cells[2].Value.ToString();
            su_SabahSut_Tb.Text = sutUretim_liste_CustomDataGrid.Rows[index].Cells[3].Value.ToString();
            su_OglenSut_Tb.Text = sutUretim_liste_CustomDataGrid.Rows[index].Cells[4].Value.ToString();
            su_AksamSut_Tb.Text = sutUretim_liste_CustomDataGrid.Rows[index].Cells[5].Value.ToString();
            su_ToplamSut_Tb.Text = sutUretim_liste_CustomDataGrid.Rows[index].Cells[6].Value.ToString();
            su_Tarih_dateTime.Text = sutUretim_liste_CustomDataGrid.Rows[index].Cells[7].Value.ToString();

            if (su_InekAdi_Tb.Text == "")
            {
                tus = 0;
            }

            else
            {
                tus = Convert.ToInt32(sutUretim_liste_CustomDataGrid.Rows[index].Cells[0].Value.ToString());
            }
        }
        private void sutUretim_Sil_Button_Click(object sender, EventArgs e)
        {
            if (tus == 0)
            {
                MessageBox.Show("silmek için önce süt seçiniz");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "delete from Sut_Uretim_Kayit where SutID=" + tus + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Süt başarılı bir şekilde silindi");
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
        private void sutUretim_Duzenle_Button_Click(object sender, EventArgs e)
        {
            if (su_InekID_Cb.SelectedIndex == -1 || su_InekAdi_Tb.Text == "" || su_SabahSut_Tb.Text == "" || su_OglenSut_Tb.Text == "" || su_AksamSut_Tb.Text == "" || su_ToplamSut_Tb.Text == "")
            {
                MessageBox.Show("Bilgileriniz eksik");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(bgl.Adres);
                    con.Open();
                    string Query = "update Sut_Uretim_Kayit set InekAdi=@InekAdi, SabahSut=@SabahSut, OgleSut=@OgleSut, AksamSut=@AksamSut, ToplamSut=@ToplamSut, Tarih=@Tarih where InekID = @InekID";

                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.Parameters.AddWithValue("@InekAdi", su_InekAdi_Tb.Text);
                    cmd.Parameters.AddWithValue("@SabahSut", su_SabahSut_Tb.Text);
                    cmd.Parameters.AddWithValue("@OgleSut", su_OglenSut_Tb.Text);
                    cmd.Parameters.AddWithValue("@AksamSut", su_AksamSut_Tb.Text);
                    cmd.Parameters.AddWithValue("@ToplamSut", su_ToplamSut_Tb.Text);
                    cmd.Parameters.AddWithValue("@Tarih", su_Tarih_dateTime.Value.Date);
                    cmd.Parameters.AddWithValue("@InekID", su_InekID_Cb.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Süt başarılı bir şekilde düzenlendi");

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

        private void SutUretimKayit_Load(object sender, EventArgs e)
        {

        }
    }
}