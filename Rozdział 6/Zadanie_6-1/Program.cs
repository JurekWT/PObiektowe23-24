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

        private int powierzchnia()
        {
            return dlugosc*szerokosc;
        }

        private int obwod()
        {
            return 2*dlugosc+2*szerokosc;
        }

        public void Prezentuj()
        {
            Console.WriteLine($"Prostokąt o wymiarach {dlugosc}x{szerokosc} ma powierzchnię {powierzchnia()} i obwód {obwod()}");
        }
    }
    public static void Main(string[] args)
    {
        Prostokat p1 = new Prostokat(2, 5);
        p1.Prezentuj();
    }
}