namespace Projekt_TEST;

class Program
{
    class Test : ICloneable
    {
        public int liczba;
        public Test2 poleTestowe;

        public Test()
        {
            this.poleTestowe = new Test2();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Test GlebokaKopia()
        {
            Test tempTest = new Test();
            tempTest.liczba = this.liczba;
            tempTest.poleTestowe.slowo = this.poleTestowe.slowo;
            return tempTest;
        }
    }

    class Test2
    {
        public string slowo;
    }
    
    static void Main(string[] args)
    {
        Test obiekt1 = new Test();
        Test obiekt2 = new Test();
        Test obiekt3 = new Test();

        obiekt1.liczba = 255;
        obiekt1.poleTestowe.slowo = "słowo";
        obiekt2 = obiekt1;
        //obiekt3 = (Test)obiekt1.Clone();
        obiekt3 = obiekt1.GlebokaKopia();
        obiekt1.liczba = 347;
        obiekt1.poleTestowe.slowo = "kaczka";

        Console.WriteLine(obiekt1.liczba); // 347
        Console.WriteLine(obiekt1.poleTestowe.slowo); // kaczka
        Console.WriteLine(obiekt2.liczba); // 347, bo obiekt2 to tylko referencja do obiekt1
        Console.WriteLine(obiekt2.poleTestowe.slowo); // kaczka, bo j/w
        Console.WriteLine(obiekt3.liczba); // 255, bo obiekt3 to kopia obiektu1 gdy jeszcze zawierał liczba 255
        Console.WriteLine(obiekt3.poleTestowe.slowo); // kaczka, bo shallowcopy skopiowal tylko referencje do obiektu test2

        Pies pies1 = new Pies();
        pies1.imie = "Burek";
        pies1.waga = 10;
        pies1.rozmiar = 3;
        Pies pies2 = (Pies)pies1.Copy();
        Console.WriteLine(pies2.imie);
        pies2.JakSiePoruszam();
        Orzel orzel1 = new Orzel();
        orzel1.JakSiePoruszam();
        Kolo kolo1 = new Kolo();
        kolo1.PobierzDaneZKlawiatury();
        Console.WriteLine($"Obwód kola {kolo1.nazwa} to {kolo1.LiczObwod()}");
        string kolo1String = kolo1.ToString();
        Console.WriteLine(kolo1String);

    }
}