// See https://aka.ms/new-console-template for more information

internal class Program
{
    static int fib(int n)
    {
        int a = 1, b = 1, temp;
        if (n>1)
        {
            for (int i = 1; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + a;
            }

            return b;
        }
        else
        {
            return b;
        }
        
    }

    static int fibr(int n)
    {
        if (n<2)
        {
            return 1;
        }
        else
        {
            int a = fibr(n - 1) + fibr(n - 2);
            return a;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Znajdź n-ty element ciągu Fibonacciego. Podaj n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(fib(n));
        Console.WriteLine(fibr(n));
    }
}