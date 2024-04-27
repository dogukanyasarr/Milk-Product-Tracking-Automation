using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SutSatisOtomasyonu
{
    public partial class yuklemeekran : Form
    {
        public yuklemeekran()
        {
            InitializeComponent();

        }
        int Ilerleme = 1;
        private void yuklemeekran_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void IlkEkranProgressBar_progressChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            IlkEkranProgressBar.Value = Ilerleme;
            Ilerleme++;

            if (Ilerleme > 100)
            {
                timer1.Stop();

                GirisEkrani ge = new GirisEkrani();
                ge.ShowDialog();
                this.Hide();
            }


        }
    }
}
