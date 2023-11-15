// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj liczbę elementów tablicy");
int numele = int.Parse(Console.ReadLine());
int[] tablica = new int[numele];
for (int i = 0; i < numele; i++)
{
    Console.WriteLine("Podaj element nr {0}", i+1);
    tablica[i] = int.Parse(Console.ReadLine());
}

int min = tablica[0], max = tablica[0], mean = 0, count = 0;
for (int i = 0; i < numele; i++)
{
    if (min > tablica[i])
    {
        min = tablica[i];
    }

    if (max < tablica[i])
    {
        max = tablica[i];
    }

    if (tablica[i] > 0)
    {
        count++;
    }

    mean += tablica[i];
}

mean = mean / numele;
Console.WriteLine("Najmniejsza liczba to {0}, a jej index {1}",min,Array.IndexOf(tablica,min));
Console.WriteLine("Największa liczba to {0}, a jej index {1}",max,Array.IndexOf(tablica,max));
Console.WriteLine("Średnia wartość elementów tablicy: {0}",mean);
Console.WriteLine("Liczba wartości dodatnich: {0}",count);