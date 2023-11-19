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

    static void Mnozenieref(ref int[] tab, int mnoznik)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            tab[i] *= mnoznik;
        }
    }
    public static void Main(string[] args)
    {
        int[] tab = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (var x in tab)
        {
            Console.Write("{0} ",x);
        }

        int[] tab2 = Mnozenie(tab, 2);
        Console.WriteLine();
        foreach (var x in tab2)
        {
            Console.Write("{0} ",x);
        }
        
        Mnozenieref(ref tab, 3);
        Console.WriteLine();
        foreach (var x in tab)
        {
            Console.Write("{0} ",x);
        }
    }
}