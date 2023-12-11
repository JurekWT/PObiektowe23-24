namespace Lista1_3;

public class Koszyk
{
    public Produkt[] ListaTowarow;
    private int count = 0;

    public Koszyk()
    {
        ListaTowarow = new Produkt[99];
    }

    public void DodajDoKoszyka(Produkt towar)
    {
        if (count == 99)
        {
            Console.WriteLine("Brak miejsca na liście");
        }
        else
        {
            ListaTowarow[count] = towar;
            count++;
        }

    }

    public void WyswietlZawartosc()
    {
        double suma = 0.00;
        for (int i = 0; i < count; i++)
        {
            suma += ListaTowarow[i].Cena;
        }
        Console.WriteLine($"Ilość towarów w koszyku: {count}");
        Console.WriteLine($"Razem: {suma:F2} zł");
    }
}