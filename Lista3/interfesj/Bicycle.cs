namespace Pojazd;

public class Bicycle : Vehicle, IRideable
{
    public void Ride()
    {
        Console.WriteLine("Jadę rowerem");
    }
}