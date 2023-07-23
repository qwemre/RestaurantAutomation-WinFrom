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
    public partial class MenuEkleme : Form
    {
        public MenuEkleme()
        {
            InitializeComponent();

        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            Yemek yemek = new Yemek();
            yemek.YemekAdı = txtEkstraMenü.Text;
            yemek.YemekFiyati = (int)nmrEkstraMenüFiyat.Value;
            MainMenu.yemekler.Add(yemek);
            Helper.Temizle(this.Controls);

        }
    }
}
