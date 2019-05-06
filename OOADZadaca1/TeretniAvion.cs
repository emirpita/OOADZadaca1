using System;
using System.Collections.Generic;
using System.Text;

namespace OOADZadaca1
{
    public class TeretniAvion : Avion
    {
        int kapacitet; // u tonama
        public TeretniAvion(string id, string vrsta, int brojSjedista, int kapacitet) : base(id, vrsta, brojSjedista)
        {
            kapacitet = Kapacitet;
        }

        public int Kapacitet { get => kapacitet; set => kapacitet = value; }
        public override string ToString()
        {
            return "Vrsta aviona " + Vrsta + "\n ID aviona: " + ID +
                "\n Broj sjedista: " + BrojSjedista + "\n Ukupni kapacitet: " + Kapacitet;
        }
    }
}
