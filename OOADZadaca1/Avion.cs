using System;
using System.Collections.Generic;
using System.Text;

namespace OOADZadaca1
{
    public abstract class Avion
    {
        string id;
        string vrsta;
        int brojSjedista;
        //Iznajmljivanje i;
        public Avion(string id, string vrsta, int brojSjedista)
        {
            id = ID;
            vrsta = Vrsta;
            brojSjedista = BrojSjedista;
        }

        public Iznajmljivanje i { get => i; set => i = value; }
        public String Vrsta { get => vrsta; set => vrsta = value; }
        public int BrojSjedista { get => brojSjedista; set => brojSjedista = value; }
        public string ID { get => id; set => id = value; }
        public abstract override string ToString();

        public virtual char idProvjera()
        {
            char x = 'a'; //zbog inicijalizacije
            for (int i = 1; i < 10; i++)
            {
                if (((ID[i] >= 'a' && ID[i] <= 'z') || (ID[i] >= 1 && ID[i] <= 5)) && ID.Length <= 9)
                    x = ID[i];
            }
            return x;
        }


    }
}
