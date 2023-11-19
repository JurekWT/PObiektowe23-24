// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Rysuj(int len, int wid, char item)
    {
        for (int wiersz = 0; wiersz < wid; wiersz++)
        {
            for (int kolumna = 0; kolumna < len; kolumna++)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj długość: ");
        int lenght = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj szerokość: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj znak: ");
        char item;
        item = char.Parse(Console.ReadLine());
        Rysuj(lenght, width, item);
        Console.WriteLine();
        Rysuj(width, lenght, item);
    }
}