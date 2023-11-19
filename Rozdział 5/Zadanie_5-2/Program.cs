// See https://aka.ms/new-console-template for more information

internal class Program
{
    static bool Zakres(int a, int b, int x)
    {
        if ((x>a && x<b) || (x<a && x>b))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj zakres (a,b) oraz x:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        if (Zakres(a,b,x))
        {
            Console.WriteLine("x={2} należy do ({0},{1})",a,b,x);
        }
        else
        {
            Console.WriteLine("x={2} nie należy do ({0},{1})",a,b,x);
        }
    }
}