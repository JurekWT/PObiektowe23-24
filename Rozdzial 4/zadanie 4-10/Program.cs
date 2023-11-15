// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj datę (DD-MM-RRRR):");
string data = Console.ReadLine();
int month = int.Parse(data.Substring(data.IndexOf('-')+1,2));
switch (month)
{
    case 1:
        Console.WriteLine("Styczeń");
        break;
    case 2:
        Console.WriteLine("Luty");
        break;
    case 3:
        Console.WriteLine("Marzec");
        break;
    case 4:
        Console.WriteLine("Kwiecień");
        break;
    case 5:
        Console.WriteLine("Maj");
        break;
    case 6:
        Console.WriteLine("Czerwiec");
        break;
    case 7:
        Console.WriteLine("Lipiec");
        break;
    case 8:
        Console.WriteLine("Sierpień");
        break;
    case 9:
        Console.WriteLine("Wrzesień");
        break;
    case 10:
        Console.WriteLine("Październik");
        break;
    case 11:
        Console.WriteLine("Listopad");
        break;
    case 12:
        Console.WriteLine("Grudzień");
        break;
    default:
        Console.WriteLine("Podano błędny miesiąc");
        break;
}
