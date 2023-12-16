namespace Pojazd;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        Bicycle bicycle1 = new Bicycle();
        car1.Ride();
        bicycle1.Ride();
        Osoba osoba1 = new Osoba();
        osoba1.Graj();
    }
}