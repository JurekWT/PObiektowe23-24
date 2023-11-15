// See https://aka.ms/new-console-template for more information

int[,] tab1 = new int[5,5] {    { 2, 4, 6, 4, 3 },
                                { 5, 4, 7, 3, 4 },
                                { 5, 7, 7, 32, 3 },
                                { 7, 9, 2, 6, 6 },
                                { 34, 9, 80, 7, 100 } };
int suma = 0;
for (int wiersz = 0; wiersz < tab1.GetLength(0); wiersz++)
{
    for (int kolumna = 0; kolumna < tab1.GetLength(1); kolumna++)
    {
        Console.Write("{0,4}",tab1[wiersz,kolumna]);
        if (wiersz == kolumna)
        {
            suma += tab1[wiersz, kolumna];
        }
    }

    Console.WriteLine();
}
Console.WriteLine(suma);