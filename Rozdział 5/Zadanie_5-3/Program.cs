// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Przesun(ref double a, ref double b, double w1, double w2)
    {
        a += w1;
        b += w2;
    }
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Podaj współrzędne punktu A");
        double a, b;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        double[] wek = new double[2];
        wek[0] = 3;
        wek[1] = 2;
        Console.WriteLine("Punkt A=({0},{1})", a, b);
        Przesun(ref a, ref b, wek[0], wek[1]);
        Console.WriteLine("Po przesunięciu A=({0},{1})", a, b);
    }
}