using System;
using System.Collections.Generic;
using System.Text;

namespace OOADZadaca1
{
    public abstract class Klijent
    {
        string id;
        string ime;
        string prezime;
        DateTime datumrodjenja;

        public Klijent(string id, string ime, string prezime, DateTime datumrodjenja)
        {
            ime = Ime;
            prezime = Prezime;
            datumrodjenja = DatumRodjenja;
            id = ID;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumrodjenja; set => datumrodjenja = value; }
        public string ID { get => id; set => id = value; }

        public virtual string IdProvjera()
        {
            string x = "a"; //zbog inicijalizacije
            if (ID.Length == 6)
                x = ID;
            return x;
        }
        public virtual double ObracunCijene(Avion a)
        {
            double cijena = 0;
            if (a.GetType() == typeof(PutnickiAvion)) cijena = (a.i.KrajniDatum.Day - a.i.PocetniDatum.Day) * 120;
            else if (a.GetType() == typeof(StraniKlijent)) cijena = (a.i.KrajniDatum.Day - a.i.PocetniDatum.Day) * 200;
            else if (a.GetType() == typeof(TeretniAvion))
            {
                cijena = (a.i.KrajniDatum.Day - a.i.PocetniDatum.Day) * 350;
                TeretniAvion ta = (TeretniAvion)a;
                cijena += ta.Kapacitet / 1000 * 0.02; // racunanje za teretni avion
            }

            if ((a.i.PocetniDatum.Day.Equals("Subota") || a.i.PocetniDatum.Day.Equals("Nedjelja"))
                && a.GetType() == typeof(DomaciKlijent)) cijena += 500;
            else if ((a.i.PocetniDatum.Day.Equals("Subota") || a.i.PocetniDatum.Day.Equals("Nedjelja"))
                && a.GetType() == typeof(StraniKlijent)) cijena += 1000;

            return cijena;
        }

    }
}
