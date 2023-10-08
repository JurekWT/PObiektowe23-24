// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj wagę w kilogramach:");
float waga = float.Parse(Console.ReadLine());
Console.WriteLine("Podaj wzrost w metrach:");
float wzrost = float.Parse(Console.ReadLine());
float bmi = waga / (wzrost*wzrost);
Console.WriteLine("Twoje BMI wynosi: {0}", bmi);