using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyDavid_O0U6EC
{
    class Szena : Takarmany
    {
        public Szena(string mertekegyseg, int mennyiseg) : base(mertekegyseg, mennyiseg)
        {
            Tipus = "Szena";
        }
    }
}
