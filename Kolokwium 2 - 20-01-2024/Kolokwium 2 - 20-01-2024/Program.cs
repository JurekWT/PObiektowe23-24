namespace Kolokwium_2___20_01_2024;

class Program
{
    public class Skladnik : IComparable<Skladnik>
    {
        private string _nazwaSkladnika;
        private string _ilosc;
        private double _cenaSkladnika;

        public Skladnik(string nazwaSkladnika, string ilosc, double cenaSkladnika)
        {
            _nazwaSkladnika = nazwaSkladnika;
            _ilosc = ilosc;
            _cenaSkladnika = cenaSkladnika;
        }

        public int CompareTo(Skladnik? drugiSkladnik)
        {
            if (drugiSkladnik == null)
            {
                return 1;
            }
            else
            {
                return _nazwaSkladnika.CompareTo(drugiSkladnik._nazwaSkladnika);
            }
        }

        public override string ToString()
        {
            string s = $"Nazwa: {_nazwaSkladnika}, ilość: {_ilosc}, cena: {_cenaSkladnika}";
            return s;
        }

        public double PodajCeneSkladnika()
        {
            return _cenaSkladnika;
        }
    }

    public class Przepis
    {
        private string _nazwa;
        private double _suma = 0;
        private List<Skladnik> _skladniki = new List<Skladnik>();
        private int _czasPrzygotowania;

        public void DodajSkladnik(string nazwa, string ilosc, double cena)
        {
            Skladnik temp = new Skladnik(nazwa, ilosc, cena);
            _skladniki.Add(temp);
            _suma += cena;
        }

        public void UstawNazweICzas(string nazwa, int czas)
        {
            _nazwa = nazwa;
            _czasPrzygotowania = czas;
        }

        public override string ToString()
        {
            string temp = null;
            if (_skladniki == null)
            {
                return temp;
            }
            else
            {
                return base.ToString();
            }
        }

        public bool CzyCzas()
        {
            if (_czasPrzygotowania <= 0)
            {
                return false;
            }

            return true;
        }

        public int IleSkladnikow()
        {
            return _skladniki.Count;
        }
    }
    
    public abstract class Zamowienie
    {
        protected DateTime czasDostawy;

        public virtual bool PoprawnyCzas()
        {
            if (czasDostawy > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UstawCzasDostawy(DateTime czas)
        {
            czasDostawy = czas;
        }
    }
    
    public class NaMiejscu : Zamowienie
    {
        
    }
    
    public class NaWynos : Zamowienie
    {
        public override bool PoprawnyCzas()
        {
            if (czasDostawy.Hour > DateTime.Now.Hour + 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj nazwę przepisu");
        string nazwa = Console.ReadLine();
        if (nazwa == null)
        {
            Console.WriteLine("Nie podano nazwy. Wprowadź jeszcze raz.");
            nazwa = Console.ReadLine();
        }

        Console.WriteLine("Podaj czas przygotowania (w minuach).");
        int czas = int.Parse(Console.ReadLine());
        if (czas > 300)
        {
            Console.WriteLine("Czas przygotowania zbyt długi (maks. 300 minut). Podaj jeszcze raz.");
            czas = int.Parse(Console.ReadLine());
        }

        Przepis przepis = new Przepis();
        przepis.UstawNazweICzas(nazwa, czas);

        int wybor = 0;
        while (wybor != -1)
        {
            Console.WriteLine("Podaj nazwę składnika");
            string nazwaSkladnika = Console.ReadLine();
            if (nazwaSkladnika == null)
            {
                Console.WriteLine("Nie podano nazwy składnika. Podaj jeszcze raz.");
                nazwaSkladnika = Console.ReadLine();
            }
            Console.WriteLine("Podaj ilość.");
            string iloscSkladnika = Console.ReadLine();
            if (iloscSkladnika == null)
            {
                Console.WriteLine("Nie podano ilosci składnika. Podaj jeszcze raz.");
                iloscSkladnika = Console.ReadLine();
            }
            Console.WriteLine("Podaj cenę składnika.");
            double cenaSkladnika = double.Parse(Console.ReadLine());
            if (cenaSkladnika <= 0)
            {
                Console.WriteLine("Podano błędną cenę. Podaj jeszcze raz.");
                cenaSkladnika = double.Parse(Console.ReadLine());
            }
            przepis.DodajSkladnik(nazwaSkladnika, iloscSkladnika, cenaSkladnika);
            Console.WriteLine("Czy dodać kolejny składnik? TAK/NIE");
            string taknie = Console.ReadLine();
            if (taknie == "NIE")
            {
                wybor = -1;
            }
        }

        if (przepis.IleSkladnikow() >= 3)
        {
            Console.WriteLine("Zamówienie na wynos? TAK/NIE");
            string zamow = Console.ReadLine();
            if (zamow == "TAK")
            {
                Console.WriteLine("Podaj czas dostawy.");
                Zamowienie zamowienie = new NaWynos();
                DateTime czas1 = Convert.ToDateTime(Console.ReadLine());
                zamowienie.UstawCzasDostawy(czas1);
                if (zamowienie.PoprawnyCzas() == false)
                {
                    Console.WriteLine("Podano niepoprawny czas dostawy. Podaj jeszcze raz.");
                    czas1 = Convert.ToDateTime(Console.ReadLine());
                    zamowienie.UstawCzasDostawy(czas1);
                }

            }
        }
    }
    
}