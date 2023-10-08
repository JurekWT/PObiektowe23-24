// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj temperaturę w stopniach celsjusza:");
float c = float.Parse(Console.ReadLine());
float f = 32 + ((9 * c) / 5);
Console.WriteLine("W Fahrenheitach to: {0}", f);