using System;
using System.Collections.Generic;
using System.Text;

namespace OOADZadaca1
{
    public class DomaciKlijent : Klijent
    {
        public DomaciKlijent(string id, string ime, string prezime, DateTime datumrodjenja) : base(id, ime, prezime, datumrodjenja)
        {

        }

        public override double ObracunCijene(Avion a)
        {
            double cijena = base.ObracunCijene(a) - 50; // kaucija
            return cijena;
        }
    }
}
