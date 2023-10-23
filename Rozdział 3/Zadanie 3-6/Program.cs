// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj wagę w kilogramach:");
double waga = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj wzrost w metrach:");
double wzrost = double.Parse(Console.ReadLine());
double bmi = waga / (wzrost*wzrost);
Console.WriteLine("Twoje BMI wynosi: {0}", bmi);
if (bmi < 18.5)
{
    if (bmi < 16.0)
    {
        Console.WriteLine("Wygłodzenie");
    }

    else if (bmi >= 16.00 && bmi <= 17.00)
    {
        Console.WriteLine("Wychudzenie");
    }
    else
    {
        Console.WriteLine("Niedowaga");
    }
}
else if (bmi >= 18.5 && bmi <= 24.99)
{
    Console.WriteLine("wartość prawidłowa");
}
else
{
    if (bmi <30.00)
    {
        Console.WriteLine("Nadwaga");
    }
    
    if (bmi >= 30.00 && bmi < 35.00)
    {
        Console.WriteLine("Otyłość I stopnia");
    }
    if (bmi >= 35.00 && bmi < 40.00)
    {
        Console.WriteLine("Otyłość II stopnia!");
    }
    if(bmi >= 40.00)
    {
        Console.WriteLine("Otyłość III stopnia!!!");
    }
}