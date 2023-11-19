// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Suma(int x, int n)
    {
        int temp = 0;
        for (int i = 1; i <= n; i++)
        {
            temp += (x + i);
        }
        Console.WriteLine(temp);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(":Podaj n:");
        int n = int.Parse(Console.ReadLine());
        Suma(x,n);
    }
}