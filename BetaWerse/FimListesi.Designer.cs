namespace BetaWerse
{
    partial class FimListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FimListesi));
            groupBox8 = new GroupBox();
            lblNo = new Label();
            lblFilmAdı = new Label();
            btnFilm = new Button();
            pPResim = new PictureBox();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pPResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lblNo);
            groupBox8.Controls.Add(lblFilmAdı);
            groupBox8.Controls.Add(btnFilm);
            groupBox8.Controls.Add(pPResim);
            groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox8.Location = new Point(3, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(9, 3, 3, 3);
            groupBox8.Size = new Size(192, 331);
            groupBox8.TabIndex = 33;
            groupBox8.TabStop = false;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNo.Location = new Point(5, 258);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(53, 23);
            lblNo.TabIndex = 23;
            lblNo.Text = "label1";
            lblNo.Visible = false;
            // 
            // lblFilmAdı
            // 
            lblFilmAdı.AutoSize = true;
            lblFilmAdı.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFilmAdı.Location = new Point(5, -3);
            lblFilmAdı.Name = "lblFilmAdı";
            lblFilmAdı.Size = new Size(61, 25);
            lblFilmAdı.TabIndex = 22;
            lblFilmAdı.Text = "label1";
            // 
            // btnFilm
            // 
            btnFilm.BackColor = Color.FromArgb(242, 171, 26);
            btnFilm.Cursor = Cursors.Hand;
            btnFilm.FlatAppearance.BorderSize = 0;
            btnFilm.FlatStyle = FlatStyle.Flat;
            btnFilm.ForeColor = Color.White;
            btnFilm.Location = new Point(5, 289);
            btnFilm.Name = "btnFilm";
            btnFilm.Size = new Size(181, 34);
            btnFilm.TabIndex = 21;
            btnFilm.Text = "DETAY";
            btnFilm.UseVisualStyleBackColor = false;
            btnFilm.Click += btnFilm_Click;
            // 
            // pPResim
            // 
            pPResim.Image = (Image)resources.GetObject("pPResim.Image");
            pPResim.Location = new Point(5, 28);
            pPResim.Name = "pPResim";
            pPResim.Size = new Size(181, 245);
            pPResim.SizeMode = PictureBoxSizeMode.Zoom;
            pPResim.TabIndex = 20;
            pPResim.TabStop = false;
            // 
            // FimListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox8);
            Name = "FimListesi";
            Size = new Size(196, 337);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pPResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox8;
        private Button btnFilm;
        public Label lblFilmAdı;
        public PictureBox pPResim;
        public Label lblNo;
    }
}
