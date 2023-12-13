using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_8
{
    internal class Prostopadloscian
    {
        public double dlugosc;
        public double szerokosc;
        public double wysokosc;

        public Prostopadloscian(double d, double s, double w)
        {
            this.dlugosc = d;
            this.szerokosc = s;
            this.wysokosc = w;
        }

        public double Objetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }

        public static Prostopadloscian PorownajObjetosc(Prostopadloscian a, Prostopadloscian b)
        {
            if (a.Objetosc() > b.Objetosc())
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
