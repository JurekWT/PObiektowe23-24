using System;

namespace Lista3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student studenttest = new Student("Andrzej", "Kowalski", 1995, 2, 4, 190923);
            studenttest.ObliczWiek();
            Console.WriteLine(studenttest.miejsceZamieszkania);

            Student student1 = new Student("Jacek", "Głowacki", 1990, 5, 1, 123654);
            Student student2 = new Student("Stefan", "Dopuszczający", 2001, 2, 3, 200001);

            Osoba osoba1 = new Osoba("Dionizy", "Hulk", 1989);
            Osoba osoba2 = new Osoba("Maciej", "Testowy", 1997);

            osoba1 = student1 as Osoba;
            student2 = osoba2 as Student;
            osoba2.WypiszInfo();
        }
    }
}