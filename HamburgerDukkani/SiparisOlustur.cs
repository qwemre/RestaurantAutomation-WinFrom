using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace HamburgerDukkani
{
    public partial class SiparisOlustur : Form
    {
        List<CheckBox> checkBoxes = new List<CheckBox>();
        List<Siparis> siparisler = new List<Siparis>();
        public static int toplamFiyat = 0;
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            cbUrunler.DataSource = MainMenu.yemekler;
            foreach (Sos item in MainMenu.soslar)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.SosAdi;
                checkBoxes.Add(cb);
                flSosPaneli.Controls.Add(cb);
                rbKucuk.Checked = true;
            }
            rbKucuk.Checked = true;
            btnSiparisOnayla.Enabled = false;
        }
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            int fiyat = 0;
            siparis.ToplamSosFiyati = 0;
            foreach (var cb in checkBoxes)
            {
                foreach (Sos sos in MainMenu.soslar)
                {
                    if (sos.SosAdi == cb.Text && cb.Checked)
                    {
                        fiyat += sos.SosFiyati;
                        siparis.ToplamSosFiyati += sos.SosFiyati;
                        siparis.SosAdi += " " + cb.Text;
                    }
                }
            }
            foreach (Yemek item in MainMenu.yemekler)
            {
                if (cbUrunler.Text == item.YemekAdı)
                {
                    fiyat += item.YemekFiyati;
                    siparis.YemekAdi = item.YemekAdı;
                }
            }
            if (rbBuyuk.Checked)
            {
                fiyat += 50;
            }
            else if (rbOrta.Checked)
            {
                fiyat += 30;
            }
            fiyat *= (int)nmrMenuAdet.Value;
            toplamFiyat += fiyat;
            lblToplamFiyat.Text = "tl" + toplamFiyat;
            lbUrunler.Items.Add($"{nmrMenuAdet.Value} Adet {cbUrunler.Text} Menü - Soslar= {siparis.SosAdi} => Fiyat={fiyat}");
            siparis.Fiyat = fiyat;
            siparis.Adet = (int)nmrMenuAdet.Value;
            siparis.ToplamSosFiyati = siparis.ToplamSosFiyati;
            siparis.SosAdi = siparis.SosAdi;
            siparisler.Add(siparis);
            Helper.Temizle(this.Controls);
            btnSiparisOnayla.Enabled = true;

        }
        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {

            MainMenu.siparisler.AddRange(siparisler);
            Helper.Temizle2(this.Controls);
            lblToplamFiyat.Text = "₺";
            btnSiparisOnayla.Enabled = false;
        }

    }
}
