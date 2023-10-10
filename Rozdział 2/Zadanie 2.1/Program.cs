// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj temperaturę w stopniach celsjusza:");
double c = double.Parse(Console.ReadLine());
double f = 32 + (1.8 * c);
Console.WriteLine("W Fahrenheitach to: {0}", f);
