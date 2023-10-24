// See https://aka.ms/new-console-template for more information

Console.WriteLine("Dany jest szereg W(n)=1 – 2 + 3 – 4 + ...\u00b1 n");
Console.WriteLine("Podaj n");
int n = int.Parse(Console.ReadLine());
int wynik = 0;
for (int i = 1; i < n+1; i++) 
{
    if (i % 2== 0)
    { 
        wynik -= i;
    }
    else
    {
        wynik += i;
    }
}
Console.WriteLine(wynik);

