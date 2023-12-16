namespace Wejsciowka_16_12_2023;

class Program
{
    public class Punkt
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punkt(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Przesun(double x, double y)
        {
            X += x;
            Y += y;
        }

        public void Wypisz()
        {
            Console.WriteLine($"Współrzędne punktu to ({X},{Y})");
        }
    }
    static void Main(string[] args)
    {
        Punkt point1 = new Punkt(20, 30);
        point1.Przesun(2,0);
        point1.Wypisz();
    }
}