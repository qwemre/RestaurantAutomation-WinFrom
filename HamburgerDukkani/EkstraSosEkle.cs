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
    public partial class EkstraSosEkle : Form
    {
        public EkstraSosEkle()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            Sos sos = new Sos();
            sos.SosAdi = txtEkstraMalzemeAdi.Text;
            sos.SosFiyati = (int)nmrEkstraMalzemeFiyati.Value;
            MainMenu.soslar.Add(sos);
            Helper.Temizle(this.Controls);


        }
    }
}
