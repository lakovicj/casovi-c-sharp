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
        private int x;
        private int y;

        // props
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
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

        private int UdaljenostMenhetn(Tacka t)
        {
            return 0;
        }

        private int UdaljenostDijagonalno(Tacka t)
        {
            return 0;
        }

        public double Udaljenost(Tacka t, VrstaUdaljenosti vrstaUdaljenosti)
        {
            return 0;
        }

        public double UdaljenostOdCentra(VrstaUdaljenosti vrstaUdaljenosti)
        {
            return 0;
        }
    }
}
