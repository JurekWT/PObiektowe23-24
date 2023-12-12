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

        public static double Dodawanie()
        {
            return l1 + l2;
        }

        public static double Odejmowanie()
        {
            return l1 - l2;
        }

        public static double Mnozenie()
        {
            return l1 * l2;
        }

        public static double Dzielenie()
        {
            return l1 / l2;
        }

        public static double Potegowanie()
        {
            return Math.Pow(l1, l2);
        }

        public static double Pierwiastkowanie()
        {
            return Math.Pow(l1, 1 / l2);
        }
    }
}
