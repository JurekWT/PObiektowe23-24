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
        for (int i = 0; i < listaTowarow.Count; i++)
        {
            suma += listaTowarow[i].Cena;
        }
        Console.WriteLine($"Ilość towarów w koszyku: {listaTowarow.Count}");
        Console.WriteLine($"Razem: {suma:F2} zł");
    }
}