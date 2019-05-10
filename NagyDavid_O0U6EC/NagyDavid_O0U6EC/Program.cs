using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyDavid_O0U6EC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Királyi raktár
            Termek[] raktar = new Termek[6];
            
            try
            {
                string[] textRaktar = File.ReadAllLines("../../raktar1.txt");
                for (int i = 0; i < textRaktar.Length; i++)
                {
                    string tipus;
                    string mertekegyseg;
                    string meret;
                    tipus = textRaktar[i].Split(' ')[0];
                    mertekegyseg = textRaktar[i].Split(' ')[1];
                    meret = textRaktar[i].Split(' ')[2];
                    switch (tipus)
                    {
                        case "Alma":
                            raktar[i] = new Alma(mertekegyseg, int.Parse(meret));
                            break;
                        case "Barack":
                            raktar[i] = new Barack(mertekegyseg, int.Parse(meret));
                            break;
                        case "Szena":
                            raktar[i] = new Szena(mertekegyseg, int.Parse(meret));
                            break;
                        case "Buza":
                            raktar[i] = new Buza(mertekegyseg, int.Parse(meret));
                            break;
                        case "Marha":
                            raktar[i] = new Marha(mertekegyseg, int.Parse(meret));
                            break;
                        case "Birka":
                            raktar[i] = new Birka(mertekegyseg, int.Parse(meret));
                            break;
                    }
                }
            }
            catch (FileNotFoundException a)
            {
                Console.WriteLine("A fajl nem talalhato!");
            }
            foreach (var item in raktar)
            {
                Console.WriteLine(item);
            }
            
           

            int ossz = 0;
            for (int i = 0; i < raktar.Length; i++)
            {
                ossz += raktar[i].Mennyiseg;
            }

            string[] eroforrasok = new string[ossz];

            int darab = 0;
            int j = 0;
            for (int i = 0; i < raktar.Length; i++)
            {
                darab = 0;
                while(darab != raktar[i].Mennyiseg)
                {
                    darab++;
                    eroforrasok[j] = raktar[i].Tipus;
                    j++;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < eroforrasok.Length; i++)
            {
                Console.Write(eroforrasok[i]+" ");
            }


            

            Console.WriteLine();
            for (int i = 0; i < eroforrasok.Length; i++)
            {
                Console.Write(eroforrasok[i] + " ");
            }

            Console.WriteLine();

            int[] mennyi = new int[raktar.Length];
            for (int i = 0; i < raktar.Length; i++)
            {
                mennyi[i] = raktar[i].Mennyiseg;
            }

            for (int i = 0; i < mennyi.Length; i++)
            {
                Console.Write(mennyi[i] + " ");
            }
            Console.WriteLine();


            string[] arryn = { "Alma", "Szena" };
            string[] greyjoy = { "Barack", "Szena" };
            string[] lannister = { "Szena", "Buza", "Alma" };
            string[] stark = { "Buza" };
            string[] targaryen = { "Barack", "Szena" };
            string[] tully = { "Birka", "Marha" };

            bool[,] viszony =
            {
                {false,false,false,false,false,false },
                {false,false,false,false,false,false },
                {false,false,false,false,false,false },
                {false,false,false,false,false,false },
                {false,false,false,false,false,false },
                {false,false,false,false,false,false }
                
            };

            int almagyak = 0;
            int barackgyak = 0;
            int buzagyak = 0;
            int birkagyak = 0;
            int szenagyak = 0;
            int marhagyak = 0;
            for (int i = 0; i < arryn.Length; i++)
            {
                if (arryn[i] == "Alma")
                    almagyak++;
                if (arryn[i] == "Barack")
                    barackgyak++;
                if (arryn[i] == "Buza")
                    buzagyak++;
                if (arryn[i] == "Birka")
                    birkagyak++;
                if (arryn[i] == "Szena")
                    szenagyak++;
                if (arryn[i] == "Marha")
                    marhagyak++;
            }
            for (int i = 0; i < greyjoy.Length; i++)
            {
                if (greyjoy[i] == "Alma")
                    almagyak++;
                if (greyjoy[i] == "Barack")
                    barackgyak++;
                if (greyjoy[i] == "Buza")
                    buzagyak++;
                if (greyjoy[i] == "Birka")
                    birkagyak++;
                if (greyjoy[i] == "Szena")
                    szenagyak++;
                if (greyjoy[i] == "Marha")
                    marhagyak++;
            }
            for (int i = 0; i < lannister.Length; i++)
            {
                if (lannister[i] == "Alma")
                    almagyak++;
                if (lannister[i] == "Barack")
                    barackgyak++;
                if (lannister[i] == "Buza")
                    buzagyak++;
                if (lannister[i] == "Birka")
                    birkagyak++;
                if (lannister[i] == "Szena")
                    szenagyak++;
                if (lannister[i] == "Marha")
                    marhagyak++;
            }
            for (int i = 0; i < stark.Length; i++)
            {
                if (stark[i] == "Alma")
                    almagyak++;
                if (stark[i] == "Barack")
                    barackgyak++;
                if (stark[i] == "Buza")
                    buzagyak++;
                if (stark[i] == "Birka")
                    birkagyak++;
                if (stark[i] == "Szena")
                    szenagyak++;
                if (stark[i] == "Marha")
                    marhagyak++;
            }
            for (int i = 0; i < targaryen.Length; i++)
            {
                if (targaryen[i] == "Alma")
                    almagyak++;
                if (targaryen[i] == "Barack")
                    barackgyak++;
                if (targaryen[i] == "Buza")
                    buzagyak++;
                if (targaryen[i] == "Birka")
                    birkagyak++;
                if (targaryen[i] == "Szena")
                    szenagyak++;
                if (targaryen[i] == "Marha")
                    marhagyak++;
            }
            for (int i = 0; i < tully.Length; i++)
            {
                if (tully[i] == "Alma")
                    almagyak++;
                if (tully[i] == "Barack")
                    barackgyak++;
                if (tully[i] == "Buza")
                    buzagyak++;
                if (tully[i] == "Birka")
                    birkagyak++;
                if (tully[i] == "Szena")
                    szenagyak++;
                if (tully[i] == "Marha")
                    marhagyak++;
            }

            int[] gyakorisagok = { almagyak, barackgyak, buzagyak, birkagyak, szenagyak, marhagyak };
            string[] termekek = { "Alma", "Barack", "Buza", "Birka", "Szena", "Marha" };

            

            LancoltLista<Termek> Arryn = new LancoltLista<Termek>(arryn, 4, "Arryn");
            LancoltLista<Termek> Greyjoy = new LancoltLista<Termek>(greyjoy, 3, "Greyjoy");
            LancoltLista<Termek> Lannister = new LancoltLista<Termek>(lannister, 2, "Lannister");
            LancoltLista<Termek> Stark = new LancoltLista<Termek>(stark, 1, "Stark");
            LancoltLista<Termek> Targaryen = new LancoltLista<Termek>(targaryen, 3, "Targaryen");
            LancoltLista<Termek> Tully = new LancoltLista<Termek>(tully, 5, "Tully");

            

            Arryn.ElejereBeszuras(new Alma("kg", 0));
            Arryn.ElejereBeszuras(new Szena("kg", 0));
            Greyjoy.ElejereBeszuras(new Barack("kg", 0));
            Greyjoy.ElejereBeszuras(new Szena("kg", 0));
            Lannister.ElejereBeszuras(new Szena("kg", 0));
            Lannister.ElejereBeszuras(new Buza("kg", 0));
            Lannister.ElejereBeszuras(new Marha("kg", 0));
            Stark.ElejereBeszuras(new Buza("kg", 0));
            Targaryen.ElejereBeszuras(new Barack("kg", 0));
            Targaryen.ElejereBeszuras(new Szena("kg", 0));
            Tully.ElejereBeszuras(new Birka("kg", 0));
            Tully.ElejereBeszuras(new Marha("kg", 0));


            /*
            LancoltLista<Termek>[] hazaktomb = new LancoltLista<Termek>[6];
            hazaktomb[0] = ref Arryn;
            hazaktomb[1] = ref Greyjoy;
            hazaktomb[2] = ref Lannister;
            hazaktomb[3] = ref Stark;
            hazaktomb[4] = ref Targaryen;
            hazaktomb[5] = ref Tully;

            */

            BinarisKeresofa<LancoltLista<Termek>> hazak = new BinarisKeresofa<LancoltLista<Termek>>();


            hazak.Add(Arryn);
            hazak.Add(Greyjoy);
            hazak.Add(Lannister);
            hazak.Add(Stark);
            hazak.Add(Targaryen);
            hazak.Add(Tully);

            //Kiosztas(raktar, hazak);

            for (int i = 0; i < viszony.GetLength(0); i++)
            {
                for (int o = 0; o < viszony.GetLength(1); o++)
                {
                    Console.Write(viszony[i,o]+" ");
                }
                Console.WriteLine();
            }

            //prefmennyek

            int[] prefmennyek = { 5, 7, 10, 4, 6, 2 };

            Egykioszt(raktar, hazak, gyakorisagok, termekek, viszony);
            Console.Read();
        }


        public static void Egykioszt(Termek[] raktar, BinarisKeresofa<LancoltLista<Termek>> hazak, int[] gyakorisagok, string[] termekek, bool[,] viszony)
        {
            Console.WriteLine();
            Console.WriteLine("METÓDUS");
            Console.WriteLine();
            for (int i = 0; i < gyakorisagok.Length - 1; i++)
            {
                for (int j = i + 1; j < gyakorisagok.Length; j++)
                {
                    if (gyakorisagok[i] > gyakorisagok[j])
                    {
                        int csere = gyakorisagok[j];
                        gyakorisagok[j] = gyakorisagok[i];
                        gyakorisagok[i] = csere;
                        string swap = termekek[j];
                        termekek[j] = termekek[i];
                        termekek[i] = swap;
                    }
                }
            }

            int k = 0;
            int c = 0;
            foreach (var item in hazak.CustomOrder(walk_style.inorder))
            {
                for (int j = 0; j < viszony.GetLength(1); j++)
                {
                    c = 0;
                    foreach (var a in item.preferencia)
                    {
                        if (a == termekek[j])
                        {
                            viszony[k, j] = true;
                        }
                        c++;
                    }

                }
                k++;
            }

            k = 0;
            int[,] tomb =
            {
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0 }
            };

            int s = 0;
            foreach (var item in hazak.CustomOrder(walk_style.inorder))
            {
                for (int j = 0; j < viszony.GetLength(1); j++)
                {
                    if (viszony[k, j] == true)
                    {
                        s = 0;
                        while (termekek[j] != raktar[s].Tipus)
                        {
                            s++;
                        }
                        while (raktar[s].Mennyiseg > 0 && item.prefmenny > 0)
                        {
                            Console.Write(termekek[j]+" ");
                            raktar[s].Mennyiseg--;
                            item.prefmenny--;

                            switch (raktar[s].Tipus)
                            {
                                case "Alma":
                                    foreach (var a in item)
                                        a.Plus(raktar[s].Tipus);
                                    break;
                                case "Barack":
                                    foreach (var a in item)
                                        a.Plus(raktar[s].Tipus);
                                    break;
                                case "Szena":
                                    foreach (var a in item)
                                        a.Plus(raktar[s].Tipus);
                                    break;
                                case "Buza":
                                    foreach (var a in item)
                                        a.Plus(raktar[s].Tipus);
                                    break;
                                case "Marha":
                                    foreach (var a in item)
                                        a.Plus(raktar[s].Tipus);
                                    break;
                                case "Birka":
                                    foreach (var a in item)
                                        a.Plus(raktar[s].Tipus);
                                    break;
                            }

                            tomb[k, j]++;
                        }

                    }

                }
                k++;
            }

            bool van = true;
            foreach (var item in hazak.CustomOrder(walk_style.inorder))
            {
                if (item.prefmenny > 0)
                {
                    van = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("EREDMÉNY KEZDETE");
            Console.WriteLine();
            try
            {
                if (van)
                {
                    Console.WriteLine("VAN MEGOLDÁS");
                }

                else
                {
                    Console.WriteLine("NINCS MEGOLDÁS");
                    throw new Kivetel("Nem sikerült kiosztani");
                }
            }
            catch(Kivetel p)
            {
                Console.WriteLine(p.Msg);
            }
                
            Console.WriteLine();
            for (int i = 0; i < termekek.Length; i++)
            {
                Console.Write(termekek[i] + " ");
            }
            Console.WriteLine();
            int h = 0;
            foreach (var item in hazak.CustomOrder(walk_style.inorder))
            {
                Console.Write(item.nev+ " ");
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write(tomb[h, j] + " ");
                }
                h++;
            Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("EREDMÉNY VÉGE");
            Console.WriteLine();
            for (int i = 0; i < viszony.GetLength(0); i++)
            {
                for (int j = 0; j < viszony.GetLength(1); j++)
                {
                    Console.Write(viszony[i,j]+" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < gyakorisagok.Length; i++)
            {
                Console.Write(gyakorisagok[i]+" ");
            }
            Console.WriteLine();
            for (int j = 0; j < termekek.Length; j++)
            {
                Console.Write(termekek[j] + " ");
            }
        }
    }

    /*
    for (int i = 0; i < szint; i++)
        if (eredmenyek[i].Tipus == xTermek.Tipus )
            return false;
    */

    /*
    static void osszesLehetoseg(Termek[] raktar, LancoltLista<Termek>[] hazaktomb)
    {
        for(int i=0; i<hazaktomb.Length; i++)
        {
            for(int j=0; j<hazaktomb[i].meret; j++)
            {
                switch(hazaktomb[i].ElementAt(j).Tipus)
                {
                    case "Alma":
                        if(raktar[0] >= 1)
                        {
                            hazaktomb[i]
                        }
                }
            }
        }
    }
    */
    /*static bool hazDone(LancoltLista<Termek> haz)
    {
        int db = 0;
        foreach(var elem in haz)
        {
            db += elem.Mennyiseg;
        }
        if(haz.prefmenny == db)
        {
            return true;
        }
        return false;
    }
    static bool hazakDone(LancoltLista<Termek>[] hazak)
    {
        foreach(var elem in hazak)
        {
            if(!hazDone(elem))
            {
                return false;
            }
        }
        return true;
    }
    static void hozzaad(LancoltLista<Termek> haz, Termek termek, Termek[] raktar)
    {
        foreach(var item in haz)
        {
            if(item.Tipus == termek.Tipus)
            {
                foreach(var rak in raktar)
                {
                    if(rak.Tipus == termek.Tipus)
                    {
                        rak.Mennyiseg--;
                        item.Mennyiseg++;
                    }
                }
            }
        }
    }
    static bool vaneraktaron(Termek termek, Termek[] raktar)
    {
        foreach(var item in raktar)
        {
            if(item.Tipus == termek.Tipus)
            {
                return item.Mennyiseg >= 1;
            }
        }
        return false;
    }
    static int mennyiraktar(Termek termek, Termek[] raktar)
    {
        foreach (var item in raktar)
        {
            if (item.Tipus == termek.Tipus)
            {
                return item.Mennyiseg;
            }
        }
        return 0;
    }*/

    


}
