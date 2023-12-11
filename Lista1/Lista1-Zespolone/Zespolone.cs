namespace Lista1_Zespolone;

public class Zespolone
{
    public double Real { get; set; }
    public double Imag { get; set; }

    public Zespolone(double rzeczywista, double urojona)
    {
        this.Real = rzeczywista;
        this.Imag = urojona;
    }

    public void WypiszZesp()
    {
        if (Real == 0)
        {
            if (Imag == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine($"{Imag}i");
            }
        }
        else if (Imag < 0)
        {
            Console.WriteLine($"{Real}{Imag}i");
        }
        else if (Imag == 0)
        {
            Console.WriteLine($"{Real}");
        }
        else
        {
            Console.WriteLine($"{Real}+{Imag}i");
        }
    }

    static public Zespolone DodawanieZespolonych(Zespolone a, Zespolone b)
    {
        Zespolone temp = new Zespolone(a.Real+b.Real,a.Imag+b.Imag);
        return temp;
    }

    static public Zespolone OdejmowanieZespolone(Zespolone a, Zespolone b)
    {
        Zespolone temp = new Zespolone(a.Real-b.Real,a.Imag-b.Imag);
        return temp;
    }
}