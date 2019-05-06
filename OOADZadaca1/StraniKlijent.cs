using System;
using System.Collections.Generic;
using System.Text;

namespace OOADZadaca1
{
    public class StraniKlijent : Klijent
    {
        string grad;
        string drzava;
        public StraniKlijent(string id, string ime, string prezime, string grad, DateTime datumrodjenja, string drzava) :
            base(id, ime, prezime, datumrodjenja)
        {

            grad = Grad;
            drzava = Drzava;
        }

        public string Grad { get => grad; set => grad = value; }
        public string Drzava { get => drzava; set => drzava = value; }
        public override double ObracunCijene(Avion a)
        {
            double cijena = base.ObracunCijene(a) - 100; // kaucija

            return cijena;

        }
    }
}
