namespace BetaWerse
{
    partial class FrmYonetmenListesi
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
            panel2 = new Panel();
            txtAramaYap = new TextBox();
            label2 = new Label();
            PanelListe = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(654, 40);
            panel1.TabIndex = 3;
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
            label1.Size = new Size(310, 32);
            label1.TabIndex = 1;
            label1.Text = "[YÖNETMEN LİSTE EKRANI]";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txtAramaYap);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 40);
            panel2.TabIndex = 4;
            // 
            // txtAramaYap
            // 
            txtAramaYap.BorderStyle = BorderStyle.None;
            txtAramaYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAramaYap.ForeColor = Color.FromArgb(84, 110, 120);
            txtAramaYap.Location = new Point(430, 9);
            txtAramaYap.Name = "txtAramaYap";
            txtAramaYap.Size = new Size(212, 27);
            txtAramaYap.TabIndex = 1;
            txtAramaYap.TextChanged += txtAramaYap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(84, 110, 120);
            label2.Location = new Point(284, 7);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 0;
            label2.Text = "AD VE SOYAD :";
            // 
            // PanelListe
            // 
            PanelListe.AutoScroll = true;
            PanelListe.Dock = DockStyle.Fill;
            PanelListe.Location = new Point(0, 80);
            PanelListe.Name = "PanelListe";
            PanelListe.Size = new Size(654, 680);
            PanelListe.TabIndex = 5;
            // 
            // FrmYonetmenListesi
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 760);
            Controls.Add(PanelListe);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 120);
            Margin = new Padding(5);
            Name = "FrmYonetmenListesi";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmYonetmenListesi";
            Load += FrmYonetmenListesi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private FlowLayoutPanel PanelListe;
        private TextBox txtAramaYap;
        private Label label2;
    }
}