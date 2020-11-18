using System;

namespace ConsoleApp1
{
    enum Mera
    {
        MIN,
        MAX
    }

    class Program
    {
        public static void IspisiNiz(Tacka[] nizTacaka)
        {
            foreach (Tacka tacka in nizTacaka)
            {
                tacka.Ispis();
            }
        }

        public static void Nadji(Tacka[] nizTacaka, Mera mera, VrstaUdaljenosti vrstaUdaljenosti)
        {
            double minUdaljenost = 0;
            double maxUdaljenost = 0;
            Tacka tackaMinUdaljenost = null;
            Tacka tackaMaxUdaljenost = null;
            double trenutnaUdaljenost = 0;

            if (mera == Mera.MIN)
            {
                foreach (Tacka trenutnaTacka in nizTacaka)
                {
                    trenutnaUdaljenost = trenutnaTacka.UdaljenostOdCentra(vrstaUdaljenosti);
                    if (trenutnaUdaljenost < minUdaljenost)
                    {
                        minUdaljenost = trenutnaUdaljenost;
                        tackaMinUdaljenost = trenutnaTacka;
                    }
                }

                Console.WriteLine("Tacka sa minimalnom udaljenoscu je T(" + tackaMinUdaljenost.X + " , " + tackaMinUdaljenost.Y + ")");
                Console.WriteLine("Minimalna udaljenost za " + vrstaUdaljenosti + " je: " + minUdaljenost);

            } else
            {
                foreach (Tacka trenutnaTacka in nizTacaka)
                {
                    trenutnaUdaljenost = trenutnaTacka.UdaljenostOdCentra(vrstaUdaljenosti);
                    if (trenutnaUdaljenost > maxUdaljenost)
                    {
                        maxUdaljenost = trenutnaUdaljenost;
                        tackaMaxUdaljenost = trenutnaTacka;
                    }
                }

                Console.WriteLine("Tacka sa maksimalnom udaljenoscu je T(" + tackaMaxUdaljenost.X + " , " + tackaMaxUdaljenost.Y + ")");
                Console.WriteLine("Maksimalna udaljenost za " + vrstaUdaljenosti + " je" + maxUdaljenost);
            }
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("Unesite broj: ");
            int suma = 0;
            int trenutni;
            for (int i = 0; i < 3; i++)
            {
                var inputField = Console.ReadLine();
                trenutni = Int32.Parse(inputField);
                suma = suma + trenutni;
            }
            
            Console.WriteLine("Suma je:"+ suma);
            */

            Korisnik k = new Korisnik("Nikola", "Nikolic", TipKorisnika.Student, 25);
            Console.WriteLine(k);

            Tacka t1 = new Tacka(1, 2);
            Tacka t2 = new Tacka(2, 5);
            Tacka t3 = new Tacka(10, 10);
            Tacka t4 = new Tacka(2, 6);

            Tacka[] nizTacaka = { t1, t2, t3, t4 };

            IspisiNiz(nizTacaka);

            Console.WriteLine("Udaljenosti: ");
            Console.WriteLine(t1.Udaljenost(t2, VrstaUdaljenosti.MENHETN));
            Console.WriteLine(t1.Udaljenost(t2, VrstaUdaljenosti.DIJAGONALNO));
        }
    }
}
