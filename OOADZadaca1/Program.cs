using System;

namespace OOADZadaca1
{
    class Program
    {
        static OOADWings o = new OOADWings();
        static void Main(string[] args)
        {
            string ulaz;
            int izbor;
            do
            {
                Console.WriteLine("Dobro došli! Odaberite: \n");
                Console.WriteLine("1.Unos vozila");
                Console.WriteLine("2.Unos klijenta");
                Console.WriteLine("3.Iznajmljivanje");
                Console.WriteLine("4.Povrat aviona i placanje");
                Console.WriteLine("5.Ispis liste obavijesti");
                Console.WriteLine("6.Izlaz");
                do
                {
                    Console.WriteLine("Unesite komandu: ");
                    ulaz = Console.ReadLine();
                    Int32.TryParse(ulaz, out izbor);
                    if (izbor < 1 || izbor > 6)
                    {
                        Console.WriteLine("\nPogresan unos! Unesite komandu ponovo!");
                        Console.WriteLine("Unesite komandu: ");
                        ulaz = Console.ReadLine();
                        Int32.TryParse(ulaz, out izbor);
                    }
                }
                while (izbor < 1 || izbor > 6);
                switch (izbor)
                {
                    case 1:
                        {
                            Console.WriteLine("Putnicki avion 1 \n Teretni avion 2 ");
                            string b = Console.ReadLine();
                            if (b.Equals("1"))
                            {
                                Console.WriteLine("Unesite identifikacijski broj: ");
                                String id = Console.ReadLine();
                                Console.WriteLine("Unesite vrstu aviona: ");
                                String vrsta = Console.ReadLine();
                                Console.WriteLine("Unesite broj sjedista: ");
                                string broj = Console.ReadLine();
                                int x = 0;
                                Int32.TryParse(broj, out x);
                                PutnickiAvion a = new PutnickiAvion(id, vrsta, x);
                                o.dodajAvion(a);
                            }
                            else
                            {
                                Console.WriteLine("Unesite identifikacijski broj: ");
                                String id = Console.ReadLine();
                                Console.WriteLine("Unesite vrstu aviona: ");
                                String vrsta = Console.ReadLine();
                                Console.WriteLine("Unesite broj sjedista: ");
                                string broj = Console.ReadLine();
                                int x = 0;
                                Int32.TryParse(broj, out x);
                                Console.WriteLine("Unesite ukupni kapacitet u kilogramima: ");
                                string kg1 = Console.ReadLine();
                                int kg2 = 0;
                                Int32.TryParse(kg1, out kg2);
                                TeretniAvion a = new TeretniAvion(id, vrsta, x, kg2);
                                o.dodajAvion(a);
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Domaci klijenti 1 \n Strani klijenti 2 ");
                            string b = Console.ReadLine();
                            if (b.Equals("1"))
                            {
                                Console.WriteLine("Unesite ime klijenta: ");
                                String ime = Console.ReadLine();
                                Console.WriteLine("Unesite prezime klijenta: ");
                                String prezime = Console.ReadLine();
                                DateTime datumRodjenja = DateTime.Now;
                                int god, m, d;
                                Console.WriteLine("Unesite datum rodjenja klijenta:");
                                Console.WriteLine("Godina: ");
                                Int32.TryParse(Console.ReadLine(), out god);
                                Console.WriteLine("Mjesec: ");
                                Int32.TryParse(Console.ReadLine(), out m);
                                Console.WriteLine("Dan: ");
                                Int32.TryParse(Console.ReadLine(), out d);
                                try
                                {
                                    datumRodjenja = new DateTime(god, m, d);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.ToString());
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Unesite id: ");
                                string broj = Console.ReadLine();

                                DomaciKlijent k = new DomaciKlijent(broj, ime, prezime, datumRodjenja);
                                o.dodajKlijenta(k);
                            }
                            else
                            {
                                Console.WriteLine("Unesite ime klijenta: ");
                                String ime = Console.ReadLine();
                                Console.WriteLine("Unesite prezime klijenta: ");
                                String prezime = Console.ReadLine();
                                DateTime datumRodjenja = DateTime.Now;
                                int god, m, d;
                                Console.WriteLine("Unesite datum rodjenja klijenta:");
                                Console.WriteLine("Godina: ");
                                Int32.TryParse(Console.ReadLine(), out god);
                                Console.WriteLine("Mjesec: ");
                                Int32.TryParse(Console.ReadLine(), out m);
                                Console.WriteLine("Dan: ");
                                Int32.TryParse(Console.ReadLine(), out d);
                                try
                                {
                                    datumRodjenja = new DateTime(god, m, d);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.ToString());
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Unesite id: ");
                                string broj = Console.ReadLine();

                                Console.WriteLine("Unesite grad stanovanja: ");
                                String grad = Console.ReadLine();
                                Console.WriteLine("Unesite drzavu stanovanja: ");
                                String drzava = Console.ReadLine();

                                StraniKlijent k = new StraniKlijent(broj, ime, prezime, grad, datumRodjenja, drzava);
                                o.dodajKlijenta(k);
                            }
                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (izbor != 8);

            Console.ReadLine();
        }
    }

}

