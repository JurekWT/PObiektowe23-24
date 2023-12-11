// See https://aka.ms/new-console-template for more information

using Lista1_3;

internal class Program
{
    public static void Main(string[] args)
    {
        Produkt prod1 = new Produkt("Kapustka", 12.00);
        Produkt prod2 = new Produkt("Monsterek", 5.99);
        Produkt prod3 = new Produkt("Ziemniak", 1.65);
        Koszyk koszykZakupow = new Koszyk();
        koszykZakupow.DodajDoKoszyka(prod1);
        koszykZakupow.DodajDoKoszyka(prod2);
        koszykZakupow.DodajDoKoszyka(prod2);
        koszykZakupow.DodajDoKoszyka(prod3);
        koszykZakupow.WyswietlZawartosc();
    }
}