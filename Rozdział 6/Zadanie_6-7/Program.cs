﻿// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class Punkt
    {
        public decimal WspA { get; set; }
        public decimal WspB { get; set; }
        public string NazwaPunktu { get; set; }

        public Punkt(string nazwa, decimal osX, decimal osY)
        {
            this.WspA = osX;
            this.WspB = osY;
            this.NazwaPunktu = nazwa;
        }

        public void Przesun(decimal osX, decimal osY)
        {
            WspA += osX;
            WspB += osY;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Aktualne współrzędne punktu {NazwaPunktu} to ({WspA},{WspB})");
        }

    }
    
    public class Odcinek
    {
        public Punkt A { get; set; }
        public Punkt B { get; set; }

        public Odcinek(Punkt a, Punkt b)
        {
            this.A = a;
            this.B = b;
        }

        public double Dlugosc()
        {
            double temp;
            temp = Math.Sqrt(Math.Pow((double)(A.WspB - A.WspA), 2) + Math.Pow((double)(B.WspB - B.WspA), 2));
            return temp;
        }
        
    }
    public static void Main(string[] args)
    {
        Punkt a = new Punkt("A",0, 6);
        Punkt b = new Punkt("B",6, 5);
        a.Przesun(2,0);
        a.Wyswietl();
        Odcinek odcinek = new Odcinek(a, b);
        Console.WriteLine(odcinek.Dlugosc());
    }
}