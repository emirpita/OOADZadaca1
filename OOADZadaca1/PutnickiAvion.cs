using System;
using System.Collections.Generic;
using System.Text;

namespace OOADZadaca1
{
    public class PutnickiAvion : Avion
    {

        public PutnickiAvion(string id, string vrsta, int brojSjedista) : base(id, vrsta, brojSjedista)
        {

        }

        public override string ToString()
        {
            return "Vrsta aviona " + Vrsta + "\n ID aviona: " + ID +
                "\n Broj sjedista: " + BrojSjedista;
        }
    }
}
