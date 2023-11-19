// See https://aka.ms/new-console-template for more information

internal class Program
{
    static int Oblicz(int n)
    {
        if (n <= 1) return (1);
        else return (n + Oblicz(n - 1));
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Oblicz(n));
    }
}