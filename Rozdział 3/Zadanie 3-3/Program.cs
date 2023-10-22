// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj 3 liczby");
double a, b, c;
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
double max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("Największa liczba to: {0}", max);