namespace BetaWerse
{
    partial class FormAcls
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            txtkullanici = new Label();
            txtkullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label3 = new Label();
            btnGirisYap = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 120);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 40);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(386, 0);
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
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 1;
            label1.Text = "Betawerse.com";
            // 
            // txtkullanici
            // 
            txtkullanici.AutoSize = true;
            txtkullanici.ForeColor = Color.FromArgb(84, 110, 120);
            txtkullanici.Location = new Point(2, 87);
            txtkullanici.Name = "txtkullanici";
            txtkullanici.Size = new Size(147, 32);
            txtkullanici.TabIndex = 1;
            txtkullanici.Text = "YETKİLİ KİŞİ :";
            // 
            // txtkullaniciAdi
            // 
            txtkullaniciAdi.Location = new Point(150, 84);
            txtkullaniciAdi.Name = "txtkullaniciAdi";
            txtkullaniciAdi.Size = new Size(258, 39);
            txtkullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(150, 136);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(258, 39);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(84, 110, 120);
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 3;
            label3.Text = "ŞİFRE :";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(84, 110, 120);
            btnGirisYap.Cursor = Cursors.Hand;
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(150, 191);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(258, 46);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FormAcls
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 265);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(txtkullaniciAdi);
            Controls.Add(txtkullanici);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FormAcls";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAcls";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label txtkullanici;
        private TextBox txtkullaniciAdi;
        private TextBox txtSifre;
        private Label label3;
        private Button btnGirisYap;
    }
}
