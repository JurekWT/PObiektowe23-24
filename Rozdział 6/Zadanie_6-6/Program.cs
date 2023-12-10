// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class Punkt
    {
        public int WspA { get; set; }
        public int WspB { get; set; }
        public string NazwaPunktu { get; set; }

        public Punkt(string nazwa, int osX, int osY)
        {
            this.WspA = osX;
            this.WspB = osY;
            this.NazwaPunktu = nazwa;
        }
    }

    static void WspolnaProsta(Punkt[] tab)
    {
        
    }

    public static void Main(string[] args)
    {
        Punkt[] punkty = { new Punkt("A", 4, 7), new Punkt("B", 8, 4), new Punkt("C", 2, 2) };
        
    }
}