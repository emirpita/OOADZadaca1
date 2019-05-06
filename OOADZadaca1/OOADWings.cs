using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace OOADZadaca1
{
    public class OOADWings : IPretraga
    {
        List<Avion> avioni;
        List<Klijent> klijenti;
        List<Avion> iznajmljeniAvioni;
        Iznajmljivanje i;

        public OOADWings(List<Avion> avioni, List<Klijent> klijenti, Iznajmljivanje i, List<Avion> av)
        {
            Avioni = avioni;
            Klijenti = klijenti;
            IznajmljeniAvioni = av;
            I = i;
        }

        public OOADWings()
        {
            avioni = new List<Avion>();
            iznajmljeniAvioni = new List<Avion>();
            i = new Iznajmljivanje();
            klijenti = new List<Klijent>();
        }
        public List<Avion> Avioni { get => avioni; set => avioni = value; }
        public List<Klijent> Klijenti { get => klijenti; set => klijenti = value; }
        public Iznajmljivanje I { get => i; set => i = value; }
        public List<Avion> IznajmljeniAvioni { get => iznajmljeniAvioni; set => iznajmljeniAvioni = value; }
        public void dodajKlijenta(Klijent k)
        {
            klijenti.Add(k);
        }
        public void dodajAvion(Avion a)
        {
            avioni.Add(a);
        }

        public List<Avion> pretraga1(string sifra)
        {
            return avioni.FindAll(x => x.ID == sifra);
        }
        public List<Avion> pretraga2(Avion a)
        {
            return avioni.FindAll(x => x.Vrsta == a.Vrsta && x.BrojSjedista == a.BrojSjedista);
        }

        public List<Klijent> provjeraKlijenta(string sifra)
        {
            return klijenti.FindAll(x => x.ID == sifra);
        }
        delegate void Delegat1(string sifraa);
        delegate void Delegat2(Avion a);

        public void iznajmiVozilo(Klijent k, Avion a)
        {
            bool jesteKlijent = false;
            foreach (Klijent kl1 in klijenti.Where(kl1 => k.ID == kl1.ID))
            {
                jesteKlijent = true;
                break;
            }
            if (jesteKlijent)
            {
                List<Avion> lista = pretraga1(a.ID);
                if (lista.Count > 0)
                {
                    foreach (Avion avion in lista)
                    {
                        Console.WriteLine(avion.ToString());
                        Console.WriteLine("\n");
                    }

                    DateTime pocDatum = DateTime.Now;
                    int god, m, d;
                    Console.WriteLine("Unesite pocetni datum iznajmljivanja:");
                    Console.WriteLine("Godina: ");
                    Int32.TryParse(Console.ReadLine(), out god);
                    Console.WriteLine("Mjesec: ");
                    Int32.TryParse(Console.ReadLine(), out m);
                    Console.WriteLine("Dan: ");
                    Int32.TryParse(Console.ReadLine(), out d);
                    try
                    {
                        pocDatum = new DateTime(god, m, d);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.ReadLine();
                    }

                    DateTime krDatum = DateTime.Now;
                    int god2, m2, d2;
                    Console.WriteLine("Unesite krajnji datum iznajmljivanja:");
                    Console.WriteLine("Godina: ");
                    Int32.TryParse(Console.ReadLine(), out god2);
                    Console.WriteLine("Mjesec: ");
                    Int32.TryParse(Console.ReadLine(), out m2);
                    Console.WriteLine("Dan: ");
                    Int32.TryParse(Console.ReadLine(), out d2);
                    try
                    {
                        krDatum = new DateTime(god2, m2, d2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.ReadLine();
                    }
                    string idAv;
                    Console.WriteLine("ID aviona: ");
                    idAv = Console.ReadLine();

                    foreach (Avion x in lista.Where(x => x.ID == idAv))
                    {
                        x.i.PocetniDatum = pocDatum;
                        x.i.KrajniDatum = krDatum;
                        avioni.Add(x);
                    }
                }
            }
            else
            {
                // .NET Framework potreban!!!

                /*Form form = new Form();
                TextBox mojTextBox = new TextBox();
                mojTextBox.Size = new Size(169, 20);
                mojTextBox.Location = new Point(75, 166);
                form.Controls.Add(mojTextBox);
                mojTextBox.Font = new Font("Arial", 12);
                mojTextBox.Text = "Pretraga nije vratila rezultat";*/

                Console.WriteLine("Pretraga nije vratila rezultat");
            }

        }
    }
}
