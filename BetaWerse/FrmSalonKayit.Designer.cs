namespace BetaWerse
{
    partial class FrmSalonKayit
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnResimYukle = new Button();
            cbKoltukSayisi = new ComboBox();
            label3 = new Label();
            txtSalonAdi = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            panelsalonliste = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Size = new Size(629, 40);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(589, 0);
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
            label1.Size = new Size(266, 32);
            label1.TabIndex = 1;
            label1.Text = "[SALON KAYIT EKRANI]";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(btnResimYukle);
            groupBox1.Controls.Add(cbKoltukSayisi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSalonAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 102);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.Peru;
            btnResimYukle.Cursor = Cursors.Hand;
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(392, 41);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(192, 40);
            btnResimYukle.TabIndex = 9;
            btnResimYukle.Text = "EKLE";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // cbKoltukSayisi
            // 
            cbKoltukSayisi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbKoltukSayisi.ForeColor = Color.FromArgb(84, 110, 120);
            cbKoltukSayisi.FormattingEnabled = true;
            cbKoltukSayisi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbKoltukSayisi.Location = new Point(237, 49);
            cbKoltukSayisi.Name = "cbKoltukSayisi";
            cbKoltukSayisi.Size = new Size(137, 31);
            cbKoltukSayisi.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 25);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 7;
            label3.Text = "KOLTUK SAYISI";
            // 
            // txtSalonAdi
            // 
            txtSalonAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSalonAdi.ForeColor = Color.FromArgb(84, 110, 120);
            txtSalonAdi.Location = new Point(19, 50);
            txtSalonAdi.Name = "txtSalonAdi";
            txtSalonAdi.Size = new Size(199, 30);
            txtSalonAdi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 5;
            label2.Text = "SALON ADI";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Window;
            groupBox2.Controls.Add(panelsalonliste);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox2.Location = new Point(12, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(605, 581);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // panelsalonliste
            // 
            panelsalonliste.AutoScroll = true;
            panelsalonliste.Dock = DockStyle.Fill;
            panelsalonliste.Location = new Point(3, 30);
            panelsalonliste.Name = "panelsalonliste";
            panelsalonliste.Size = new Size(599, 548);
            panelsalonliste.TabIndex = 0;
            // 
            // FrmSalonKayit
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 747);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(800, 120);
            Margin = new Padding(5);
            Name = "FrmSalonKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonKayit";
            Load += FrmSalonKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtSalonAdi;
        private Label label2;
        private ComboBox cbKoltukSayisi;
        private Button btnResimYukle;
        private GroupBox groupBox2;
        private FlowLayoutPanel panelsalonliste;
    }
}