using System.Security.Cryptography.X509Certificates;

namespace HamburgerDukkani
{
    public partial class MainMenu : Form
    {
        public static List<Sos> soslar;
        public static List<Yemek> yemekler;
        public static List<Siparis> siparisler;

        public MainMenu()
        {
            siparisler = new List<Siparis>();
            yemekler = new List<Yemek>();
            soslar = new List<Sos>();
            yemekler.Add(new Yemek() { YemekAdý = "bigMac", YemekFiyati = 250 });
            yemekler.Add(new Yemek() { YemekAdý = "bigwoper", YemekFiyati = 350 });
            soslar.Add(new Sos() { SosAdi = "ketcap", SosFiyati = 20 });
            soslar.Add(new Sos() { SosAdi = "mayonez", SosFiyati = 25 });

            InitializeComponent();
            FormEkle();
        }
        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEkle();
        }
        private void tümSipariþlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            formlariKapat();
            TumSiparisler menuEkle = new();
            menuEkle.MdiParent = this;
            menuEkle.Dock = DockStyle.Fill;
            this.Width = menuEkle.Width + 50;
            this.Height = menuEkle.Height + 90;
            menuEkle.Show();


        }
        private void FormEkle()
        {
            formlariKapat();
            SiparisOlustur siparisOlusturma = new();
            siparisOlusturma.MdiParent = this;
            siparisOlusturma.Dock = DockStyle.Fill;
            this.Width = siparisOlusturma.Width + 50;
            this.Height = siparisOlusturma.Height + 90;
            siparisOlusturma.Show();
        }
        private void formlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formlariKapat();
            MenuEkleme tümSiparisler = new();
            tümSiparisler.MdiParent = this;
            tümSiparisler.Dock = DockStyle.Fill;
            this.Width = tümSiparisler.Width + 50;
            this.Height = tümSiparisler.Height + 90;
            tümSiparisler.Show();
        }
        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formlariKapat();
            EkstraSosEkle malzemeEkle = new();
            malzemeEkle.MdiParent = this;
            malzemeEkle.Dock = DockStyle.Fill;
            this.Width = malzemeEkle.Width + 50;
            this.Height = malzemeEkle.Height + 90;
            malzemeEkle.Show();
        }
    }
}