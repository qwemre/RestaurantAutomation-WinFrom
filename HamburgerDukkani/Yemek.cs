using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerDukkani
{
    public class Yemek
    {

        public string YemekAdı { get; set; }
        public int YemekFiyati { get; set; }
        public Boyut Boyut { get; set; }

        public override string ToString()
        {
            return YemekAdı;
        }
    }
}
