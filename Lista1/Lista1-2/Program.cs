// See https://aka.ms/new-console-template for more information

using Lista1_2;

internal class Program
{
    public static void Main(string[] args)
    {
        Osoba Dyrektor = new Osoba();
        Dyrektor.imie = "Jan";
        Dyrektor.nazwisko = "Kowalski";
        Dyrektor.rokUrodzenia = 1967;
        Dyrektor.waga = 72.00;
        Dyrektor.wzrost = 176.00;
        Dyrektor.okulary = true;
        Dyrektor.plec = Osoba.Plec.M;
        Console.WriteLine($"Dyrektor {Dyrektor.imie} {Dyrektor.nazwisko}, wiek {Dyrektor.ObliczWiek()} lat");
        Osoba pacjent = new Osoba();
        pacjent.waga = 120.40;
        pacjent.wzrost = 188.00;
        pacjent.ObliczBMI();
        Dyrektor.KtoDyrektorem();
    }
}