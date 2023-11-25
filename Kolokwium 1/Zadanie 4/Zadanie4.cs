// See https://aka.ms/new-console-template for more information

internal class Zadanie4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę n (1<=n<=150)");
        int n = int.Parse(Console.ReadLine());
        while (n<1 || n>150)
        {
            Console.WriteLine("Podano liczbę poza zakresem. Wprowadź liczbę jeszcze raz");
            n = int.Parse(Console.ReadLine());
        }

        Random random = new Random();
        int[] tab1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            tab1[i] = random.Next(-1109, 1109);
        }

        int max = tab1[0];
        int maxcount = 0;
        foreach (int c in tab1)
        {
            if (max < c)
            {
                max = c;
            }
        }

        foreach (int c in tab1)
        {
            if (max == c)
            {
                maxcount++;
            }
        }
        
        Console.WriteLine("Największa {0}, wystąpiła {1} razy", max, maxcount);
    }
}