namespace SutSatisOtomasyonu
{
    partial class CalisanKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanKayit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Finans_buton = new System.Windows.Forms.Label();
            this.Saglik_buton = new System.Windows.Forms.Label();
            this.SutUretim_Buton = new System.Windows.Forms.Label();
            this.SutSatis_buton = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.inekler_buton = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.su_Tarih = new System.Windows.Forms.Label();
            this.Calisan_DogumTarih_dateTime = new System.Windows.Forms.DateTimePicker();
            this.calisan_liste_CustomDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.calisan_Cinsiyet_Cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calisan_Temizle_Button = new System.Windows.Forms.Button();
            this.calisan_Sil_Button = new System.Windows.Forms.Button();
            this.calisan_Duzenle_Button = new System.Windows.Forms.Button();
            this.calisan_Kaydet_Button = new System.Windows.Forms.Button();
            this.calisan_Telefon_Tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.calisan_CalisanAdi_Tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.calisan_Adres_Tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cikis_Butonu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calisan_Sifre_Tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisan_liste_CustomDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis_Butonu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.Finans_buton);
            this.panel1.Controls.Add(this.Saglik_buton);
            this.panel1.Controls.Add(this.SutUretim_Buton);
            this.panel1.Controls.Add(this.SutSatis_buton);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.inekler_buton);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(10, 278);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(84, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 61;
            this.pictureBox7.TabStop = false;
            // 
            // Finans_buton
            // 
            this.Finans_buton.AutoSize = true;
            this.Finans_buton.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finans_buton.ForeColor = System.Drawing.Color.SlateBlue;
            this.Finans_buton.Location = new System.Drawing.Point(87, 557);
            this.Finans_buton.Name = "Finans_buton";
            this.Finans_buton.Size = new System.Drawing.Size(130, 40);
            this.Finans_buton.TabIndex = 60;
            this.Finans_buton.Text = "Finans";
            this.Finans_buton.Click += new System.EventHandler(this.Finans_buton_Click);
            // 
            // Saglik_buton
            // 
            this.Saglik_buton.AutoSize = true;
            this.Saglik_buton.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saglik_buton.ForeColor = System.Drawing.Color.SlateBlue;
            this.Saglik_buton.Location = new System.Drawing.Point(87, 354);
            this.Saglik_buton.Name = "Saglik_buton";
            this.Saglik_buton.Size = new System.Drawing.Size(123, 40);
            this.Saglik_buton.TabIndex = 57;
            this.Saglik_buton.Text = "Sağlık";
            this.Saglik_buton.Click += new System.EventHandler(this.Saglik_buton_Click);
            // 
            // SutUretim_Buton
            // 
            this.SutUretim_Buton.AutoSize = true;
            this.SutUretim_Buton.BackColor = System.Drawing.Color.White;
            this.SutUretim_Buton.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SutUretim_Buton.ForeColor = System.Drawing.Color.SlateBlue;
            this.SutUretim_Buton.Location = new System.Drawing.Point(86, 429);
            this.SutUretim_Buton.Name = "SutUretim_Buton";
            this.SutUretim_Buton.Size = new System.Drawing.Size(173, 34);
            this.SutUretim_Buton.TabIndex = 58;
            this.SutUretim_Buton.Text = "Süt Üretim";
            this.SutUretim_Buton.Click += new System.EventHandler(this.SutUretim_Buton_Click);
            // 
            // SutSatis_buton
            // 
            this.SutSatis_buton.AutoSize = true;
            this.SutSatis_buton.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SutSatis_buton.ForeColor = System.Drawing.Color.SlateBlue;
            this.SutSatis_buton.Location = new System.Drawing.Point(87, 493);
            this.SutSatis_buton.Name = "SutSatis_buton";
            this.SutSatis_buton.Size = new System.Drawing.Size(166, 40);
            this.SutSatis_buton.TabIndex = 59;
            this.SutSatis_buton.Text = "Süt Satış";
            this.SutSatis_buton.Click += new System.EventHandler(this.SutSatis_buton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 551);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 53);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 484);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 53;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 415);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // inekler_buton
            // 
            this.inekler_buton.AutoSize = true;
            this.inekler_buton.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inekler_buton.ForeColor = System.Drawing.Color.SlateBlue;
            this.inekler_buton.Location = new System.Drawing.Point(87, 290);
            this.inekler_buton.Name = "inekler_buton";
            this.inekler_buton.Size = new System.Drawing.Size(129, 40);
            this.inekler_buton.TabIndex = 55;
            this.inekler_buton.Text = "İnekler";
            this.inekler_buton.Click += new System.EventHandler(this.inekler_buton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // su_Tarih
            // 
            this.su_Tarih.AutoSize = true;
            this.su_Tarih.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.su_Tarih.ForeColor = System.Drawing.Color.White;
            this.su_Tarih.Location = new System.Drawing.Point(649, 90);
            this.su_Tarih.Name = "su_Tarih";
            this.su_Tarih.Size = new System.Drawing.Size(190, 30);
            this.su_Tarih.TabIndex = 49;
            this.su_Tarih.Text = "Doğum Tarihi";
            // 
            // Calisan_DogumTarih_dateTime
            // 
            this.Calisan_DogumTarih_dateTime.Location = new System.Drawing.Point(651, 138);
            this.Calisan_DogumTarih_dateTime.Name = "Calisan_DogumTarih_dateTime";
            this.Calisan_DogumTarih_dateTime.Size = new System.Drawing.Size(200, 22);
            this.Calisan_DogumTarih_dateTime.TabIndex = 48;
            // 
            // calisan_liste_CustomDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calisan_liste_CustomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.calisan_liste_CustomDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.calisan_liste_CustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calisan_liste_CustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calisan_liste_CustomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.calisan_liste_CustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calisan_liste_CustomDataGrid.DoubleBuffered = true;
            this.calisan_liste_CustomDataGrid.EnableHeadersVisualStyles = false;
            this.calisan_liste_CustomDataGrid.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.calisan_liste_CustomDataGrid.HeaderBgColor = System.Drawing.Color.DarkSlateBlue;
            this.calisan_liste_CustomDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.calisan_liste_CustomDataGrid.Location = new System.Drawing.Point(301, 412);
            this.calisan_liste_CustomDataGrid.Name = "calisan_liste_CustomDataGrid";
            this.calisan_liste_CustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.calisan_liste_CustomDataGrid.RowTemplate.Height = 24;
            this.calisan_liste_CustomDataGrid.Size = new System.Drawing.Size(952, 337);
            this.calisan_liste_CustomDataGrid.TabIndex = 47;
            this.calisan_liste_CustomDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calisan_liste_CustomDataGrid_CellContentClick);
            // 
            // calisan_Cinsiyet_Cb
            // 
            this.calisan_Cinsiyet_Cb.FormattingEnabled = true;
            this.calisan_Cinsiyet_Cb.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.calisan_Cinsiyet_Cb.Location = new System.Drawing.Point(979, 136);
            this.calisan_Cinsiyet_Cb.Name = "calisan_Cinsiyet_Cb";
            this.calisan_Cinsiyet_Cb.Size = new System.Drawing.Size(200, 24);
            this.calisan_Cinsiyet_Cb.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(646, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 30);
            this.label8.TabIndex = 43;
            this.label8.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(340, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(340, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Çalışan Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(974, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cinsiyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(677, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 34);
            this.label2.TabIndex = 38;
            this.label2.Text = "Çalışan Listesi";
            // 
            // calisan_Temizle_Button
            // 
            this.calisan_Temizle_Button.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisan_Temizle_Button.ForeColor = System.Drawing.Color.SlateBlue;
            this.calisan_Temizle_Button.Location = new System.Drawing.Point(1011, 280);
            this.calisan_Temizle_Button.Name = "calisan_Temizle_Button";
            this.calisan_Temizle_Button.Size = new System.Drawing.Size(135, 48);
            this.calisan_Temizle_Button.TabIndex = 37;
            this.calisan_Temizle_Button.Text = "Temizle";
            this.calisan_Temizle_Button.UseVisualStyleBackColor = true;
            this.calisan_Temizle_Button.Click += new System.EventHandler(this.calisan_Temizle_Button_Click);
            // 
            // calisan_Sil_Button
            // 
            this.calisan_Sil_Button.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisan_Sil_Button.ForeColor = System.Drawing.Color.SlateBlue;
            this.calisan_Sil_Button.Location = new System.Drawing.Point(805, 280);
            this.calisan_Sil_Button.Name = "calisan_Sil_Button";
            this.calisan_Sil_Button.Size = new System.Drawing.Size(135, 48);
            this.calisan_Sil_Button.TabIndex = 36;
            this.calisan_Sil_Button.Text = "Sil";
            this.calisan_Sil_Button.UseVisualStyleBackColor = true;
            this.calisan_Sil_Button.Click += new System.EventHandler(this.calisan_Sil_Button_Click);
            // 
            // calisan_Duzenle_Button
            // 
            this.calisan_Duzenle_Button.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisan_Duzenle_Button.ForeColor = System.Drawing.Color.SlateBlue;
            this.calisan_Duzenle_Button.Location = new System.Drawing.Point(605, 280);
            this.calisan_Duzenle_Button.Name = "calisan_Duzenle_Button";
            this.calisan_Duzenle_Button.Size = new System.Drawing.Size(135, 48);
            this.calisan_Duzenle_Button.TabIndex = 35;
            this.calisan_Duzenle_Button.Text = "Düzenle";
            this.calisan_Duzenle_Button.UseVisualStyleBackColor = true;
            this.calisan_Duzenle_Button.Click += new System.EventHandler(this.calisan_Duzenle_Button_Click);
            // 
            // calisan_Kaydet_Button
            // 
            this.calisan_Kaydet_Button.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisan_Kaydet_Button.ForeColor = System.Drawing.Color.SlateBlue;
            this.calisan_Kaydet_Button.Location = new System.Drawing.Point(410, 280);
            this.calisan_Kaydet_Button.Name = "calisan_Kaydet_Button";
            this.calisan_Kaydet_Button.Size = new System.Drawing.Size(135, 48);
            this.calisan_Kaydet_Button.TabIndex = 34;
            this.calisan_Kaydet_Button.Text = "Kaydet";
            this.calisan_Kaydet_Button.UseVisualStyleBackColor = true;
            this.calisan_Kaydet_Button.Click += new System.EventHandler(this.calisan_Kaydet_Button_Click);
            // 
            // calisan_Telefon_Tb
            // 
            this.calisan_Telefon_Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calisan_Telefon_Tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.calisan_Telefon_Tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calisan_Telefon_Tb.HintForeColor = System.Drawing.Color.Empty;
            this.calisan_Telefon_Tb.HintText = "";
            this.calisan_Telefon_Tb.isPassword = false;
            this.calisan_Telefon_Tb.LineFocusedColor = System.Drawing.Color.White;
            this.calisan_Telefon_Tb.LineIdleColor = System.Drawing.Color.White;
            this.calisan_Telefon_Tb.LineMouseHoverColor = System.Drawing.Color.White;
            this.calisan_Telefon_Tb.LineThickness = 3;
            this.calisan_Telefon_Tb.Location = new System.Drawing.Point(345, 216);
            this.calisan_Telefon_Tb.Margin = new System.Windows.Forms.Padding(4);
            this.calisan_Telefon_Tb.Name = "calisan_Telefon_Tb";
            this.calisan_Telefon_Tb.Size = new System.Drawing.Size(200, 33);
            this.calisan_Telefon_Tb.TabIndex = 30;
            this.calisan_Telefon_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // calisan_CalisanAdi_Tb
            // 
            this.calisan_CalisanAdi_Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calisan_CalisanAdi_Tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.calisan_CalisanAdi_Tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calisan_CalisanAdi_Tb.HintForeColor = System.Drawing.Color.Empty;
            this.calisan_CalisanAdi_Tb.HintText = "";
            this.calisan_CalisanAdi_Tb.isPassword = false;
            this.calisan_CalisanAdi_Tb.LineFocusedColor = System.Drawing.Color.White;
            this.calisan_CalisanAdi_Tb.LineIdleColor = System.Drawing.Color.White;
            this.calisan_CalisanAdi_Tb.LineMouseHoverColor = System.Drawing.Color.White;
            this.calisan_CalisanAdi_Tb.LineThickness = 3;
            this.calisan_CalisanAdi_Tb.Location = new System.Drawing.Point(345, 127);
            this.calisan_CalisanAdi_Tb.Margin = new System.Windows.Forms.Padding(4);
            this.calisan_CalisanAdi_Tb.Name = "calisan_CalisanAdi_Tb";
            this.calisan_CalisanAdi_Tb.Size = new System.Drawing.Size(200, 33);
            this.calisan_CalisanAdi_Tb.TabIndex = 29;
            this.calisan_CalisanAdi_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // calisan_Adres_Tb
            // 
            this.calisan_Adres_Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calisan_Adres_Tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.calisan_Adres_Tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calisan_Adres_Tb.HintForeColor = System.Drawing.Color.Empty;
            this.calisan_Adres_Tb.HintText = "";
            this.calisan_Adres_Tb.isPassword = false;
            this.calisan_Adres_Tb.LineFocusedColor = System.Drawing.Color.White;
            this.calisan_Adres_Tb.LineIdleColor = System.Drawing.Color.White;
            this.calisan_Adres_Tb.LineMouseHoverColor = System.Drawing.Color.White;
            this.calisan_Adres_Tb.LineThickness = 3;
            this.calisan_Adres_Tb.Location = new System.Drawing.Point(654, 216);
            this.calisan_Adres_Tb.Margin = new System.Windows.Forms.Padding(4);
            this.calisan_Adres_Tb.Name = "calisan_Adres_Tb";
            this.calisan_Adres_Tb.Size = new System.Drawing.Size(200, 33);
            this.calisan_Adres_Tb.TabIndex = 28;
            this.calisan_Adres_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Cikis_Butonu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 53);
            this.panel2.TabIndex = 50;
            // 
            // Cikis_Butonu
            // 
            this.Cikis_Butonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cikis_Butonu.Image = ((System.Drawing.Image)(resources.GetObject("Cikis_Butonu.Image")));
            this.Cikis_Butonu.Location = new System.Drawing.Point(933, 0);
            this.Cikis_Butonu.Name = "Cikis_Butonu";
            this.Cikis_Butonu.Size = new System.Drawing.Size(61, 50);
            this.Cikis_Butonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cikis_Butonu.TabIndex = 51;
            this.Cikis_Butonu.TabStop = false;
            this.Cikis_Butonu.Click += new System.EventHandler(this.Cikis_Butonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(374, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Çalışan Kayıt Ekranı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(974, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 30);
            this.label6.TabIndex = 52;
            this.label6.Text = "Şifre";
            // 
            // calisan_Sifre_Tb
            // 
            this.calisan_Sifre_Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calisan_Sifre_Tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.calisan_Sifre_Tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calisan_Sifre_Tb.HintForeColor = System.Drawing.Color.Empty;
            this.calisan_Sifre_Tb.HintText = "";
            this.calisan_Sifre_Tb.isPassword = false;
            this.calisan_Sifre_Tb.LineFocusedColor = System.Drawing.Color.White;
            this.calisan_Sifre_Tb.LineIdleColor = System.Drawing.Color.White;
            this.calisan_Sifre_Tb.LineMouseHoverColor = System.Drawing.Color.White;
            this.calisan_Sifre_Tb.LineThickness = 3;
            this.calisan_Sifre_Tb.Location = new System.Drawing.Point(979, 216);
            this.calisan_Sifre_Tb.Margin = new System.Windows.Forms.Padding(4);
            this.calisan_Sifre_Tb.Name = "calisan_Sifre_Tb";
            this.calisan_Sifre_Tb.Size = new System.Drawing.Size(200, 33);
            this.calisan_Sifre_Tb.TabIndex = 51;
            this.calisan_Sifre_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CalisanKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1281, 768);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calisan_Sifre_Tb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.su_Tarih);
            this.Controls.Add(this.Calisan_DogumTarih_dateTime);
            this.Controls.Add(this.calisan_liste_CustomDataGrid);
            this.Controls.Add(this.calisan_Cinsiyet_Cb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calisan_Temizle_Button);
            this.Controls.Add(this.calisan_Sil_Button);
            this.Controls.Add(this.calisan_Duzenle_Button);
            this.Controls.Add(this.calisan_Kaydet_Button);
            this.Controls.Add(this.calisan_Telefon_Tb);
            this.Controls.Add(this.calisan_CalisanAdi_Tb);
            this.Controls.Add(this.calisan_Adres_Tb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(933, 2);
            this.Name = "CalisanKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisanKayit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisan_liste_CustomDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis_Butonu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label su_Tarih;
        private System.Windows.Forms.DateTimePicker Calisan_DogumTarih_dateTime;
        private Bunifu.Framework.UI.BunifuCustomDataGrid calisan_liste_CustomDataGrid;
        private System.Windows.Forms.ComboBox calisan_Cinsiyet_Cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calisan_Temizle_Button;
        private System.Windows.Forms.Button calisan_Sil_Button;
        private System.Windows.Forms.Button calisan_Duzenle_Button;
        private System.Windows.Forms.Button calisan_Kaydet_Button;
        private Bunifu.Framework.UI.BunifuMaterialTextbox calisan_Telefon_Tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox calisan_CalisanAdi_Tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox calisan_Adres_Tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Cikis_Butonu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox calisan_Sifre_Tb;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label Finans_buton;
        private System.Windows.Forms.Label Saglik_buton;
        private System.Windows.Forms.Label SutUretim_Buton;
        private System.Windows.Forms.Label SutSatis_buton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label inekler_buton;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}