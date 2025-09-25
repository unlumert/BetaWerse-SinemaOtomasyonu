namespace BetaWerse
{
    partial class OyuncuListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuListesi));
            btnSil = new Button();
            lblAdSoyad = new Label();
            lblCinsiyet = new Label();
            pbCİNSİYET = new PictureBox();
            btnResimYukle = new Button();
            pbResimDetay = new PictureBox();
            lblıd = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbCİNSİYET).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 128, 128);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(549, 64);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(70, 44);
            btnSil.TabIndex = 16;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(197, 15);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(38, 15);
            lblAdSoyad.TabIndex = 15;
            lblAdSoyad.Text = "label1";
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(255, 82);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(38, 15);
            lblCinsiyet.TabIndex = 14;
            lblCinsiyet.Text = "label1";
            lblCinsiyet.Visible = false;
            // 
            // pbCİNSİYET
            // 
            pbCİNSİYET.Image = (Image)resources.GetObject("pbCİNSİYET.Image");
            pbCİNSİYET.Location = new Point(124, 12);
            pbCİNSİYET.Name = "pbCİNSİYET";
            pbCİNSİYET.Size = new Size(31, 28);
            pbCİNSİYET.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCİNSİYET.TabIndex = 13;
            pbCİNSİYET.TabStop = false;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.FromArgb(128, 128, 255);
            btnResimYukle.Cursor = Cursors.Hand;
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(349, 64);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(194, 44);
            btnResimYukle.TabIndex = 12;
            btnResimYukle.Text = "DETAY";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // pbResimDetay
            // 
            pbResimDetay.Image = (Image)resources.GetObject("pbResimDetay.Image");
            pbResimDetay.Location = new Point(9, 3);
            pbResimDetay.Name = "pbResimDetay";
            pbResimDetay.Size = new Size(109, 105);
            pbResimDetay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResimDetay.TabIndex = 11;
            pbResimDetay.TabStop = false;
            // 
            // lblıd
            // 
            lblıd.AutoSize = true;
            lblıd.Location = new Point(152, 82);
            lblıd.Name = "lblıd";
            lblıd.Size = new Size(38, 15);
            lblıd.TabIndex = 10;
            lblıd.Text = "label1";
            lblıd.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 120);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 111);
            panel1.TabIndex = 9;
            // 
            // OyuncuListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnSil);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblCinsiyet);
            Controls.Add(pbCİNSİYET);
            Controls.Add(btnResimYukle);
            Controls.Add(pbResimDetay);
            Controls.Add(lblıd);
            Controls.Add(panel1);
            Name = "OyuncuListesi";
            Size = new Size(621, 111);
            Load += OyuncuListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pbCİNSİYET).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        public Label lblAdSoyad;
        public Label lblCinsiyet;
        public PictureBox pbCİNSİYET;
        private Button btnResimYukle;
        public PictureBox pbResimDetay;
        public Label lblıd;
        private Panel panel1;
    }
}
