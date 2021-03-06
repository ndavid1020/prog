﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyDavid_O0U6EC
{
    class LancoltLista<T> : IEnumerable<T>
    {
        class ListaElem
        {
            public T tartalom;
            public ListaElem kovetkezo;
        }
        ListaElem fej;
        public int meret { get; set; }
        public string[] preferencia { get; set; }
        public int prefmenny { get; set; }
        public string nev { get; set; }
        public LancoltLista(string []pref, int menny, string nev)
        {
            prefmenny = menny;
            this.nev = nev;
            preferencia = pref;
            this.meret = 0;
        }

        public void ElejereBeszuras(T elem)
        {
            ListaElem uj = new ListaElem();
            uj.tartalom = elem;
            uj.kovetkezo = fej;
            meret++;
            fej = uj;
        }

        public void VegereBeszuras(T elem)
        {
            ListaElem uj = new ListaElem();
            uj.tartalom = elem;

            if (fej == null)
            {
                fej = uj;
            }
            else
            {
                ListaElem p = fej;
                while (p.kovetkezo != null)
                {
                    p = p.kovetkezo;
                }
                p.kovetkezo = uj;
            }
            meret++;
        }

        public void Torles(T elem)
        {
            ListaElem p = fej;
            ListaElem e = null;
            while (p != null && !p.tartalom.Equals(elem))
            {
                e = p;
                p = p.kovetkezo;
            }
            if (p != null)
            {
                if (e == null)
                {
                    fej = fej.kovetkezo;
                }
                else
                {
                    e.kovetkezo = p.kovetkezo;
                }
            }
            meret--;
        }

        public delegate void Muvelet(T elem);

        public void Bejaro(Muvelet m)
        {
            ListaElem p = fej;
            while (p != null)
            {
                m(p.tartalom);
                p = p.kovetkezo;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListaEnumerator(fej);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        class ListaEnumerator : IEnumerator<T>
        {

            ListaElem fej;
            ListaElem akt;
            public ListaEnumerator(ListaElem fej)
            {
                this.fej = fej;
                akt = null;
            }

            public T Current => akt.tartalom;

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                fej = null;
                akt = null;
            }

            public bool MoveNext()
            {
                if (akt == null)
                {
                    akt = fej;
                }
                else
                {
                    akt = akt.kovetkezo;
                }
                return akt != null;
            }

            public void Reset()
            {
                akt = null;
            }
        }



    }
}