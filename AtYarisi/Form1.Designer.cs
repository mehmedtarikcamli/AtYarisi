namespace AtYarisi
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            saha = new Panel();
            at3 = new PictureBox();
            at2 = new PictureBox();
            at1 = new PictureBox();
            pnlBitis = new Panel();
            btnBaslat = new Button();
            lblDurum = new Label();
            saha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)at3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // saha
            // 
            saha.BackColor = Color.Green;
            saha.Controls.Add(at3);
            saha.Controls.Add(at2);
            saha.Controls.Add(at1);
            saha.Controls.Add(pnlBitis);
            saha.Location = new Point(46, 71);
            saha.Name = "saha";
            saha.Size = new Size(443, 298);
            saha.TabIndex = 1;
            // 
            // at3
            // 
            at3.Image = (Image)resources.GetObject("at3.Image");
            at3.Location = new Point(0, 209);
            at3.Name = "at3";
            at3.Size = new Size(100, 63);
            at3.SizeMode = PictureBoxSizeMode.Zoom;
            at3.TabIndex = 3;
            at3.TabStop = false;
            at3.Tag = "3";
            // 
            // at2
            // 
            at2.Image = (Image)resources.GetObject("at2.Image");
            at2.Location = new Point(0, 118);
            at2.Name = "at2";
            at2.Size = new Size(100, 63);
            at2.SizeMode = PictureBoxSizeMode.Zoom;
            at2.TabIndex = 2;
            at2.TabStop = false;
            at2.Tag = "2";
            // 
            // at1
            // 
            at1.Image = Properties.Resources.at1;
            at1.Location = new Point(0, 27);
            at1.Name = "at1";
            at1.Size = new Size(100, 63);
            at1.SizeMode = PictureBoxSizeMode.Zoom;
            at1.TabIndex = 1;
            at1.TabStop = false;
            at1.Tag = "1";
            // 
            // pnlBitis
            // 
            pnlBitis.BackColor = Color.FromArgb(192, 0, 0);
            pnlBitis.Location = new Point(429, 3);
            pnlBitis.Name = "pnlBitis";
            pnlBitis.Size = new Size(10, 292);
            pnlBitis.TabIndex = 0;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(203, 375);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(148, 23);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "BAŞLAT";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // lblDurum
            // 
            lblDurum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDurum.Location = new Point(3, 3);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(531, 57);
            lblDurum.TabIndex = 3;
            lblDurum.Text = "Atlar yarışa hazır.";
            lblDurum.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 410);
            Controls.Add(lblDurum);
            Controls.Add(btnBaslat);
            Controls.Add(saha);
            Name = "Form1";
            Text = "At Yarışı";
            saha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)at3).EndInit();
            ((System.ComponentModel.ISupportInitialize)at2).EndInit();
            ((System.ComponentModel.ISupportInitialize)at1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel saha;
        private Panel pnlBitis;
        private PictureBox at3;
        private PictureBox at2;
        private PictureBox at1;
        private Button btnBaslat;
        private Label lblDurum;
    }
}