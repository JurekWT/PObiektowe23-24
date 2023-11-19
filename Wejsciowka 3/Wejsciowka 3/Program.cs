// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Wczytaj(ref int[,] tab)
    {
        for (int wiersz = 0; wiersz < tab.GetLength(0); wiersz++)
        {
            for (int kolumna = 0; kolumna < tab.GetLength(1); kolumna++)
            {
                tab[wiersz, kolumna] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int Znajdz(ref int[,] tab)
    {
        int min = tab[0, 0];
        for (int wiersz = 0; wiersz < tab.GetLength(0); wiersz++)
        {
            for (int kolumna = 0; kolumna < tab.GetLength(1); kolumna++)
            {
                if (min>tab[wiersz,kolumna])
                {
                    min = tab[wiersz, kolumna];
                }
            }
        }

        for (int wiersz = 0; wiersz < tab.GetLength(0); wiersz++)
        {
            for (int kolumna = 0; kolumna < tab.GetLength(1); kolumna++)
            {
                if (min == tab[wiersz,kolumna])
                {
                    Console.Write("MIN {0} znajduje się w {1} wierszu {2} kolumnie", min, wiersz, kolumna);
                }
            }
        }

        return min;
    }

    public static void Main(string[] args)
    {
        int[,] tablica = new int[4, 4];
        Wczytaj(ref tablica);
        int Min = Znajdz(ref tablica);
        Console.WriteLine(Min);
    }
}