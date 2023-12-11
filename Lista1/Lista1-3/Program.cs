// See https://aka.ms/new-console-template for more information

using Lista1_3;

internal class Program
{
    public static void Main(string[] args)
    {
        Produkt prod1 = new Produkt("Kapustka", 12.00);
        Produkt prod2 = new Produkt("Monsterek", 5.99);
        Koszyk koszyk1 = new Koszyk();
        koszyk1.DodajDoKoszyka(prod1);
        koszyk1.DodajDoKoszyka(prod2);
        koszyk1.WyswietlZawartosc();
    }
}