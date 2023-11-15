// See https://aka.ms/new-console-template for more information

// fragment powieści A. A. Milne, "Kubuś Puchatek"
string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
               "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
               "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
               "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
               "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

int countchar = 0;
int countline = 1;
Console.WriteLine(tekst);
for (int litera = 0; litera < tekst.Length; litera++)
{
    if (tekst[litera] == '\n')
    {
        Console.WriteLine("Wiersz {0} ma {1} znaków.", countline, countchar);
        countline++;
        countchar = 0;
    }
    else
    {
        countchar++;
    }
}
Console.WriteLine("Wiersz {0} ma {1} znaków.", countline, countchar);