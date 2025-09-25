namespace BetaWerse
{
    partial class frmSalonAtama
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
            btnTemizle = new Button();
            btnOlustur = new Button();
            groupBox7 = new GroupBox();
            cbSalon = new ComboBox();
            lblSecilen = new Label();
            groupBox6 = new GroupBox();
            panelSEANS = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            nYil = new NumericUpDown();
            lblGGaaYY = new Label();
            nAy = new NumericUpDown();
            nGun = new NumericUpDown();
            groupBox4 = new GroupBox();
            cbFilmAdi = new ComboBox();
            groupBox1 = new GroupBox();
            cbDoluSaatler = new ComboBox();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(724, 40);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(684, 0);
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
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 31);
            label1.TabIndex = 1;
            label1.Text = "[SALON ATAMA EKRANI]";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(84, 110, 120);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(12, 293);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(262, 42);
            btnTemizle.TabIndex = 55;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.FromArgb(242, 171, 26);
            btnOlustur.Cursor = Cursors.Hand;
            btnOlustur.FlatAppearance.BorderSize = 0;
            btnOlustur.FlatStyle = FlatStyle.Flat;
            btnOlustur.ForeColor = Color.White;
            btnOlustur.Location = new Point(12, 241);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(262, 46);
            btnOlustur.TabIndex = 54;
            btnOlustur.Text = "TAMAMLA";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbSalon);
            groupBox7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox7.Location = new Point(12, 111);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(9, 3, 3, 3);
            groupBox7.Size = new Size(263, 59);
            groupBox7.TabIndex = 53;
            groupBox7.TabStop = false;
            groupBox7.Text = "SALON ADI";
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
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSecilen.ForeColor = Color.Peru;
            lblSecilen.Location = new Point(347, 358);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(171, 32);
            lblSecilen.TabIndex = 37;
            lblSecilen.Text = "lblKoltukSayisi";
            lblSecilen.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panelSEANS);
            groupBox6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox6.Location = new Point(286, 46);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(9, 3, 3, 3);
            groupBox6.Size = new Size(427, 289);
            groupBox6.TabIndex = 52;
            groupBox6.TabStop = false;
            groupBox6.Text = "SAAT/SEANS";
            // 
            // panelSEANS
            // 
            panelSEANS.AutoScroll = true;
            panelSEANS.Dock = DockStyle.Fill;
            panelSEANS.Location = new Point(9, 26);
            panelSEANS.Name = "panelSEANS";
            panelSEANS.Size = new Size(415, 260);
            panelSEANS.TabIndex = 37;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nYil);
            groupBox5.Controls.Add(lblGGaaYY);
            groupBox5.Controls.Add(nAy);
            groupBox5.Controls.Add(nGun);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox5.Location = new Point(12, 176);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(9, 3, 3, 3);
            groupBox5.Size = new Size(263, 59);
            groupBox5.TabIndex = 51;
            groupBox5.TabStop = false;
            groupBox5.Text = "TARİH";
            // 
            // nYil
            // 
            nYil.BorderStyle = BorderStyle.None;
            nYil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nYil.ForeColor = Color.FromArgb(84, 110, 120);
            nYil.Location = new Point(149, 27);
            nYil.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(106, 26);
            nYil.TabIndex = 19;
            nYil.TextAlign = HorizontalAlignment.Center;
            nYil.Value = new decimal(new int[] { 2005, 0, 0, 0 });
            // 
            // lblGGaaYY
            // 
            lblGGaaYY.AutoSize = true;
            lblGGaaYY.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGGaaYY.ForeColor = Color.Peru;
            lblGGaaYY.Location = new Point(189, 1);
            lblGGaaYY.Name = "lblGGaaYY";
            lblGGaaYY.Size = new Size(79, 19);
            lblGGaaYY.TabIndex = 32;
            lblGGaaYY.Text = "gg/aa/yyyy";
            // 
            // nAy
            // 
            nAy.BorderStyle = BorderStyle.None;
            nAy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nAy.ForeColor = Color.FromArgb(84, 110, 120);
            nAy.Location = new Point(84, 27);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(64, 26);
            nAy.TabIndex = 18;
            nAy.TextAlign = HorizontalAlignment.Center;
            nAy.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nGun
            // 
            nGun.BorderStyle = BorderStyle.None;
            nGun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nGun.ForeColor = Color.FromArgb(84, 110, 120);
            nGun.Location = new Point(5, 27);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(75, 26);
            nGun.TabIndex = 17;
            nGun.TextAlign = HorizontalAlignment.Center;
            nGun.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbFilmAdi);
            groupBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox4.Location = new Point(12, 46);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(9, 3, 3, 3);
            groupBox4.Size = new Size(263, 59);
            groupBox4.TabIndex = 50;
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbDoluSaatler);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(84, 110, 120);
            groupBox1.Location = new Point(17, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(9, 3, 3, 3);
            groupBox1.Size = new Size(263, 59);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "DOLU SAATLER";
            groupBox1.Visible = false;
            // 
            // cbDoluSaatler
            // 
            cbDoluSaatler.BackColor = Color.White;
            cbDoluSaatler.Dock = DockStyle.Fill;
            cbDoluSaatler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoluSaatler.FlatStyle = FlatStyle.Flat;
            cbDoluSaatler.ForeColor = Color.FromArgb(84, 110, 120);
            cbDoluSaatler.FormattingEnabled = true;
            cbDoluSaatler.Location = new Point(9, 26);
            cbDoluSaatler.Name = "cbDoluSaatler";
            cbDoluSaatler.Size = new Size(251, 31);
            cbDoluSaatler.TabIndex = 0;
            // 
            // frmSalonAtama
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 349);
            Controls.Add(lblSecilen);
            Controls.Add(groupBox1);
            Controls.Add(btnTemizle);
            Controls.Add(btnOlustur);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 300);
            Margin = new Padding(5);
            Name = "frmSalonAtama";
            StartPosition = FormStartPosition.Manual;
            Text = "frmSalonAtama";
            Load += frmSalonAtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button btnTemizle;
        private Button btnOlustur;
        private GroupBox groupBox7;
        private Label lblSecilen;
        private ComboBox cbSalon;
        private GroupBox groupBox6;
        private FlowLayoutPanel panelSEANS;
        private GroupBox groupBox5;
        private Label lblGGaaYY;
        private GroupBox groupBox4;
        private ComboBox cbFilmAdi;
        private NumericUpDown nYil;
        private NumericUpDown nAy;
        private NumericUpDown nGun;
        private GroupBox groupBox1;
        private ComboBox cbDoluSaatler;
    }
}