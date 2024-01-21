namespace Figury;

class Program
{
    static void Main(string[] args)
    {
        Figura kwadrat = new Kwadrat(4);
        Figura trojkat = new Trojkat(10,4);

        List<Figura> figury = new List<Figura>();
        figury.Add(kwadrat);
        figury.Add(trojkat);
        foreach (Figura figura in figury)
        {
            figura.ObliczPole();
        }
    }
}