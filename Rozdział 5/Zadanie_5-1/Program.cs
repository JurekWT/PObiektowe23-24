// See https://aka.ms/new-console-template for more information

internal class Program
{
    static double temp_conv(double fahr)
    {
        double celsius = (fahr - 32.00) * (5.00 / 9.00);
        return celsius;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj temperaturę w stopniach Fahrenheita");
        double temp;
        temp = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:N2} stopni Celsjusza",temp_conv(temp));
    }
}