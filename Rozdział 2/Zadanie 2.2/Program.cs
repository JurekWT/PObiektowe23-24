// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj współczynniki a,b,c równania kwadratowego ax^2+bx+c=0 :");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int delta = (b * b) - (4 * a * c);
Console.WriteLine("Delta wynosi: {0}", delta);