﻿namespace BetaWerse
{
    partial class FrmKayitOl
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
            txtAdSoyad = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnKayitOl = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 12F);
            txtAdSoyad.Location = new Point(209, 28);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(201, 34);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F);
            txtKullaniciAdi.Location = new Point(209, 77);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(201, 34);
            txtKullaniciAdi.TabIndex = 1;
           
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F);
            txtSifre.Location = new Point(209, 137);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(201, 34);
            txtSifre.TabIndex = 2;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(84, 110, 120);
            btnKayitOl.Cursor = Cursors.Hand;
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(209, 201);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(201, 46);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
         
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(66, 28);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 7;
            label1.Text = "AD SOYAD :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 80);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 8;
            label2.Text = "KULLANICI ADI :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(112, 137);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 9;
            label3.Text = "ŞİFRE :";
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 274);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtAdSoyad);
            Name = "FrmKayitOl";
            Text = "FrmKayitOl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdSoyad;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnKayitOl;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}