namespace Wejsciowka_13_01_2024;

class Program
{
    public class Pracownik
    {
        public string imie;
        public string nazwisko;
        public Kontrakt kontrakt;

        public Pracownik(string i, string nazw)
        {
            this.imie = i;
            this.nazwisko = nazw;
            this.kontrakt = new Kontrakt((Kontrakt.TypKontraktu)1, 2000);
        }

        public void StazNaEtat()
        {
            kontrakt.typKontraktu = Kontrakt.TypKontraktu.etat;
        }

        public void EtatNaStaz()
        {
            kontrakt.typKontraktu = Kontrakt.TypKontraktu.etat;
        }

        public void ZmianaPodstawy(double kwota)
        {
            kontrakt.podstawaWynagrodzenia = kwota;
        }

        public double WysokoscPensji()
        {
            return kontrakt.Pensja();
        }

        public string ToString()
        {
            return $"{imie} {nazwisko} - podstawa wynagrodzenia: {kontrakt.podstawaWynagrodzenia}";
        }
    }
    
    public class Kontrakt
    {
        public enum TypKontraktu
        {
            staz,
            etat
        }

        public TypKontraktu typKontraktu;

        public double podstawaWynagrodzenia;

        public Kontrakt(TypKontraktu typKontraktu, double podstawaWynagrodzenia)
        {
            this.typKontraktu = typKontraktu;
            if (typKontraktu == TypKontraktu.staz)
            {
                this.podstawaWynagrodzenia = 2000;
            }
            else
            {
                this.podstawaWynagrodzenia = podstawaWynagrodzenia;
            }
        }


        public Kontrakt()
        {
        }

        public double Pensja()
        {
            int iloscNadgodzin = 0;
            if (typKontraktu == TypKontraktu.staz)
            {
                return 2000;
            }
            else
            {
                return podstawaWynagrodzenia + (iloscNadgodzin * (podstawaWynagrodzenia / 160));
            }
        }

        public double Pensja(int iloscNadgodzin)
        {
            if (typKontraktu == TypKontraktu.staz)
            {
                return 2000;
            }
            else
            {
                return podstawaWynagrodzenia + (iloscNadgodzin * (podstawaWynagrodzenia / 160));
            }
        }
    }
    static void Main(string[] args)
    {
        Pracownik pracownik1 = new Pracownik("Jacek", "Kowalski");
        pracownik1.StazNaEtat();
        pracownik1.ZmianaPodstawy(3500);
        Pracownik pracownik2 = new Pracownik("Zenon", "Kiełbasa");
        pracownik2.StazNaEtat();
        pracownik2.EtatNaStaz();
        Pracownik pracownik3 = new Pracownik("Grzegorz", "Klawaityr");
        pracownik3.ZmianaPodstawy(5000);
        Pracownik pracownik4 = new Pracownik("Eustachy", "Gbur");
        Pracownik pracownik5 = new Pracownik("Rysiek", "Deska");
        Pracownik pracownik6 = new Pracownik("Krzysiek", "Krwawiec");
        Pracownik pracownik7 = new Pracownik("Franek", "Tymoszenko");
        Pracownik pracownik8 = new Pracownik("Henryk", "Voidowski");
        Console.WriteLine(pracownik5.WysokoscPensji());
        Console.WriteLine(pracownik1.WysokoscPensji());
        Console.WriteLine(pracownik1.ToString());
        
    }
}