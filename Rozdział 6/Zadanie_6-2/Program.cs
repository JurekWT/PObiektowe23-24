// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class Prostokat
    {
        private int dlugosc;
        private int szerokosc;

        public Prostokat(int length, int width)
        {
            dlugosc = length;
            szerokosc = width;
        }

        private int powierzchnia(int a, int b)
        {
            return a * b;
        }

        private int obwod(int a, int b)
        {
            return 2 * a + 2 * b;
        }

        public void Prezentuj()
        {
            Console.WriteLine("Prostokąt o wymiarach {2}x{3}\n" +
                              "Powierzchnia: {0}, obwód: {1}", powierzchnia(dlugosc, szerokosc),
                obwod(dlugosc, szerokosc), dlugosc, szerokosc);
        }
    }
    public static void Main(string[] args)
    {
        Prostokat[] tabela = new Prostokat[3];
        tabela[0] = new Prostokat(2, 5);
        tabela[1] = new Prostokat(5, 8);
        tabela[2] = new Prostokat(6, 4);
        
        foreach (Prostokat p in tabela)
        {
            p.Prezentuj();
        }
    }
}