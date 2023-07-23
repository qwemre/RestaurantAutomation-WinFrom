namespace HamburgerDukkani
{
    partial class EkstraSosEkle
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
            btnEkstraSosEkle = new Button();
            txtEkstraMalzemeAdi = new TextBox();
            nmrEkstraMalzemeFiyati = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrEkstraMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // btnEkstraSosEkle
            // 
            btnEkstraSosEkle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkstraSosEkle.Location = new Point(112, 209);
            btnEkstraSosEkle.Name = "btnEkstraSosEkle";
            btnEkstraSosEkle.Size = new Size(191, 44);
            btnEkstraSosEkle.TabIndex = 10;
            btnEkstraSosEkle.Text = "Ekle";
            btnEkstraSosEkle.UseVisualStyleBackColor = true;
            btnEkstraSosEkle.Click += btnEkstraMalzemeEkle_Click;
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Location = new Point(112, 85);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(191, 23);
            txtEkstraMalzemeAdi.TabIndex = 9;
            // 
            // nmrEkstraMalzemeFiyati
            // 
            nmrEkstraMalzemeFiyati.Location = new Point(112, 143);
            nmrEkstraMalzemeFiyati.Name = "nmrEkstraMalzemeFiyati";
            nmrEkstraMalzemeFiyati.Size = new Size(191, 23);
            nmrEkstraMalzemeFiyati.TabIndex = 8;
            nmrEkstraMalzemeFiyati.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 141);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 7;
            label3.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 85);
            label2.Name = "label2";
            label2.Size = new Size(35, 25);
            label2.TabIndex = 6;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 11;
            label1.Text = "Ekstra Sos Ekle";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 331);
            Controls.Add(label1);
            Controls.Add(btnEkstraSosEkle);
            Controls.Add(txtEkstraMalzemeAdi);
            Controls.Add(nmrEkstraMalzemeFiyati);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            ((System.ComponentModel.ISupportInitialize)nmrEkstraMalzemeFiyati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkstraSosEkle;
        private TextBox txtEkstraMalzemeAdi;
        private NumericUpDown nmrEkstraMalzemeFiyati;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}