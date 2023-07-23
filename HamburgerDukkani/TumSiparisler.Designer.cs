namespace HamburgerDukkani
{
    partial class TumSiparisler
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
            groupBox4 = new GroupBox();
            lblSatılanUrunAdedi = new Label();
            groupBox3 = new GroupBox();
            lblEkstraMalzeme = new Label();
            groupBox2 = new GroupBox();
            lblToplamSparis = new Label();
            groupBox1 = new GroupBox();
            lblCiro = new Label();
            lblSiparisList = new ListBox();
            label1 = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSatılanUrunAdedi);
            groupBox4.Location = new Point(442, 346);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(180, 57);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "SATILAN ÜRÜN ADEDİ";
            // 
            // lblSatılanUrunAdedi
            // 
            lblSatılanUrunAdedi.AutoSize = true;
            lblSatılanUrunAdedi.ForeColor = Color.Lime;
            lblSatılanUrunAdedi.Location = new Point(36, 19);
            lblSatılanUrunAdedi.Name = "lblSatılanUrunAdedi";
            lblSatılanUrunAdedi.Size = new Size(0, 15);
            lblSatılanUrunAdedi.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEkstraMalzeme);
            groupBox3.Location = new Point(442, 268);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(180, 57);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "TOPLAM SATILAN SOS FİYATI";
            // 
            // lblEkstraMalzeme
            // 
            lblEkstraMalzeme.AutoSize = true;
            lblEkstraMalzeme.ForeColor = Color.Lime;
            lblEkstraMalzeme.Location = new Point(36, 28);
            lblEkstraMalzeme.Name = "lblEkstraMalzeme";
            lblEkstraMalzeme.Size = new Size(0, 15);
            lblEkstraMalzeme.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblToplamSparis);
            groupBox2.Location = new Point(442, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 57);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "TOPLAM SİPARİŞ";
            // 
            // lblToplamSparis
            // 
            lblToplamSparis.AutoSize = true;
            lblToplamSparis.ForeColor = Color.Lime;
            lblToplamSparis.Location = new Point(36, 30);
            lblToplamSparis.Name = "lblToplamSparis";
            lblToplamSparis.Size = new Size(0, 15);
            lblToplamSparis.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCiro);
            groupBox1.Location = new Point(442, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 57);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "CİRO";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.ForeColor = Color.Lime;
            lblCiro.Location = new Point(22, 28);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(0, 15);
            lblCiro.TabIndex = 9;
            // 
            // lblSiparisList
            // 
            lblSiparisList.FormattingEnabled = true;
            lblSiparisList.ItemHeight = 15;
            lblSiparisList.Location = new Point(83, 55);
            lblSiparisList.Name = "lblSiparisList";
            lblSiparisList.Size = new Size(270, 349);
            lblSiparisList.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblSiparisList);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "UrunEkle";
            Load += MenuEkle_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private Label lblSatılanUrunAdedi;
        private GroupBox groupBox3;
        private Label lblEkstraMalzeme;
        private GroupBox groupBox2;
        private Label lblToplamSparis;
        private GroupBox groupBox1;
        private ListBox lblSiparisList;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label lblCiro;
    }
}