// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj pierwszą liczbę:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj operator (* lub / lub + lub -):");
string op = Console.ReadLine();
Console.WriteLine("Podaj druga liczbę:");
double b = double.Parse(Console.ReadLine());
if (op == "+")
{
    Console.WriteLine("Wynik: {0}", a+b);
}
else if (op == "-")
{
    Console.WriteLine("Wynik: {0}", a-b);
}
else if (op == "*")
{
    Console.WriteLine("Wynik: {0}", a*b);
}
else if (op == "/")
{
    Console.WriteLine("Wynik: {0}", a/b);
}