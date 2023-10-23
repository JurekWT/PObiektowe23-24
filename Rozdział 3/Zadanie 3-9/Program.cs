// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj ilość wierszy");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Wybierz wariant [a, b, c lub d]:");
string wariant = Console.ReadLine();
if (wariant == "a")
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < i+1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else if (wariant == "b")
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < (rows - i); j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else if (wariant == "c")
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 1; j < (rows - i); j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < i+1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else if (wariant == "d")
{
    for (int i = 1; i <= rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (i == 1 || i == rows || j == 0 || j == rows-1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Podano zły wariant.");
}