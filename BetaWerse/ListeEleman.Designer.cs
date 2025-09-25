namespace BetaWerse
{
    partial class ListeEleman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEleman));
            panel1 = new Panel();
            lblıd = new Label();
            pbResimDetay = new PictureBox();
            btnResimYukle = new Button();
            pbCİNSİYET = new PictureBox();
            lblCinsiyet = new Label();
            lblAdSoyad = new Label();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCİNSİYET).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 120);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 111);
            panel1.TabIndex = 0;
            // 
            // lblıd
            // 
            lblıd.AutoSize = true;
            lblıd.Location = new Point(151, 82);
            lblıd.Name = "lblıd";
            lblıd.Size = new Size(38, 15);
            lblıd.TabIndex = 2;
            lblıd.Text = "label1";
            lblıd.Visible = false;
            // 
            // pbResimDetay
            // 
            pbResimDetay.Image = (Image)resources.GetObject("pbResimDetay.Image");
            pbResimDetay.Location = new Point(8, 3);
            pbResimDetay.Name = "pbResimDetay";
            pbResimDetay.Size = new Size(109, 105);
            pbResimDetay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResimDetay.TabIndex = 3;
            pbResimDetay.TabStop = false;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.Peru;
            btnResimYukle.Cursor = Cursors.Hand;
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(348, 64);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(194, 44);
            btnResimYukle.TabIndex = 4;
            btnResimYukle.Text = "DETAY";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // pbCİNSİYET
            // 
            pbCİNSİYET.Image = (Image)resources.GetObject("pbCİNSİYET.Image");
            pbCİNSİYET.Location = new Point(123, 12);
            pbCİNSİYET.Name = "pbCİNSİYET";
            pbCİNSİYET.Size = new Size(31, 28);
            pbCİNSİYET.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCİNSİYET.TabIndex = 5;
            pbCİNSİYET.TabStop = false;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(254, 82);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(38, 15);
            lblCinsiyet.TabIndex = 6;
            lblCinsiyet.Text = "label1";
            lblCinsiyet.Visible = false;
            lblCinsiyet.Click += lblCinsiyet_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(196, 15);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(38, 15);
            lblAdSoyad.TabIndex = 7;
            lblAdSoyad.Text = "label1";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkSlateGray;
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(548, 64);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(70, 44);
            btnSil.TabIndex = 8;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // ListeEleman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnSil);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblCinsiyet);
            Controls.Add(pbCİNSİYET);
            Controls.Add(btnResimYukle);
            Controls.Add(pbResimDetay);
            Controls.Add(lblıd);
            Controls.Add(panel1);
            Name = "ListeEleman";
            Size = new Size(621, 111);
            Load += ListeEleman_Load;
            VisibleChanged += ListeEleman_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCİNSİYET).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label lblıd;
        public PictureBox pbResimDetay;
        private Button btnResimYukle;
        public PictureBox pbCİNSİYET;
        public Label lblCinsiyet;
        public Label lblAdSoyad;
        private Button btnSil;
    }
}
