using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyDavid_O0U6EC
{
    abstract class Gyumolcs : Termek
    {
        public Gyumolcs(string mertekegyseg, int mennyiseg)
        {
            Mertekegyseg = mertekegyseg;
            Mennyiseg = mennyiseg;
        }

        public string Mertekegyseg { get; set; }
        
        

        public override string ToString()
        {
            return string.Format("Tipus:{2}, Mertekegyseg:{0}, Mennyiseg:{1}", Mertekegyseg, Mennyiseg, Tipus);
        }
    }
}
