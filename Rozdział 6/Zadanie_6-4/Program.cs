// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class Energia
    {
        public int PoczatkowyStan { private set; get; }
        public int BiezacyStan { set; get; }

        public Energia(int pocz, int biez)
        {
            PoczatkowyStan = pocz;
            BiezacyStan = biez;
        }

        public void PokazStanLicznika()
        {
            Console.WriteLine($"Stan początkowy licznika: {PoczatkowyStan} kWh, bieżący stan licznika: {BiezacyStan}kWh");
        }

        public void PokazZuzycieEnergii()
        {
            Console.WriteLine($"Zużycie energii to {BiezacyStan-PoczatkowyStan} kWh");
        }
    }
    public static void Main(string[] args)
    {
        Energia abc = new Energia(200, 4000);
        abc.PokazStanLicznika();
        abc.PokazZuzycieEnergii();
    }
}