namespace BetaWerse
{
    partial class frmBiletSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiletSorgulama));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            txtBiletNo = new TextBox();
            pictureBox1 = new PictureBox();
            btnSorgula = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(509, 35);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, -1);
            label2.Name = "label2";
            label2.Size = new Size(333, 32);
            label2.TabIndex = 2;
            label2.Text = "[BİLET SORGULAMA EKRANI]";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(475, 0);
            button1.Name = "button1";
            button1.Size = new Size(34, 35);
            button1.TabIndex = 1;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(84, 110, 120);
            label1.Location = new Point(40, 68);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 25;
            label1.Text = "BİLET NUMARASI";
            // 
            // txtBiletNo
            // 
            txtBiletNo.BackColor = Color.FromArgb(221, 221, 224);
            txtBiletNo.BorderStyle = BorderStyle.FixedSingle;
            txtBiletNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBiletNo.ForeColor = Color.White;
            txtBiletNo.Location = new Point(209, 66);
            txtBiletNo.MaxLength = 10;
            txtBiletNo.Name = "txtBiletNo";
            txtBiletNo.Size = new Size(263, 30);
            txtBiletNo.TabIndex = 26;
            txtBiletNo.TextChanged += txtBiletNo_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(209, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnSorgula
            // 
            btnSorgula.BackColor = Color.FromArgb(84, 110, 120);
            btnSorgula.Cursor = Cursors.Hand;
            btnSorgula.FlatAppearance.BorderSize = 0;
            btnSorgula.FlatStyle = FlatStyle.Flat;
            btnSorgula.Location = new Point(209, 120);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(263, 45);
            btnSorgula.TabIndex = 28;
            btnSorgula.Text = "SORGULA";
            btnSorgula.UseVisualStyleBackColor = false;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // frmBiletSorgulama
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(509, 198);
            Controls.Add(btnSorgula);
            Controls.Add(txtBiletNo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(800, 400);
            Margin = new Padding(5);
            Name = "frmBiletSorgulama";
            StartPosition = FormStartPosition.Manual;
            Text = "frmBiletSorgulama";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox txtBiletNo;
        private PictureBox pictureBox1;
        private Button btnSorgula;
    }
}