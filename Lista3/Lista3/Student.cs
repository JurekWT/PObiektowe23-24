using System;

namespace Lista3
{
    public class Student : Osoba
    {
        public int rok;
        public int numerGrupy;
        public int numerAlbumu;

        public Student(string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rokUrodzenia)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"{imie} {nazwisko}, rok urodzenia: {rokUrodzenia} \n" +
                              $"Student {rok} roku, grupa nr {numerGrupy}, numer albumu: {numerAlbumu}");
        }
    }
}