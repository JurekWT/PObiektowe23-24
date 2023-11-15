// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj liczbę elementów");
int n = int.Parse(Console.ReadLine());
int[] tab1 = new int[n];
int[] tab2 = new int[n];
Console.WriteLine("Podaj elementy");
for (int i = 0; i < n; i++)
{
    tab1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (i == n-1)
    {
        tab2[0] = tab1[n-1];
    }
    else
    {
        tab2[i+1] = tab1[i];
    }
}

foreach (int x in tab1)
{
    Console.Write("{0} ",x);
}
Console.WriteLine();
foreach (int x in tab2)
{
    Console.Write("{0} ",x);
}