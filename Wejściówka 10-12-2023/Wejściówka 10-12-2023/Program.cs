// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class Trojkat
    {
        public double pierwszyBok;
        public double drugiBok;
        public double trzeciBok;

        public string CzyTrojkat()
        {
            if (pierwszyBok > 0 && drugiBok > 0 && trzeciBok > 0)
            {
                if (pierwszyBok + drugiBok > trzeciBok && pierwszyBok + trzeciBok > drugiBok && drugiBok + trzeciBok > pierwszyBok)
                {
                    return "tak";
                }
                else
                {
                    return "nie";
                }
            }
            else
            {
                return "nie";
            }
        }

    }
    public static void Main(string[] args)
    {
        Trojkat triangle1 = new Trojkat();
        triangle1.pierwszyBok = 3.00;
        triangle1.drugiBok = 2.00;
        triangle1.trzeciBok = 4.00;
        Console.WriteLine($"Trójkąt o wymiarach {triangle1.pierwszyBok}x{triangle1.drugiBok}x{triangle1.trzeciBok} istnieje? {triangle1.CzyTrojkat()}");
    }
}