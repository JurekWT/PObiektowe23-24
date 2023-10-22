// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj pierwszą liczbę całkowitą:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę całkowitą:");
int b = int.Parse(Console.ReadLine());
if (a % b == 0)
    Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}", b,a);
    else
    Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby {1}", b,a);