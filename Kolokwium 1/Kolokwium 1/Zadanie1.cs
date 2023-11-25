// See https://aka.ms/new-console-template for more information

internal class Zadanie1
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string tab1 = Console.ReadLine();
        char[] tab2 = new char[tab1.Length];
        Foo(n, tab1, tab2);
    }

    static char[] Foo(int n, string tab1, char[] tab2)
    {
        int flicznik = n + 1;
        int dlicznik = n + 1;
        for (int litera = 0; litera < tab1.Length; litera++)
        {
            if (tab1[litera] == 'f')
            {
                flicznik--;
            }
            else if (tab2[litera] == 'd')
            {
                dlicznik--;
            } 
            if (flicznik == 0 || dlicznik == 0)
            {
                tab2[litera] = tab1[litera];
            }
        }

        return tab2;

    }
}