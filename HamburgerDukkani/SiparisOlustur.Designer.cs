namespace HamburgerDukkani
{
    partial class SiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            flSosPaneli = new FlowLayoutPanel();
            cbUrunler = new ComboBox();
            pictureBox1 = new PictureBox();
            lbUrunler = new ListBox();
            rbKucuk = new RadioButton();
            rbOrta = new RadioButton();
            rbBuyuk = new RadioButton();
            label1 = new Label();
            nmrMenuAdet = new NumericUpDown();
            btnEkle = new Button();
            label2 = new Label();
            lblToplamFiyat = new Label();
            btnSiparisOnayla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrMenuAdet).BeginInit();
            SuspendLayout();
            // 
            // flSosPaneli
            // 
            flSosPaneli.Location = new Point(12, 260);
            flSosPaneli.Name = "flSosPaneli";
            flSosPaneli.Size = new Size(256, 168);
            flSosPaneli.TabIndex = 0;
            // 
            // cbUrunler
            // 
            cbUrunler.FormattingEnabled = true;
            cbUrunler.Location = new Point(10, 220);
            cbUrunler.Name = "cbUrunler";
            cbUrunler.Size = new Size(181, 23);
            cbUrunler.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbUrunler
            // 
            lbUrunler.FormattingEnabled = true;
            lbUrunler.ItemHeight = 15;
            lbUrunler.Location = new Point(294, 12);
            lbUrunler.Name = "lbUrunler";
            lbUrunler.Size = new Size(518, 379);
            lbUrunler.TabIndex = 0;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(10, 447);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(58, 19);
            rbKucuk.TabIndex = 1;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Kücük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(84, 447);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(48, 19);
            rbOrta.TabIndex = 2;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(141, 447);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(58, 19);
            rbBuyuk.TabIndex = 3;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Buyuk";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 492);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Adet";
            // 
            // nmrMenuAdet
            // 
            nmrMenuAdet.Location = new Point(84, 490);
            nmrMenuAdet.Name = "nmrMenuAdet";
            nmrMenuAdet.Size = new Size(120, 23);
            nmrMenuAdet.TabIndex = 5;
            nmrMenuAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(24, 530);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(194, 52);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(408, 481);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 7;
            label2.Text = "Toplam";
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplamFiyat.ForeColor = Color.Lime;
            lblToplamFiyat.Location = new Point(503, 481);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(22, 25);
            lblToplamFiyat.TabIndex = 8;
            lblToplamFiyat.Text = "₺";
            // 
            // btnSiparisOnayla
            // 
            btnSiparisOnayla.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisOnayla.Location = new Point(600, 436);
            btnSiparisOnayla.Name = "btnSiparisOnayla";
            btnSiparisOnayla.Size = new Size(193, 121);
            btnSiparisOnayla.TabIndex = 9;
            btnSiparisOnayla.Text = "Siparis Onayla";
            btnSiparisOnayla.UseVisualStyleBackColor = true;
            btnSiparisOnayla.Click += btnSiparisOnayla_Click;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 594);
            Controls.Add(cbUrunler);
            Controls.Add(btnSiparisOnayla);
            Controls.Add(lblToplamFiyat);
            Controls.Add(label2);
            Controls.Add(btnEkle);
            Controls.Add(nmrMenuAdet);
            Controls.Add(label1);
            Controls.Add(rbBuyuk);
            Controls.Add(rbOrta);
            Controls.Add(rbKucuk);
            Controls.Add(lbUrunler);
            Controls.Add(pictureBox1);
            Controls.Add(flSosPaneli);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisOlustur";
            Text = "SiparisEkrani";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrMenuAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flSosPaneli;
        private ComboBox cbUrunler;
        private PictureBox pictureBox1;
        private ListBox lbUrunler;
        private RadioButton rbKucuk;
        private RadioButton rbOrta;
        private RadioButton rbBuyuk;
        private Label label1;
        private NumericUpDown nmrMenuAdet;
        private Button btnEkle;
        private Label label2;
        private Label lblToplamFiyat;
        private Button btnSiparisOnayla;
    }
}