// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj liczbę elementów tablicy");
int numele = int.Parse(Console.ReadLine());
int[] tablica = new int[numele];
for (int i = 0; i < numele; i++)
{
    Console.WriteLine("Podaj element nr {0}", i+1);
    tablica[i] = int.Parse(Console.ReadLine());
}
Console.Write("Elementy w tablicy: ");
for (int i = 0; i < numele; i++)
{
    Console.Write("{0} ", tablica[i]);
}