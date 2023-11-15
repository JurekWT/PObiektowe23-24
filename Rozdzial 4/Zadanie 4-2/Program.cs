// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj 10 elementów tablicy");
int[] tab1 = new int[10];
int[] tab2 = new int[10];
for (int i = 0; i < 10; i++)
{
    tab1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (tab1[i] >= 0)
    {
        tab2[i] = tab1[i];
    }
}