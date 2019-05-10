using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyDavid_O0U6EC
{
    class Kivetel : ApplicationException
    {
        string msg;

        public Kivetel(string msg)
        {
            this.Msg = msg;
            
        }

        public string Msg { get => msg; set => msg = value; }
    }
}
