using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumTest
{
    class Program
    {
        public enum Napok
        {
            Hétfő       = 1,
            Kedd        = 2,
            Szerda      = 3,
            Csütörtök   = 4,
            Péntek      = 5,
            Szombat     = 6,
            Vasárnap   // = 7 alapból indexel
        }

        public enum Italok
        {
            Tonic = 990,
            Cola = 120,
            JimBeam = 9990
        }

        static void Main(string[] args)
        {   
        }
    }
}
