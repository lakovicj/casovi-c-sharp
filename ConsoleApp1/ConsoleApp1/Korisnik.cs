using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum TipKorisnika
    {
        Administrator,
        Student
    }

    class Korisnik
    {
        public string ime;
        public string prezime;
        public TipKorisnika tipKorisnika;
        public int godine;

        public Korisnik(string ime, string prezime, TipKorisnika tipKorisnika, int godine)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.tipKorisnika = tipKorisnika;
            this.godine = godine;
        }

        public override string ToString()
        {
            return "Ovo je " + this.tipKorisnika + " " + this.ime + " " + this.prezime + 
                " koji ima " + godine + " godina";
        }


    }
}
