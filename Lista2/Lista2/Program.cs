// See https://aka.ms/new-console-template for more information

using Lista2;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car(1500, "VW");
        Car car2 = Car.Create(2000, "BMW");
        
    }
}