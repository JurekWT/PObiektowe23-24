// See https://aka.ms/new-console-template for more information

internal class Program
{
    static int[] Mnozenie(int[] tab1, int mnoznik)
    {
        int[] tab2 = new int[tab1.GetLength(0)];
        for (int i = 0; i < tab1.GetLength(0); i++)
        {
            tab2[i] = tab1[i] * mnoznik;
        }

        return tab2;
    }
    
    static string[] Mnozenie(string[] tab1, int mnoznik)
    {
        string[] tab2 = new string[tab1.GetLength(0)];
        for (int i = 0; i < tab1.GetLength(0); i++)
        {
            for (int j = 0; j < mnoznik; j++)
            {
                tab2[i] += tab1[i];
            }
        }

        return tab2;
    }
    
    public static void Main(string[] args)
    {
        int[] cyferki = new int[] { 1, 2, 3, 4, 5 };
        string[] slowa = new string[] { "ala", "ma", "kota" };
        int[] cyferki2 = Mnozenie(cyferki, 2);
        string[] slowa2 = Mnozenie(slowa, 2);
        foreach (var x in cyferki2)
        {
            Console.Write(x);
        }
        Console.WriteLine();
        foreach (var x in slowa2)
        {
            Console.Write(x);
        }
    }
}