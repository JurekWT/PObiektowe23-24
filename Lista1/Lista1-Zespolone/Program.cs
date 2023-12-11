// See https://aka.ms/new-console-template for more information

using Lista1_Zespolone;

internal class Program
{
    public static void Main(string[] args)
    {
        Zespolone zesp1 = new Zespolone(20, -8);
        Zespolone zesp2 = new Zespolone(30, 68);
        Zespolone zesp3 = Zespolone.DodawanieZespolonych(zesp1, zesp2);
        zesp1.WypiszZesp();
        zesp3.WypiszZesp();
        Zespolone zesp4 = Zespolone.OdejmowanieZespolone(zesp1, zesp2);
        zesp4.WypiszZesp();
    }
}