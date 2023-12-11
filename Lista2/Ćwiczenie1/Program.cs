namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = -1;
            double a, b;
            while (input != 0)
            {
                Console.WriteLine("Wybierz działanie:");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Potęgowanie");
                Console.WriteLine("6. Pierwiastkowanie");
                Console.WriteLine("0. Wyjdź");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Podaj pierwszą liczbę");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: " + Obliczenia.Dodawanie(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Podaj pierwszą liczbę");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: " + Obliczenia.Odejmowanie(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Podaj pierwszą liczbę");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: " + Obliczenia.Mnozenie(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Podaj pierwszą liczbę");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę");
                        b = double.Parse(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Wynik: " + Obliczenia.Dzielenie(a, b));
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Nie można dzielić przez zero. Wprowadź liczby jeszcze raz.");
                            goto case 4;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Podaj liczbę");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj wykładnik");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: " + Obliczenia.Potegowanie(a, b));
                        break;
                    case 6:
                        Console.WriteLine("Podaj liczbę");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj stopień pierwiastka");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: " + Obliczenia.Pierwiastkowanie(a, b));
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Błąd, wprowadź liczbę 1-6");
                        input = int.Parse(Console.ReadLine());
                        break;
                } 
            }
        }
    }
}
