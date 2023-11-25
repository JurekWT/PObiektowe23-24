// See https://aka.ms/new-console-template for more information

internal class Zadanie3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("podaj n");
        int n = int.Parse(Console.ReadLine());
        int[] tab = new int[n];
        int dodatnie, ujemne, zero;
        dodatnie = ujemne = zero = 0;
        Console.WriteLine("Podaj {0} elementów całkowitych", n);
        for (int i = 0; i < n; i++)
        {
            tab[i] = int.Parse(Console.ReadLine());
            if (tab[i] > 0)
            {
                dodatnie++;
            }
            else if (tab[i] < 0)
            {
                ujemne++;
            }
            else
            {
                zero++;
            }
        }
        Console.WriteLine("Dodatnie: {0}, ujemne {1}, zera: {2}", dodatnie, ujemne, zero);
    }
}