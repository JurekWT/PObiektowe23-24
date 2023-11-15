// See https://aka.ms/new-console-template for more information

Console.WriteLine("Napisz zdanie:");
string chain = Console.ReadLine();
int wyrazy = 1;
foreach (char litera in chain)
{
    if (litera==' ')
    {
        wyrazy++;
    }
}
Console.WriteLine(wyrazy);