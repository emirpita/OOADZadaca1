using System;
using System.Collections.Generic;
using System.Text;

namespace OOADZadaca1
{
    public class Iznajmljivanje
    {
        Klijent k;
        DateTime pocetniDatum, krajniDatum;

        public Iznajmljivanje(Klijent k, DateTime pocetak, DateTime kraj)
        {
            K = k;

            PocetniDatum = pocetak;
            KrajniDatum = kraj;
        }
        public Iznajmljivanje() { }

        public Klijent K { get => k; set => k = value; }
        public DateTime PocetniDatum { get => pocetniDatum; set => pocetniDatum = value; }
        public DateTime KrajniDatum { get => krajniDatum; set => krajniDatum = value; }

    }
}
