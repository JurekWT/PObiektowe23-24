// See https://aka.ms/new-console-template for more information

int[,] tab1 = new int[,]
{
    {2,3,5},
    {6,7,4}
};
int[,] tab2 = new int[,]
{
    {4,5,3},
    {4,6,3}
};
int[,] tab3 = new int[tab1.GetLength(0),tab1.GetLength(1)];

for (int wiersz = 0; wiersz < tab1.GetLength(0); wiersz++)
{
    for (int kolumna = 0; kolumna < tab1.GetLength(1); kolumna++)
    {
        tab3[wiersz, kolumna] = tab1[wiersz, kolumna] + tab2[wiersz, kolumna];
        Console.Write("{0,4}",tab3[wiersz,kolumna]);
    }
    Console.WriteLine();
}