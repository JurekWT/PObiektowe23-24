namespace Pojazd;

public class Car : Vehicle, IRideable
{
    public void Ride()
    {
        Console.WriteLine("Jadę samochodem");
    }
}