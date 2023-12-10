namespace Lista1_2;

public class Osoba
{
    public string imie;
    public string nazwisko;
    public int rokUrodzenia;
    public double waga;
    public double wzrost;
    public bool okulary;
    public enum Plec
    {
        K,
        M
    }

    public Plec plec;

    public void KtoDyrektorem()
    {
        if (plec == Plec.M)
        {
            Console.WriteLine($"Dyrektorem jest Pan {imie} {nazwisko}");
        }
        else
        {
            Console.WriteLine($"Dyrektorem jest Pani {imie} {nazwisko}");
        }
    }

    public int ObliczWiek()
    {
        return DateTime.Today.Year - rokUrodzenia;
    }
    

    public void ObliczBMI()
    {
        double bmi = waga / (Math.Pow(wzrost / 100,2));
        if (bmi < 17.00)
        {
            Console.WriteLine("Niedowaga");
        }
        else if (bmi >= 17.00 && bmi < 25.00)
        {
            Console.WriteLine("waga poprawna");
        }
        else if (bmi >= 25.00 && bmi <29.99)
        {
            Console.WriteLine("Nadwaga");
        }
        else
        {
            Console.WriteLine("Otyłość");
        }
    }

}