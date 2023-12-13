namespace Zadanie_6_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostopadloscian first = new Prostopadloscian(20, 30, 40);
            Prostopadloscian second = new Prostopadloscian(10, 40, 50);
            Prostopadloscian.PorownajObjetosc(second, first);

        }
    }
}
