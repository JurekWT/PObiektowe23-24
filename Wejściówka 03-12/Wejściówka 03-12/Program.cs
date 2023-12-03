// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class Miasto
    {
        public string nazwaMiasta;
        public int liczbaLudnosci;

        public Miasto(string nazwa, int ludnosc)
        {
            nazwaMiasta = nazwa;
            liczbaLudnosci = ludnosc;
        }

        public void PodajCeneZaMetr()
        {
            if (liczbaLudnosci<30000)
            {
                Console.WriteLine("Cena za metr wynosi 5.000zł");
            }
            else if (liczbaLudnosci>=30000 && liczbaLudnosci<100000)
            {
                Console.WriteLine("Cena za metr wynosi 7.000zł");
            }
            else
            {
                Console.WriteLine("Cena za metr wynosi 10.000zł");
            }
        }
        
    }
    public static void Main(string[] args)
    {
        Miasto m1 = new Miasto("Olsztyn", 150000);
        Console.WriteLine(m1.nazwaMiasta);
        m1.PodajCeneZaMetr();
    }
}