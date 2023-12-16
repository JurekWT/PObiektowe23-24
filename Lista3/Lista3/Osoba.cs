using System;

namespace Lista3
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        internal string miejsceZamieszkania;

        public Osoba(string imie, string nazwisko, int rokUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"{imie} {nazwisko}, rok urodzenia: {rokUrodzenia}");
        }

        public void ObliczWiek()
        {
            Console.WriteLine($"Wiek: {DateTime.Now.Year - rokUrodzenia}");
        }
    }
}