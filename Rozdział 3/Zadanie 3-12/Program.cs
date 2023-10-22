// See https://aka.ms/new-console-template for more information

int number = 1, count = 0;
Console.WriteLine("Wpisz 0");
while (number != 0)
{
    number = int.Parse(Console.ReadLine());
    count++;
}
Console.WriteLine(count);