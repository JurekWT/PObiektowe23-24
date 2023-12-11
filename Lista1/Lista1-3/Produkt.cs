namespace Lista1_3;

public class Produkt
{
    public string Nazwa { get; }
    public double Cena { get; }

    public Produkt(string nazwa, double cena)
    {
        this.Nazwa = nazwa;
        this.Cena = cena;
    }

    public void WypiszProdukt()
    {
        Console.WriteLine($"Towar: {Nazwa}, cena: {Cena} zł");
    }
}