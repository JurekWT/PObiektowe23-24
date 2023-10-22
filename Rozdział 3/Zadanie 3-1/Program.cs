// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj rok:");
int year = int.Parse(Console.ReadLine());
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    Console.WriteLine("{0} to rok przestępny.", year);
else
    Console.WriteLine("{0} nie jest rokiem przestępnym.", year);
