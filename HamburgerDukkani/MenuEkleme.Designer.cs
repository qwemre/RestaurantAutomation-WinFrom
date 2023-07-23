namespace HamburgerDukkani
{
    partial class MenuEkleme
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
            label1 = new Label();
            btnEkstraMenüEkle = new Button();
            txtEkstraMenü = new TextBox();
            nmrEkstraMenüFiyat = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrEkstraMenüFiyat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 37);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 17;
            label1.Text = "Ekstra Menü Ekle";
            // 
            // btnEkstraMenüEkle
            // 
            btnEkstraMenüEkle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkstraMenüEkle.Location = new Point(140, 218);
            btnEkstraMenüEkle.Name = "btnEkstraMenüEkle";
            btnEkstraMenüEkle.Size = new Size(191, 44);
            btnEkstraMenüEkle.TabIndex = 16;
            btnEkstraMenüEkle.Text = "Ekle";
            btnEkstraMenüEkle.UseVisualStyleBackColor = true;
            btnEkstraMenüEkle.Click += btnEkstraMalzemeEkle_Click;
            // 
            // txtEkstraMenü
            // 
            txtEkstraMenü.Location = new Point(140, 94);
            txtEkstraMenü.Name = "txtEkstraMenü";
            txtEkstraMenü.Size = new Size(191, 23);
            txtEkstraMenü.TabIndex = 15;
            // 
            // nmrEkstraMenüFiyat
            // 
            nmrEkstraMenüFiyat.Location = new Point(140, 152);
            nmrEkstraMenüFiyat.Name = "nmrEkstraMenüFiyat";
            nmrEkstraMenüFiyat.Size = new Size(191, 23);
            nmrEkstraMenüFiyat.TabIndex = 14;
            nmrEkstraMenüFiyat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 150);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 13;
            label3.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 94);
            label2.Name = "label2";
            label2.Size = new Size(35, 25);
            label2.TabIndex = 12;
            label2.Text = "Ad";
            // 
            // TumSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 338);
            Controls.Add(label1);
            Controls.Add(btnEkstraMenüEkle);
            Controls.Add(txtEkstraMenü);
            Controls.Add(nmrEkstraMenüFiyat);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TumSiparisler";
            Text = "AlinanSiparisler";
            ((System.ComponentModel.ISupportInitialize)nmrEkstraMenüFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEkstraMenüEkle;
        private TextBox txtEkstraMenü;
        private NumericUpDown nmrEkstraMenüFiyat;
        private Label label3;
        private Label label2;
    }
}