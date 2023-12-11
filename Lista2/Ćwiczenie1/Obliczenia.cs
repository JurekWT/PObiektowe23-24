using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    internal class Obliczenia
    {
        private double l1;
        private double l2;

        public static double Dodawanie(double l1, double l2)
        {
            return l1 + l2;
        }

        public static double Odejmowanie(double l1, double l2)
        {
            return l1 - l2;
        }

        public static double Mnozenie(double l1, double l2)
        {
            return l1 * l2;
        }

        public static double Dzielenie(double l1, double l2)
        {
            return l1 / l2;
        }

        public static double Potegowanie(double l1, double l2)
        {
            return Math.Pow(l1, l2);
        }

        public static double Pierwiastkowanie(double l1, double l2)
        {
            return Math.Pow(l1, 1 / l2);
        }
    }
}
