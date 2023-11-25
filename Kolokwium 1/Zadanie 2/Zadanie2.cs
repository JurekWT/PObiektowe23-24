// See https://aka.ms/new-console-template for more information

internal class Zadanie2
{
    public static void Main(string[] args)
    {
        int n;
        
        do
        {
            Console.Write("Podaj wymiar tablicy (n <= 10): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n > 10);
        
        int[,] tablica = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Podaj element [{0},{1}]: ", i, j);
                tablica[i, j] = int.Parse(Console.ReadLine());
            }
    }
        
        int sumaNieparzystych = SumaNieparzystych(tablica);
        
        Console.WriteLine("Suma nieparzystych elementów tablicy wynosi: {0}", sumaNieparzystych);
    }

    static int SumaNieparzystych(int[,] tablica)
    {
        int suma = 0;

        foreach (var element in tablica)
        {
            if (element % 2 != 0)
            {
                suma += element;
            }
        }

        return suma;
    }
}