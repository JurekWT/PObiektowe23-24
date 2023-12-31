﻿// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class Prostokat
    {
        private readonly int dlugosc;
        private readonly int szerokosc;

        public Prostokat(int length, int width)
        {
            dlugosc = length;
            szerokosc = width;
        }

        private int powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private int obwod()
        {
            return 2 * dlugosc + 2 * szerokosc;
        }

        public void Prezentuj()
        {
            Console.WriteLine(
                $"Prostokąt o wymiarach {dlugosc}x{szerokosc} ma powierzchnię {powierzchnia()} i obwód {obwod()}");
        }
    }
    public static void Main(string[] args)
    {
        Prostokat[] tabela = new Prostokat[3];
        tabela[0] = new Prostokat(2, 5);
        tabela[1] = new Prostokat(5, 8);
        tabela[2] = new Prostokat(6, 4);
        
        foreach (Prostokat p in tabela)
        {
            p.Prezentuj();
        }
    }
}