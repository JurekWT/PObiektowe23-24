using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    static class Obliczenia
    {
        public static double l1;
        public static double l2;

        public static void Dodawanie()
        {
            Console.WriteLine(l1 + l2);
        }

        public static void Odejmowanie()
        {
            Console.WriteLine(l1 - l2);
        }

        public static void Mnozenie()
        {
            Console.WriteLine(l1 * l2);
        }

        public static void Dzielenie()
        {
            try
            {
                var temp = l1 / l2;
                Console.WriteLine(temp);
            }
            catch (Exception)
            {
                Console.WriteLine("Nie można dzielić przez zero");
            }
        }

        public static void Potegowanie()
        {
            Console.WriteLine(Math.Pow(l1, l2));
        }

        public static void Pierwiastkowanie()
        {
            Console.WriteLine(Math.Pow(l1, 1 / l2));
        }
    }
}
