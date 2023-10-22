// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj liczbę n do oblczenia n!");
int n = int.Parse(Console.ReadLine());
int wynik = 1;
for (int i = 1; i < n+1; i++)
{
    wynik *= i;
}
Console.WriteLine("wynik: {0}",wynik);