namespace BetaWerse
{
    partial class FrmOyuncuKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOyuncuKayit));
            btnResimYukle = new Button();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblKarakter = new Label();
            label7 = new Label();
            txtBiyografi = new TextBox();
            label10 = new Label();
            pPResim = new PictureBox();
            pictureBox2 = new PictureBox();
            rBKadın = new RadioButton();
            pictureBox1 = new PictureBox();
            rBErkek = new RadioButton();
            label5 = new Label();
            nYil = new NumericUpDown();
            nAy = new NumericUpDown();
            nGun = new NumericUpDown();
            label4 = new Label();
            btnKaydet = new Button();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pPResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.Peru;
            btnResimYukle.Cursor = Cursors.Hand;
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(17, 267);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(234, 53);
            btnResimYukle.TabIndex = 2;
            btnResimYukle.Text = "YÜKLE";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 21);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 18;
            label6.Text = "RESİM";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Window;
            groupBox3.Controls.Add(lblKarakter);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtBiyografi);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox3.Location = new Point(12, 401);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(627, 301);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            // 
            // lblKarakter
            // 
            lblKarakter.Location = new Point(564, 256);
            lblKarakter.Name = "lblKarakter";
            lblKarakter.RightToLeft = RightToLeft.Yes;
            lblKarakter.Size = new Size(47, 33);
            lblKarakter.TabIndex = 8;
            lblKarakter.Text = "300";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Peru;
            label7.Location = new Point(441, -1);
            label7.Name = "label7";
            label7.Size = new Size(155, 23);
            label7.TabIndex = 7;
            label7.Text = "(max 300 karakter)";
            // 
            // txtBiyografi
            // 
            txtBiyografi.Dock = DockStyle.Fill;
            txtBiyografi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBiyografi.ForeColor = Color.FromArgb(84, 110, 120);
            txtBiyografi.Location = new Point(3, 30);
            txtBiyografi.MaxLength = 300;
            txtBiyografi.Multiline = true;
            txtBiyografi.Name = "txtBiyografi";
            txtBiyografi.Size = new Size(621, 268);
            txtBiyografi.TabIndex = 6;
            txtBiyografi.TextChanged += txtBiyografi_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 28);
            label10.TabIndex = 5;
            label10.Text = "BİYOGRAFİ";
            // 
            // pPResim
            // 
            pPResim.Image = (Image)resources.GetObject("pPResim.Image");
            pPResim.Location = new Point(17, 52);
            pPResim.Name = "pPResim";
            pPResim.Size = new Size(234, 209);
            pPResim.SizeMode = PictureBoxSizeMode.Zoom;
            pPResim.TabIndex = 19;
            pPResim.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(283, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // rBKadın
            // 
            rBKadın.AutoSize = true;
            rBKadın.FlatStyle = FlatStyle.Flat;
            rBKadın.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rBKadın.Location = new Point(173, 255);
            rBKadın.Name = "rBKadın";
            rBKadın.Size = new Size(107, 36);
            rBKadın.TabIndex = 16;
            rBKadın.Text = "KADIN";
            rBKadın.UseVisualStyleBackColor = true;
            rBKadın.CheckedChanged += rBKadın_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // rBErkek
            // 
            rBErkek.AutoSize = true;
            rBErkek.Checked = true;
            rBErkek.FlatStyle = FlatStyle.Flat;
            rBErkek.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rBErkek.Location = new Point(12, 254);
            rBErkek.Name = "rBErkek";
            rBErkek.Size = new Size(103, 36);
            rBErkek.TabIndex = 14;
            rBErkek.TabStop = true;
            rBErkek.Text = "ERKEK";
            rBErkek.UseVisualStyleBackColor = true;
            rBErkek.CheckedChanged += rBErkek_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 215);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 13;
            label5.Text = "CİNSİYET";
            // 
            // nYil
            // 
            nYil.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            nYil.ForeColor = Color.FromArgb(84, 110, 120);
            nYil.Location = new Point(204, 180);
            nYil.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(102, 32);
            nYil.TabIndex = 12;
            nYil.Value = new decimal(new int[] { 2005, 0, 0, 0 });
            // 
            // nAy
            // 
            nAy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            nAy.ForeColor = Color.FromArgb(84, 110, 120);
            nAy.Location = new Point(120, 180);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(67, 32);
            nAy.TabIndex = 11;
            nAy.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nGun
            // 
            nGun.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            nGun.ForeColor = Color.FromArgb(84, 110, 120);
            nGun.Location = new Point(28, 180);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(73, 32);
            nGun.TabIndex = 10;
            nGun.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 149);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 9;
            label4.Text = "DOĞUM TARİHİ";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(84, 110, 120);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.Dock = DockStyle.Bottom;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(0, 707);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(654, 53);
            btnKaydet.TabIndex = 25;
            btnKaydet.Text = "KAYIT TAMAMLA";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(28, 116);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(264, 30);
            txtSoyad.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 85);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 7;
            label3.Text = "SOYAD";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.ForeColor = Color.FromArgb(84, 110, 120);
            txtAd.Location = new Point(28, 52);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(264, 30);
            txtAd.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(39, 28);
            label2.TabIndex = 5;
            label2.Text = "AD";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(rBKadın);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rBErkek);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nYil);
            groupBox1.Controls.Add(nAy);
            groupBox1.Controls.Add(nGun);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 336);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(614, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(289, 32);
            label1.TabIndex = 1;
            label1.Text = "[OYUNCU KAYIT EKRANI]";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Window;
            groupBox2.Controls.Add(btnResimYukle);
            groupBox2.Controls.Add(pPResim);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox2.Location = new Point(372, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 336);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 120);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 40);
            panel1.TabIndex = 21;
            // 
            // FrmOyuncuKayit
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 760);
            Controls.Add(groupBox3);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 100);
            Margin = new Padding(5);
            Name = "FrmOyuncuKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmOyuncuKayit";
            Load += FrmOyuncuKayit_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pPResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnResimYukle;
        private Label label6;
        private GroupBox groupBox3;
        private Label lblKarakter;
        private Label label7;
        private TextBox txtBiyografi;
        private Label label10;
        private PictureBox pPResim;
        private PictureBox pictureBox2;
        private RadioButton rBKadın;
        private PictureBox pictureBox1;
        private RadioButton rBErkek;
        private Label label5;
        private NumericUpDown nYil;
        private NumericUpDown nAy;
        private NumericUpDown nGun;
        private Label label4;
        private Button btnKaydet;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private Panel panel1;
    }
}