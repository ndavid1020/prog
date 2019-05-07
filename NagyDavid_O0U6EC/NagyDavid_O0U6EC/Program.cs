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
            /*
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
                        case "alma":
                            raktar[i] = new Alma(mertekegyseg, int.Parse(meret));
                            break;
                        case "barack":
                            raktar[i] = new Barack(mertekegyseg, int.Parse(meret));
                            break;
                        case "szena":
                            raktar[i] = new Szena(mertekegyseg, int.Parse(meret));
                            break;
                        case "buza":
                            raktar[i] = new Buza(mertekegyseg, int.Parse(meret));
                            break;
                        case "marha":
                            raktar[i] = new Marha(mertekegyseg, int.Parse(meret));
                            break;
                        case "birka":
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
            */
            ///Teszt raktár
            raktar[0] = new Alma("kg", 0);
            raktar[1] = new Barack("kg", 1);
            raktar[2] = new Buza("kg", 3);
            raktar[4] = new Szena("kg", 1);
            raktar[3] = new Birka("kg", 1);
            raktar[5] = new Marha("kg", 1);

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

            string[] arryn = { "Alma", "Barack" };
            string[] greyjoy = { "Buza", "Alma" };
            string[] lannister = { "Birka", "Szena" };
            string[] stark = { "Alma", "Buza" };
            string[] targaryen = { "Barack", "Szena" };
            string[] tully = { "Birka", "Marha" };


            LancoltLista<Termek> Arryn = new LancoltLista<Termek>(arryn, 5);
            LancoltLista<Termek> Greyjoy = new LancoltLista<Termek>(greyjoy, 7);
            LancoltLista<Termek> Lannister = new LancoltLista<Termek>(lannister, 10);
            LancoltLista<Termek> Stark = new LancoltLista<Termek>(stark, 4);
            LancoltLista<Termek> Targaryen = new LancoltLista<Termek>(targaryen, 6);
            LancoltLista<Termek> Tully = new LancoltLista<Termek>(tully, 2);
            
            Arryn.ElejereBeszuras(new Alma("kg", 0));
            Arryn.ElejereBeszuras(new Barack("kg", 0));
            Greyjoy.ElejereBeszuras(new Barack("kg", 0));
            Greyjoy.ElejereBeszuras(new Birka("kg", 0));
            Lannister.ElejereBeszuras(new Birka("kg", 0));
            Lannister.ElejereBeszuras(new Marha("kg", 0));
            Stark.ElejereBeszuras(new Marha("kg", 0));
            Stark.ElejereBeszuras(new Szena("kg", 0));
            Targaryen.ElejereBeszuras(new Szena("kg", 0));
            Targaryen.ElejereBeszuras(new Buza("kg", 0));
            Tully.ElejereBeszuras(new Buza("kg", 0));
            Tully.ElejereBeszuras(new Alma("kg", 0));


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

            Console.WriteLine();
            foreach (var item in hazak.CustomOrder(walk_style.inorder))
            {
                Console.WriteLine();
                foreach (var a in item)
                {
                    Console.WriteLine(a);
                }
            }

            Console.WriteLine();
            Console.WriteLine("RAKTÁR!!!");
            Console.WriteLine();
            foreach (var item in raktar)
            {
                Console.WriteLine(item);
            }


            //Backtrack

            string[,] R = new string[6, eroforrasok.Length];

           /* // Arryn haz
            R[0, 0] = new Termek() { Tipus = "Alma" };
            R[0, 1] = new Termek() { Tipus = "Barack" };

            // Greyjoy
            R[1, 0] = new Termek() { Tipus = "Barack" };
            R[1, 1] = new Termek() { Tipus = "Marha" };

            // Stark
            R[2, 0] = new Termek() { Tipus = "Marha" };
            R[2, 1] = new Termek() { Tipus = "Birka" };

            // 4. haz
            R[3, 0] = new Termek() { Tipus = "Birka" };
            R[3, 1] = new Termek() { Tipus = "Szena" };

            // 5. haz
            R[4, 0] = new Termek() { Tipus = "Szena" };
            R[4, 1] = new Termek() { Tipus = "Buza" };

            // 6. haz
            R[5, 0] = new Termek() { Tipus = "Buza" };
            R[5, 1] = new Termek() { Tipus = "Alma" };
            */
            for (int i = 0; i < R.GetLength(0); i++)
            {
                for (int k = 0; k < R.GetLength(1); k++)
                {
                    R[i, k] = eroforrasok[k];
                }
            }


            ///Alma, Barack, Marha, Birka, Széna, Búza

            int[] M = new int[R.GetLength(0)];

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = eroforrasok.Length-1;
            }

            string[] E = new string[eroforrasok.Length];

            bool van = false;



            BTS(0, ref E, ref van, M, R, raktar);
            //osszesLehetoseg(R, raktar, hazaktomb);
            if (van)
            {
                for (int i = 0; i < E.Length; i++)
                {
                    Console.WriteLine(E[i]);
                }
            }
            else
            {
                Console.WriteLine("Nincs Megoldas");
            }
            

            Console.Read();
        }

        /*public static void Kiosztas(Termek[] raktar, BinarisKeresofa<LancoltLista<Termek>> hazak)
        {
            foreach (var item in hazak.CustomOrder(walk_style.preorder))
            {
                for (int i = 0; i < item.preferencia.Length; i++)
                {
                    if (item.prefmenny > 0)
                    {
                        int j = 0;

                        while ((raktar[j] as Termek).Tipus == item.preferencia[i] && item.prefmenny > 0 && (raktar[j] as Termek).Mennyiseg > 0 && j < raktar.Length)
                        {
                            item.ElejereBeszuras(raktar[j]);
                            item.prefmenny--;
                            (raktar[j] as Termek).Mennyiseg--;

                        }
                    }
                    
                }
               Console.WriteLine("Ennyiszer");
            }
            
        }*/

        
        static void BTS(int szint, ref string[] E, ref bool van, int[] M, string[,] R, Termek[] raktar)
        {
            int i = -1;
            while (!van && i < M[szint])
            {
                i++;
                if (Ft(szint, R[szint, i])) 
                {
                    if (Fk(E, szint, R[szint, i], raktar))
                    {
                        E[szint] = R[szint, i];
                        
                        if (szint == R.GetLength(0) - 1)
                        {
                            van = true;
                        }
                        else
                        {
                            BTS(szint + 1, ref E, ref van, M, R, raktar);
                            
                        }
                    }
                }
            }
        }

        static bool Ft(int szint, string r) //Feltétel
        {
            return true;
        }

        static bool Fk(string[] eredmenyek, int szint, string xEmber, Termek [] raktar) //Feltétel
        {
            int j = 0;
            for (int i = 0; i < eredmenyek.Length; i++)
            {
                j = 0;
                while (eredmenyek[i] != raktar[j].Tipus && j < raktar.Length-1)
                {
                    j++;
                }
                if (eredmenyek[i] == raktar[j].Tipus)
                {
                    if (raktar[j].Mennyiseg <= 0)
                    {
                        return false;
                    }
                }
                   
            }

            raktar[j].Mennyiseg--;
            return true;
        }

        /*
        for (int i = 0; i < szint; i++)
            if (eredmenyek[i].Tipus == xTermek.Tipus )
                return false;
        */
    }
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
