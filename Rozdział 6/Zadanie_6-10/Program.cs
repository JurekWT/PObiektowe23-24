// See https://aka.ms/new-console-template for more information

using Zadanie_6_10;

internal class Program
{
    public static void Main(string[] args)
    {
        KandydatNaStudia[] listaKandydatow = new KandydatNaStudia[5];
        listaKandydatow[0] = new KandydatNaStudia("Kowalski", 85, 90, 95);
        listaKandydatow[1] = new KandydatNaStudia("Głąbowski", 66, 76, 85);
        listaKandydatow[2] = new KandydatNaStudia("Jankowski", 78, 87, 56);
        listaKandydatow[3] = new KandydatNaStudia("Misiewicz", 45, 60, 40);
        listaKandydatow[4] = new KandydatNaStudia("Tutorialski", 77, 88, 22);

        foreach (var kandydat in listaKandydatow)
        {
            Console.WriteLine("Kandydat " + kandydat.nazwisko + " - " + kandydat.LacznePunkty() + " punktów razem");
        }
    }
}