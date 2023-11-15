// See https://aka.ms/new-console-template for more information

Console.WriteLine("Wpisz tekst:");
string tekst = Console.ReadLine();
char[] literki = tekst.ToCharArray();
Array.Sort(literki);
tekst = string.Join("",literki);
tekst = tekst.Trim();
char temp = tekst[0];
int count = 0;
Console.WriteLine(tekst);
for (int litera = 0; litera < tekst.Length; litera++)
{
    if (temp != tekst[litera])
    {
        Console.Write("{0} - {1}, ",temp,count);
        temp = tekst[litera];
        count = 1;
    }
    else
    {
        count++;
    }
}
Console.Write("{0} - {1}, ",temp,count);