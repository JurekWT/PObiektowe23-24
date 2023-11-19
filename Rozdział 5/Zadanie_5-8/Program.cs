// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Suma(int x)
    {
        string temp = x.ToString();
        int suma = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            suma += temp[i] - '0';
        }
        Console.WriteLine(suma);

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());
        Suma(liczba);
    }
}