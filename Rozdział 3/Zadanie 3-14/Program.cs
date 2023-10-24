// See https://aka.ms/new-console-template for more information

Console.WriteLine("Znajdź liczby doskonałe w przedziale <1,n>. Podaj n");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n+1; i++)
{
    int suma = 0;
    for (int j = 1; j < i; j++)
    {
        if (i%j==0)
        {
            suma += j;
        }
    }

    if (suma == i)
    {
        Console.Write("{0} ", suma);
    }
}
