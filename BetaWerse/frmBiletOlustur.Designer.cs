namespace BetaWerse
{
    partial class frmBiletOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiletOlustur));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            txtBarkod = new TextBox();
            groupBox2 = new GroupBox();
            txtAdSoyad = new TextBox();
            groupBox3 = new GroupBox();
            txtTelNo = new TextBox();
            groupBox4 = new GroupBox();
            cbFilmAdi = new ComboBox();
            groupBox5 = new GroupBox();
            cbTarıh = new ComboBox();
            lblGGaaYY = new Label();
            groupBox6 = new GroupBox();
            lblSeansSeç = new Label();
            panelSEANS = new FlowLayoutPanel();
            groupBox7 = new GroupBox();
            lblKoltukSayisi = new Label();
            cbSalon = new ComboBox();
            groupBox8 = new GroupBox();
            cbBiletTürü = new ComboBox();
            groupBox9 = new GroupBox();
            txtKoltuklar = new TextBox();
            btnOlustur = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            KoltukPaneli = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            lblGelenKoltuk = new Label();
            listeGelenKoltuk = new ListBox();
            lbBelirlenen = new ListBox();
            btnTemizle = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 120);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 35);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, -1);
            label2.Name = "label2";
            label2.Size = new Size(329, 32);
            label2.TabIndex = 2;
            label2.Text = "[BİLET OLUŞTURMA EKRANI]";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(850, 0);
            button1.Name = "button1";
            button1.Size = new Size(34, 35);
            button1.TabIndex = 1;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBarkod);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(9, 3, 3, 3);
            groupBox1.Size = new Size(263, 59);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLET NUMARASI";
            // 
            // txtBarkod
            // 
            txtBarkod.BorderStyle = BorderStyle.None;
            txtBarkod.Dock = DockStyle.Bottom;
            txtBarkod.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBarkod.ForeColor = Color.FromArgb(84, 110, 120);
            txtBarkod.Location = new Point(9, 33);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(251, 23);
            txtBarkod.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAdSoyad);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox2.Location = new Point(12, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(9, 3, 3, 3);
            groupBox2.Size = new Size(263, 59);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "AD SOYAD";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BorderStyle = BorderStyle.None;
            txtAdSoyad.Dock = DockStyle.Bottom;
            txtAdSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAdSoyad.ForeColor = Color.FromArgb(84, 110, 120);
            txtAdSoyad.Location = new Point(9, 33);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(251, 23);
            txtAdSoyad.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTelNo);
            groupBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox3.Location = new Point(12, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(9, 3, 3, 3);
            groupBox3.Size = new Size(263, 59);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "TELEFON NUMARASI";
            // 
            // txtTelNo
            // 
            txtTelNo.BorderStyle = BorderStyle.None;
            txtTelNo.Dock = DockStyle.Bottom;
            txtTelNo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtTelNo.ForeColor = Color.FromArgb(84, 110, 120);
            txtTelNo.Location = new Point(9, 33);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(251, 23);
            txtTelNo.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbFilmAdi);
            groupBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox4.Location = new Point(12, 236);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(9, 3, 3, 3);
            groupBox4.Size = new Size(263, 59);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "FİLM ADI";
            // 
            // cbFilmAdi
            // 
            cbFilmAdi.BackColor = Color.White;
            cbFilmAdi.Dock = DockStyle.Fill;
            cbFilmAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilmAdi.FlatStyle = FlatStyle.Flat;
            cbFilmAdi.ForeColor = Color.FromArgb(84, 110, 120);
            cbFilmAdi.FormattingEnabled = true;
            cbFilmAdi.Items.AddRange(new object[] { "AS", "SA", "ASA", "SAS", "SASA", "ASAS" });
            cbFilmAdi.Location = new Point(9, 26);
            cbFilmAdi.Name = "cbFilmAdi";
            cbFilmAdi.Size = new Size(251, 31);
            cbFilmAdi.TabIndex = 0;
            cbFilmAdi.SelectedIndexChanged += cbFilmAdi_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbTarıh);
            groupBox5.Controls.Add(lblGGaaYY);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox5.Location = new Point(12, 301);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(9, 3, 3, 3);
            groupBox5.Size = new Size(263, 59);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "TARİH";
            // 
            // cbTarıh
            // 
            cbTarıh.BackColor = Color.White;
            cbTarıh.Dock = DockStyle.Fill;
            cbTarıh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTarıh.FlatStyle = FlatStyle.Flat;
            cbTarıh.ForeColor = Color.FromArgb(84, 110, 120);
            cbTarıh.FormattingEnabled = true;
            cbTarıh.Items.AddRange(new object[] { "" });
            cbTarıh.Location = new Point(9, 26);
            cbTarıh.Name = "cbTarıh";
            cbTarıh.Size = new Size(251, 31);
            cbTarıh.TabIndex = 33;
            cbTarıh.SelectedIndexChanged += cbTarıh_SelectedIndexChanged;
            // 
            // lblGGaaYY
            // 
            lblGGaaYY.AutoSize = true;
            lblGGaaYY.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGGaaYY.ForeColor = Color.Peru;
            lblGGaaYY.Location = new Point(183, 1);
            lblGGaaYY.Name = "lblGGaaYY";
            lblGGaaYY.Size = new Size(79, 19);
            lblGGaaYY.TabIndex = 32;
            lblGGaaYY.Text = "gg/aa/yyyy";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblSeansSeç);
            groupBox6.Controls.Add(panelSEANS);
            groupBox6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox6.Location = new Point(12, 366);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(9, 3, 3, 3);
            groupBox6.Size = new Size(263, 96);
            groupBox6.TabIndex = 32;
            groupBox6.TabStop = false;
            groupBox6.Text = "SAAT/SEANS";
            // 
            // lblSeansSeç
            // 
            lblSeansSeç.AutoSize = true;
            lblSeansSeç.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSeansSeç.ForeColor = Color.Peru;
            lblSeansSeç.Location = new Point(196, 0);
            lblSeansSeç.Name = "lblSeansSeç";
            lblSeansSeç.Size = new Size(61, 19);
            lblSeansSeç.TabIndex = 37;
            lblSeansSeç.Text = "lblSeans";
            lblSeansSeç.Visible = false;
            // 
            // panelSEANS
            // 
            panelSEANS.AutoScroll = true;
            panelSEANS.Dock = DockStyle.Fill;
            panelSEANS.Location = new Point(9, 26);
            panelSEANS.Name = "panelSEANS";
            panelSEANS.Size = new Size(251, 67);
            panelSEANS.TabIndex = 37;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lblKoltukSayisi);
            groupBox7.Controls.Add(cbSalon);
            groupBox7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox7.Location = new Point(12, 459);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(9, 3, 3, 3);
            groupBox7.Size = new Size(263, 59);
            groupBox7.TabIndex = 33;
            groupBox7.TabStop = false;
            groupBox7.Text = "SALON ADI";
            // 
            // lblKoltukSayisi
            // 
            lblKoltukSayisi.AutoSize = true;
            lblKoltukSayisi.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKoltukSayisi.ForeColor = Color.Peru;
            lblKoltukSayisi.Location = new Point(155, 3);
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Size = new Size(102, 19);
            lblKoltukSayisi.TabIndex = 37;
            lblKoltukSayisi.Text = "lblKoltukSayisi";
            lblKoltukSayisi.Visible = false;
            // 
            // cbSalon
            // 
            cbSalon.BackColor = Color.White;
            cbSalon.Dock = DockStyle.Fill;
            cbSalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSalon.FlatStyle = FlatStyle.Flat;
            cbSalon.ForeColor = Color.FromArgb(84, 110, 120);
            cbSalon.FormattingEnabled = true;
            cbSalon.Location = new Point(9, 26);
            cbSalon.Name = "cbSalon";
            cbSalon.Size = new Size(251, 31);
            cbSalon.TabIndex = 0;
            cbSalon.SelectedIndexChanged += cbSalon_SelectedIndexChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cbBiletTürü);
            groupBox8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox8.Location = new Point(12, 524);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(9, 3, 3, 3);
            groupBox8.Size = new Size(263, 59);
            groupBox8.TabIndex = 34;
            groupBox8.TabStop = false;
            groupBox8.Text = "BİLET TÜRÜ";
            // 
            // cbBiletTürü
            // 
            cbBiletTürü.BackColor = Color.White;
            cbBiletTürü.Dock = DockStyle.Fill;
            cbBiletTürü.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBiletTürü.FlatStyle = FlatStyle.Flat;
            cbBiletTürü.ForeColor = Color.FromArgb(84, 110, 120);
            cbBiletTürü.FormattingEnabled = true;
            cbBiletTürü.Items.AddRange(new object[] { "YETİŞKİN", "ÖĞRENCİ" });
            cbBiletTürü.Location = new Point(9, 26);
            cbBiletTürü.Name = "cbBiletTürü";
            cbBiletTürü.Size = new Size(251, 31);
            cbBiletTürü.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtKoltuklar);
            groupBox9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox9.Location = new Point(12, 589);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(9, 3, 3, 3);
            groupBox9.Size = new Size(263, 59);
            groupBox9.TabIndex = 35;
            groupBox9.TabStop = false;
            groupBox9.Text = "SEÇİLEN KOLTUKLAR";
            // 
            // txtKoltuklar
            // 
            txtKoltuklar.BorderStyle = BorderStyle.None;
            txtKoltuklar.Dock = DockStyle.Bottom;
            txtKoltuklar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKoltuklar.ForeColor = Color.FromArgb(84, 110, 120);
            txtKoltuklar.Location = new Point(9, 33);
            txtKoltuklar.Name = "txtKoltuklar";
            txtKoltuklar.Size = new Size(251, 23);
            txtKoltuklar.TabIndex = 0;
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.FromArgb(242, 171, 26);
            btnOlustur.Cursor = Cursors.Hand;
            btnOlustur.FlatAppearance.BorderSize = 0;
            btnOlustur.FlatStyle = FlatStyle.Flat;
            btnOlustur.ForeColor = Color.White;
            btnOlustur.Location = new Point(12, 664);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(262, 46);
            btnOlustur.TabIndex = 36;
            btnOlustur.Text = "OLUŞTUR";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(592, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(544, 56);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 38;
            label1.Text = "PERDE";
            // 
            // KoltukPaneli
            // 
            KoltukPaneli.AutoScroll = true;
            KoltukPaneli.Location = new Point(284, 106);
            KoltukPaneli.Name = "KoltukPaneli";
            KoltukPaneli.Size = new Size(589, 539);
            KoltukPaneli.TabIndex = 39;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.mavikoltuk;
            pictureBox2.Location = new Point(424, 674);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(12, 192, 223);
            label3.Location = new Point(402, 719);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 41;
            label3.Text = "BOŞ KOLTUK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(255, 49, 49);
            label4.Location = new Point(527, 716);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 43;
            label4.Text = "DOLU KOLTUK";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.kırmızıkolutk;
            pictureBox3.Location = new Point(557, 674);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(255, 222, 89);
            label5.Location = new Point(657, 717);
            label5.Name = "label5";
            label5.Size = new Size(118, 19);
            label5.TabIndex = 45;
            label5.Text = "SEÇİLEN KOLTUK";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.sarkoltuk;
            pictureBox4.Location = new Point(690, 674);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // lblGelenKoltuk
            // 
            lblGelenKoltuk.AutoSize = true;
            lblGelenKoltuk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGelenKoltuk.ForeColor = Color.Peru;
            lblGelenKoltuk.Location = new Point(544, 134);
            lblGelenKoltuk.Name = "lblGelenKoltuk";
            lblGelenKoltuk.Size = new Size(112, 28);
            lblGelenKoltuk.TabIndex = 46;
            lblGelenKoltuk.Text = "gg/aa/yyyy";
            lblGelenKoltuk.Visible = false;
            // 
            // listeGelenKoltuk
            // 
            listeGelenKoltuk.FormattingEnabled = true;
            listeGelenKoltuk.ItemHeight = 31;
            listeGelenKoltuk.Location = new Point(544, 186);
            listeGelenKoltuk.Name = "listeGelenKoltuk";
            listeGelenKoltuk.Size = new Size(150, 97);
            listeGelenKoltuk.TabIndex = 47;
            // 
            // lbBelirlenen
            // 
            lbBelirlenen.FormattingEnabled = true;
            lbBelirlenen.ItemHeight = 31;
            lbBelirlenen.Location = new Point(544, 302);
            lbBelirlenen.Name = "lbBelirlenen";
            lbBelirlenen.Size = new Size(150, 97);
            lbBelirlenen.TabIndex = 48;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(84, 110, 120);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(12, 716);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(262, 42);
            btnTemizle.TabIndex = 49;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // frmBiletOlustur
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 770);
            Controls.Add(btnTemizle);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(KoltukPaneli);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnOlustur);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(lbBelirlenen);
            Controls.Add(listeGelenKoltuk);
            Controls.Add(lblGelenKoltuk);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 120);
            Margin = new Padding(5);
            Name = "frmBiletOlustur";
            StartPosition = FormStartPosition.Manual;
            Text = "frmBiletOlustur";
            Load += frmBiletOlustur_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox txtBarkod;
        private GroupBox groupBox2;
        private TextBox txtAdSoyad;
        private GroupBox groupBox3;
        private TextBox txtTelNo;
        private GroupBox groupBox4;
        private ComboBox cbFilmAdi;
        private GroupBox groupBox5;
        private Label lblGGaaYY;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private ComboBox cbSalon;
        private GroupBox groupBox8;
        private ComboBox cbBiletTürü;
        private GroupBox groupBox9;
        private TextBox txtKoltuklar;
        private Button btnOlustur;
        private ComboBox cbTarıh;
        private FlowLayoutPanel panelSEANS;
        private Label lblSeansSeç;
        private Label lblKoltukSayisi;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel KoltukPaneli;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox4;
        private Label lblGelenKoltuk;
        private ListBox listeGelenKoltuk;
        private ListBox lbBelirlenen;
        private Button btnTemizle;
    }
}