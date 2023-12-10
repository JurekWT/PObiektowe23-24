// See https://aka.ms/new-console-template for more information

using Lista1;

internal class Program
{
    public static void Main(string[] args)
    {
        string carName = "Mój samochód";
        Car car1 = new Car("Audi", 2023);
        Console.WriteLine($"Marka: {car1.Marka}, Rok produkcji: {car1.Rok}");
        // ref Car car2 = ref car1;
        // Console.WriteLine($"Marka: {car2.Marka}, Rok produkcji: {car2.Rok}");
        
    }
}