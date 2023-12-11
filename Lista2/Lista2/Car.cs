
namespace Lista2;

public class Car
{
    public double PojemnoscSilnika { get; set; }
    public string Marka { get; set; }
    public static int iloscKol;

    static Car()
    {
        iloscKol = 4;
    }

    public Car(double pojemnoscSilnika, string marka)
    {
        this.PojemnoscSilnika = pojemnoscSilnika;
        this.Marka = marka;
    }

    static public Car Create(double pojemnosSilnika, string marka)
    {
        Car temp = new Car(pojemnosSilnika, marka);
        return temp;
    }

    ~Car()
    {

    }
}