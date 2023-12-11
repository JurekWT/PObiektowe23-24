namespace Lista1_3;

public class Koszyk
{
    public Koszyk()
    {
        this.listaTowarow = new List<Produkt>();
    }
    
    public List<Produkt> listaTowarow;
    
    public void DodajDoKoszyka(Produkt towar)
    {
        listaTowarow.Add(towar);
    }

    public void WyswietlZawartosc()
    {
        double suma = 0.00;
        foreach (Produkt produkt in listaTowarow)
        {
            suma += produkt.Cena;
        }

        Console.WriteLine($"Ilość towarów w koszyku: {listaTowarow.Count}");
        Console.WriteLine($"Razem: {suma:F2} zł");
    }
}