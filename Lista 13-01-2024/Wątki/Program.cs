namespace Wątki;

class Program
{
    static void Licz()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"watek:{i}");
        }
    }
    static void Main(string[] args)
    {
        Thread thr = new Thread(Licz);
        thr.Start();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"program1:{i}");
        }
    }
}