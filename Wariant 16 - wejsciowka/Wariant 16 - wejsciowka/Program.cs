// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj kwotę netto:");
double netto = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj stawkę podatku w procentach:");
double podatek = double.Parse(Console.ReadLine());
double brutto = netto * (1.00 + (podatek/100));
Console.WriteLine("Kwota brutto wynosi {0}", brutto);