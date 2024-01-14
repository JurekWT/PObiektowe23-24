namespace Wyjątki;

class Program
{
    static void Main(string[] args)
    {
        static void metoda23()
        {
            throw new NotImplementedException();
        }
        try
        {
            int liczba1 = 1;
            int liczba2 = 0;
            //int liczba3 = liczba1 / liczba2;
            metoda23();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}