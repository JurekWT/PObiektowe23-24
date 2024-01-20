namespace listy;

public class Osoba
{
    private int _wiek;
    private string _imie;

    public Osoba(int wiek, string imie)
    {
        _wiek = wiek;
        _imie = imie;
    }

    public Osoba()
    {
        _wiek = 0;
        _imie = "Brak imienia";
    }

    public int PodajWiek()
    {
        return _wiek;
    }

    public void UstawWiek(int w)
    {
        _wiek = w;
    }

    public string PodajImie()
    {
        return _imie;
    }

    public void UstawImie(string imie)
    {
        _imie = imie;
    }
}