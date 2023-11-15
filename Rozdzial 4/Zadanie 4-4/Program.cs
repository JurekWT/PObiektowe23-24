// See https://aka.ms/new-console-template for more information

Random rand = new Random();
int[] tablica = new int[100]; 
for (int i = 0; i < 100; i++)
{
    tablica[i] = rand.Next(1, 1000);
}

int count = 0;
foreach (int x in tablica)
{
    int granica = (int)Math.Floor(Math.Sqrt(x));
    for (int i = 2; i <= granica; i++)
    {
        if (x % i == 0)
        {
            break;
        }
        else if (i == granica)
        {
            count++;
        }
    }
}
Console.WriteLine("Ilośc liczb pierwszych {0}",count);