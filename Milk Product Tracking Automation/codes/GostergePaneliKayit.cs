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
    public partial class GostergePaneliKayit : Form
    {
        //SqlConnection con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = SutUretimDb; Integrated Security = True");
        BaglantiSinifi bgl = new BaglantiSinifi();
        public GostergePaneliKayit()
        {
            InitializeComponent();
            Finans();
            Lojistik();
        }
        private void finans_Bakiye_Click(object sender, EventArgs e)
        {

        }
        private void cikis_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Inek_Button_Click(object sender, EventArgs e)
        {
            InekKayit ik = new InekKayit();
            ik.ShowDialog();
            this.Hide();

        }

        private void Saglik_Button_Click(object sender, EventArgs e)
        {
            SaglikKaydet sk = new SaglikKaydet();
            sk.ShowDialog();
            this.Hide();

        }

        private void SutUretim_Button_Click(object sender, EventArgs e)
        {
            SutUretimKayit suk = new SutUretimKayit();
            suk.ShowDialog();
            this.Hide();
        }

        private void SutSatis_Button_Click(object sender, EventArgs e)
        {
            SutSatisKayit ssk = new SutSatisKayit();
            ssk.ShowDialog();
            this.Hide();

        }

        private void Finans_Button_Click(object sender, EventArgs e)
        {
            FinansKayit fk = new FinansKayit();
            fk.ShowDialog();
            this.Hide();

        }

        private void GostergePaneliKayit_Load(object sender, EventArgs e)
        {

        }

        private void Finans()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(GelirToplam) from Gelir_Kayit", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(HarcamaToplam) from Harcama_Kayit", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            finans_gelir.Text = "£" + dt.Rows[0][0].ToString();

            DataTable dt2 = new DataTable();
            sda.Fill(dt2);

            

            finans_Harcama.Text = "£" + 49090.5;

            con.Close();

            int gelir;
            int harcama;
            double bakiye;

            gelir = Convert.ToInt32(dt.Rows[0][0].ToString());
            harcama = Convert.ToInt32(dt.Rows[0][0].ToString());
            bakiye =  gelir - (0.3 * harcama);
            finans_Bakiye.Text = "£" + bakiye;

           

        }

        private void Lojistik()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Inek_Kayit", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(ToplamSut) from Sut_Uretim_Kayit", con);
            SqlDataAdapter sda2 = new SqlDataAdapter("select Count(*) from Calisan_Kayit", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
        
            lojistik_Inek.Text= dt.Rows[0][0].ToString();

            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            lojistik_Sls.Text = dt1.Rows[0][0].ToString() + " litre";

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            lojistik_Calisanlar.Text = dt2.Rows[0][0].ToString();

            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
