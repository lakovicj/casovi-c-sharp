using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum VrstaUdaljenosti
    {
        DIJAGONALNO,
        MENHETN
    }


    class Tacka
    {
        // fields
        private double x;
        private double y;

        // props
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Tacka()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Tacka(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Ispis()
        {
            Console.WriteLine("Tacka(x=" +  X + ", y=" + Y + ")");
        }

        private double UdaljenostMenhetn(Tacka drugaTacka)
        {
            double udaljenost = Math.Abs(this.X - drugaTacka.X) + Math.Abs(this.Y - drugaTacka.Y);
            return udaljenost;
        }

        private double UdaljenostDijagonalno(Tacka drugaTacka)
        {
            double xDeo = (this.X - drugaTacka.X);
            double yDeo = (this.Y - drugaTacka.Y);

            double xDeoKvadriran = xDeo * xDeo;
            double yDeoKvadriran = yDeo * yDeo;

            double udaljenost = Math.Sqrt(xDeoKvadriran + yDeoKvadriran);

            //double udalj = Math.Sqrt(Math.Pow((this.X - drugaTacka.X), 2) + Math.Pow((this.Y - drugaTacka.Y), 2);
            return udaljenost;
        }

        public double Udaljenost(Tacka t, VrstaUdaljenosti vrstaUdaljenosti)
        {
            double udaljenost = 0;

            if (vrstaUdaljenosti == VrstaUdaljenosti.MENHETN)
            {
                udaljenost = UdaljenostMenhetn(t);
            } else if (vrstaUdaljenosti == VrstaUdaljenosti.DIJAGONALNO)
            {
                udaljenost = UdaljenostDijagonalno(t);
            }

            return udaljenost;
        }

        public double UdaljenostOdCentra(VrstaUdaljenosti vrstaUdaljenosti)
        {
            Tacka centar = new Tacka(0, 0);
            double udaljenost = 0;

            if (vrstaUdaljenosti == VrstaUdaljenosti.MENHETN)
            {
                udaljenost = UdaljenostMenhetn(centar);
            } else if (vrstaUdaljenosti == VrstaUdaljenosti.DIJAGONALNO)
            {
                udaljenost = UdaljenostDijagonalno(centar);
            }

            return udaljenost;
        }
    }
}
