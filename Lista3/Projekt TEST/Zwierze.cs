using System.Runtime.InteropServices;

namespace Projekt_TEST;

public class Zwierze : IOpisZwierzat
{
    public void JakSiePoruszam()
    {
        var ktoWywoluje = this.GetType();
        if (ktoWywoluje == typeof(Pies))
        {
            Console.WriteLine("Poruszam się na czterech łapach");
        }
        if (ktoWywoluje == typeof(Wilk))
        {
            Console.WriteLine("Poruszam się na czterech łapach");
        }
        if (ktoWywoluje == typeof(Rekin))
        {
            Console.WriteLine("Pływam w wodzie");
        }
        if (ktoWywoluje == typeof(Orzel))
        {
            Console.WriteLine("Latam na skrzydłach");
        }
        if (ktoWywoluje == typeof(Krokodyl))
        {
            Console.WriteLine("Poruszam się na czterech łapach");
        }
    }

    public void CoJem()
    {
        var ktoWywoluje = this.GetType();
        if (ktoWywoluje == typeof(Pies))
        {
            Console.WriteLine("Jestem wszystkożerny");
        }
        if (ktoWywoluje == typeof(Wilk))
        {
            Console.WriteLine("Poluję na zwierzynę");
        }
        if (ktoWywoluje == typeof(Rekin))
        {
            Console.WriteLine("Zjadam inne ryby");
        }
        if (ktoWywoluje == typeof(Orzel))
        {
            Console.WriteLine("Poluję na ptaki i gryzonie");
        }
        if (ktoWywoluje == typeof(Krokodyl))
        {
            Console.WriteLine("Poluję na zwierzęta");
        }
    }

    public object Copy()
    {
        return MemberwiseClone();
    }
}


public class Pies : Zwierze
{
    public string imie;
    public double waga;
    public double rozmiar;
}

public class Wilk : Zwierze
{
    public string imie;
    public double waga;
    public double rozmiar;
}

public class Rekin : Zwierze
{
    public string imie;
    public double waga;
    public double rozmiar;
}

public class Orzel : Zwierze
{
    public string imie;
    public double waga;
    public double rozmiar;
}

public class Krokodyl : Zwierze
{
    public string imie;
    public double waga;
    public double rozmiar;
}

public interface IOpisZwierzat
{
    void JakSiePoruszam();
    void CoJem();
}