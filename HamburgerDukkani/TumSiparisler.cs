using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerDukkani
{
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
        {
            InitializeComponent();
        }

        private void MenuEkle_Load(object sender, EventArgs e)
        {
            int sosSayisi = 0;
            int yemekSayisi = 0;
            lblSiparisList.Items.Clear();
            foreach (var siparis in MainMenu.siparisler)
            {
                lblSiparisList.Items.Add(siparis.Adet + " Adet " + siparis.YemekAdi  +" Sos=" + siparis.SosAdi  +  " =>       " + siparis.Fiyat + "tl");
                sosSayisi += siparis.ToplamSosFiyati;
                yemekSayisi += siparis.Adet;
            }
            lblCiro.Text = SiparisOlustur.toplamFiyat.ToString();
            lblToplamSparis.Text = MainMenu.siparisler.Count.ToString();
            lblEkstraMalzeme.Text = sosSayisi.ToString();
            lblSatılanUrunAdedi.Text = yemekSayisi.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
