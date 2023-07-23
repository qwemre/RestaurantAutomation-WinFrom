using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerDukkani
{
    public  class Dükkan
    {
        public List<Siparis>siparsiListesi { get; set; }
        public int Ciro { get; set; }
        public int SatılanUrun { get; set; }
        public int EkstraMalzemeUrunu { get; set; }
        public int ToplamSiparis { get; set; }

    }
}
