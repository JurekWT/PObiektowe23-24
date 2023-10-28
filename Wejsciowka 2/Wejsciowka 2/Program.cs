// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj dzień urodzin:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj miesiąc urodzin:");
int y = int.Parse(Console.ReadLine());
y += 55;
for (int i = x; i < y+1; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}