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

        public void Przesun(int osX, int osY)
        {
            WspA += osX;
            WspB += osY;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Aktualne współrzędne punktu {NazwaPunktu} to ({WspA},{WspB})");
        }

    }
    
    public class Odcinek
    {
        public Punkt A { get; set; }
        public Punkt B { get; set; }

        public Odcinek(Punkt a, Punkt b)
        {
            this.A = a;
            this.B = b;
        }

        public void Dlugosc()
        {
            
        }
        
    }
    public static void Main(string[] args)
    {
        Punkt a = new Punkt("A",4, 6);
        a.Przesun(2,0);
        a.Wyswietl();
    }
}