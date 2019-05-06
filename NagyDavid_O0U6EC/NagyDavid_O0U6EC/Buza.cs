using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyDavid_O0U6EC
{
    class Buza : Takarmany
    {
        public Buza(string mertekegyseg, int mennyiseg) : base(mertekegyseg, mennyiseg)
        {
            Tipus = "Buza";
        }
    }
}
