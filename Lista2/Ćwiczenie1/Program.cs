namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = -1;

            while (menu != 0)
            {
                if (menu == 1)
                {
                    try
                    {
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        Obliczenia.l1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę:");
                        Obliczenia.l2 = Double.Parse(Console.ReadLine());
                        Obliczenia.Dodawanie();
                        menu = -1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby!");
                        menu = 1;
                    }

                }
                
                else if (menu == 2)
                {
                    try
                    {
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        Obliczenia.l1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę:");
                        Obliczenia.l2 = Double.Parse(Console.ReadLine());
                        Obliczenia.Odejmowanie();
                        menu = -1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby!");
                        menu = 2;
                    }
                }
                
                else if (menu == 3)
                {
                    try
                    {
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        Obliczenia.l1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę:");
                        Obliczenia.l2 = Double.Parse(Console.ReadLine());
                        Obliczenia.Mnozenie();
                        menu = -1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby!");
                        menu = 3;
                    }
                }
                
                else if (menu == 4)
                {
                    try
                    {
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        Obliczenia.l1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę:");
                        Obliczenia.l2 = Double.Parse(Console.ReadLine());
                        Obliczenia.Dzielenie();
                        menu = -1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby!");
                        menu = 4;
                    }
                }
                
                else if (menu == 5)
                {
                    try
                    {
                        Console.WriteLine("Podaj liczbę:");
                        Obliczenia.l1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj wykładnik:");
                        Obliczenia.l2 = Double.Parse(Console.ReadLine());
                        Obliczenia.Potegowanie();
                        menu = -1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby!");
                        menu = 5;
                    }
                }
                
                else if (menu == 6)
                {
                    try
                    {
                        Console.WriteLine("Podaj liczbę:");
                        Obliczenia.l1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj stopień pierwiastka:");
                        Obliczenia.l2 = Double.Parse(Console.ReadLine());
                        Obliczenia.Pierwiastkowanie();
                        menu = -1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby!");
                        menu = 6;
                    }
                }

                else
                {
                    Console.WriteLine("Wybierz działanie:");
                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Mnożenie");
                    Console.WriteLine("4. Dzielenie");
                    Console.WriteLine("5. Potęgowanie");
                    Console.WriteLine("6. Pierwiastkowanie");
                    Console.WriteLine("0. Wyjdź");
                    try
                    {
                        menu = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Podaj cyfrę żeby wybrać działanie");
                    }
                }
            }
        }
    }
}
