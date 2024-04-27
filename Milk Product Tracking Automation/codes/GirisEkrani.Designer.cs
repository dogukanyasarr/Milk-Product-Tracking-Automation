namespace SutSatisOtomasyonu
{
    partial class GirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.kullanici_adi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.kullanici_adi_textBox = new System.Windows.Forms.TextBox();
            this.sifre_textBox2 = new System.Windows.Forms.TextBox();
            this.roller_Cb = new System.Windows.Forms.ComboBox();
            this.giris_button = new System.Windows.Forms.Button();
            this.Sifremi_Unuttum_linkLbl = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sıfırla_Lbl = new System.Windows.Forms.Label();
            this.cikis_Button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikis_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 454);
            this.panel1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(318, 34);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(184, 167);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.AutoSize = true;
            this.kullanici_adi.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_adi.ForeColor = System.Drawing.Color.White;
            this.kullanici_adi.Location = new System.Drawing.Point(158, 277);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(193, 30);
            this.kullanici_adi.TabIndex = 2;
            this.kullanici_adi.Text = "Kullanıcı Adı:";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.ForeColor = System.Drawing.Color.White;
            this.sifre.Location = new System.Drawing.Point(269, 316);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(82, 30);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre:";
            // 
            // kullanici_adi_textBox
            // 
            this.kullanici_adi_textBox.BackColor = System.Drawing.Color.White;
            this.kullanici_adi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi_textBox.ForeColor = System.Drawing.Color.SlateBlue;
            this.kullanici_adi_textBox.Location = new System.Drawing.Point(357, 284);
            this.kullanici_adi_textBox.Name = "kullanici_adi_textBox";
            this.kullanici_adi_textBox.Size = new System.Drawing.Size(216, 22);
            this.kullanici_adi_textBox.TabIndex = 4;
            // 
            // sifre_textBox2
            // 
            this.sifre_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_textBox2.ForeColor = System.Drawing.Color.SlateBlue;
            this.sifre_textBox2.Location = new System.Drawing.Point(357, 323);
            this.sifre_textBox2.Name = "sifre_textBox2";
            this.sifre_textBox2.PasswordChar = '·';
            this.sifre_textBox2.Size = new System.Drawing.Size(216, 22);
            this.sifre_textBox2.TabIndex = 5;
            // 
            // roller_Cb
            // 
            this.roller_Cb.BackColor = System.Drawing.Color.SlateBlue;
            this.roller_Cb.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roller_Cb.ForeColor = System.Drawing.Color.White;
            this.roller_Cb.FormattingEnabled = true;
            this.roller_Cb.Items.AddRange(new object[] {
            "admin",
            "calısan"});
            this.roller_Cb.Location = new System.Drawing.Point(484, 234);
            this.roller_Cb.Name = "roller_Cb";
            this.roller_Cb.Size = new System.Drawing.Size(161, 30);
            this.roller_Cb.TabIndex = 6;
            this.roller_Cb.Text = "Rol Seçiniz";
            // 
            // giris_button
            // 
            this.giris_button.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_button.ForeColor = System.Drawing.Color.SlateBlue;
            this.giris_button.Location = new System.Drawing.Point(427, 367);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(146, 37);
            this.giris_button.TabIndex = 7;
            this.giris_button.Text = "Giriş";
            this.giris_button.UseVisualStyleBackColor = true;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // Sifremi_Unuttum_linkLbl
            // 
            this.Sifremi_Unuttum_linkLbl.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Sifremi_Unuttum_linkLbl.AutoSize = true;
            this.Sifremi_Unuttum_linkLbl.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sifremi_Unuttum_linkLbl.LinkColor = System.Drawing.Color.White;
            this.Sifremi_Unuttum_linkLbl.Location = new System.Drawing.Point(206, 377);
            this.Sifremi_Unuttum_linkLbl.Name = "Sifremi_Unuttum_linkLbl";
            this.Sifremi_Unuttum_linkLbl.Size = new System.Drawing.Size(145, 20);
            this.Sifremi_Unuttum_linkLbl.TabIndex = 10;
            this.Sifremi_Unuttum_linkLbl.TabStop = true;
            this.Sifremi_Unuttum_linkLbl.Text = "Şifremi Unuttum";
            this.Sifremi_Unuttum_linkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sifremi_Unuttum_Link_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cikis_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(681, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 454);
            this.panel2.TabIndex = 11;
            // 
            // sıfırla_Lbl
            // 
            this.sıfırla_Lbl.AutoSize = true;
            this.sıfırla_Lbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sıfırla_Lbl.ForeColor = System.Drawing.Color.White;
            this.sıfırla_Lbl.Location = new System.Drawing.Point(462, 414);
            this.sıfırla_Lbl.Name = "sıfırla_Lbl";
            this.sıfırla_Lbl.Size = new System.Drawing.Size(84, 25);
            this.sıfırla_Lbl.TabIndex = 12;
            this.sıfırla_Lbl.Text = "Sıfırla";
            this.sıfırla_Lbl.Click += new System.EventHandler(this.sıfırla_Lbl_Click);
            // 
            // cikis_Button
            // 
            this.cikis_Button.Image = ((System.Drawing.Image)(resources.GetObject("cikis_Button.Image")));
            this.cikis_Button.Location = new System.Drawing.Point(59, 3);
            this.cikis_Button.Name = "cikis_Button";
            this.cikis_Button.Size = new System.Drawing.Size(61, 50);
            this.cikis_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cikis_Button.TabIndex = 0;
            this.cikis_Button.TabStop = false;
            this.cikis_Button.Click += new System.EventHandler(this.cikis_Button_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(805, 454);
            this.Controls.Add(this.sıfırla_Lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Sifremi_Unuttum_linkLbl);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.roller_Cb);
            this.Controls.Add(this.sifre_textBox2);
            this.Controls.Add(this.kullanici_adi_textBox);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cikis_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label kullanici_adi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox kullanici_adi_textBox;
        private System.Windows.Forms.TextBox sifre_textBox2;
        private System.Windows.Forms.ComboBox roller_Cb;
        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.LinkLabel Sifremi_Unuttum_linkLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sıfırla_Lbl;
        private System.Windows.Forms.PictureBox cikis_Button;
    }
}