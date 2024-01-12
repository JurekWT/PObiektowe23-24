namespace Projekt_TEST;

public class Punkt : IOperacjeNaFigurach
{
    public string nazwa;
    public double X;
    public double Y;
    
    public double LiczObwod()
    {
        return 0;
    }

    public void PobierzDaneZKlawiatury()
    {
        Console.WriteLine("Podaj nazwę punktu");
        nazwa = Console.ReadLine();
        Console.WriteLine("Podaj wspólrzędne punktu");
        X = double.Parse(Console.ReadLine());
        Y = double.Parse(Console.ReadLine());
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Punkt {nazwa} o współrzędnych {X},{Y}");
    }

    string ToString()
    {
        string temp = $"Punkt {nazwa} o współrzędnych {X},{Y}";
        return temp;
    }
    
    
}

public class Kolo : IOperacjeNaFigurach
{
    public string nazwa;
    public Punkt srodekKola;
    public double promien;

    public Kolo()
    {
        this.srodekKola = new Punkt();
    }
    public double LiczObwod()
    {
        return 2 * Math.PI * promien;
    }

    public void PobierzDaneZKlawiatury()
    {
        Console.WriteLine("Podaj nazwę koła");
        nazwa = Console.ReadLine();
        Console.WriteLine("Podaj wspólrzędne środka koła");
        srodekKola.X = double.Parse(Console.ReadLine());
        srodekKola.Y = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj promień");
        promien = double.Parse(Console.ReadLine());
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Kolo {nazwa} o środku ({srodekKola.X},{srodekKola.Y}) i promieniu {promien}");
    }

    public string ToString()
    {
        string temp = $"Kolo {nazwa} o środku ({srodekKola.X},{srodekKola.Y}) i promieniu {promien}";
        return temp;
    }
}

public class Kwadrat : IOperacjeNaFigurach
{
    public string nazwa;
    public Punkt A;
    public Punkt B;
    public Punkt C;
    public Punkt D;
    public double LiczObwod()
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)) * 4;
    }

    public void PobierzDaneZKlawiatury()
    {
        Console.WriteLine("Podaj nazwę");
        nazwa = Console.ReadLine();
        Console.WriteLine("Podaj współrzędne pierwszego wierzchołka");
        A.X = double.Parse(Console.ReadLine());
        A.Y = double.Parse(Console.ReadLine());
        Console.WriteLine("Drugiego");
        B.X = double.Parse(Console.ReadLine());
        B.Y = double.Parse(Console.ReadLine());
        Console.WriteLine("Trzeciego");
        C.X = double.Parse(Console.ReadLine());
        C.Y = double.Parse(Console.ReadLine());
        Console.WriteLine("Czwartego");
        D.X = double.Parse(Console.ReadLine());
        D.Y = double.Parse(Console.ReadLine());
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Kwadrat {nazwa} o wierzchołkach A({A.X},{A.Y}), B({B.X},{B.Y}), C({C.X},{C.Y}), D({D.X},{D.Y})");
    }

    string ToString()
    {
        string temp;
        temp = $"Kwadrat {nazwa} o wierzchołkach A({A.X},{A.Y}), B({B.X},{B.Y}), C({C.X},{C.Y}), D({D.X},{D.Y})";
        return temp;
    }
    
}

public interface IOperacjeNaFigurach
{
    double LiczObwod();
    void PobierzDaneZKlawiatury();
    void Wyswietl();
}