// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj średnią ocen");
double mean = double.Parse(Console.ReadLine());
if (mean >= 2.00 && mean < 4.00)
{
    Console.WriteLine("Przyznana kwota stypendium: 0,00 zł");
}
else if (mean >= 4.00 && mean < 4.80)
{
    Console.WriteLine("Przyznana kwota stypendium: 350,00 zł");
}
else if (mean >= 4.80 && mean <= 5.00)
{
    Console.WriteLine("Przyznana kwota stypendium: 550,00 zł");
}
else
{
    Console.WriteLine("Błędna średnia ocen.");
}
