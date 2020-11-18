using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void IspisiNiz(Tacka[] nizTacaka)
        {
            foreach (Tacka tacka in nizTacaka)
            {
                tacka.Ispis();
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
        }
    }
}
