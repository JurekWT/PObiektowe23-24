// See https://aka.ms/new-console-template for more information

string[] srodkiTrwale = new string[] {"FR-2001","SDE-2020","NJ-1998","EXS-2014","TYM-2007"};
Console.WriteLine(srodkiTrwale[0]);
int data = DateTime.Today.Year;
int temp;
int indeks;
for (int element = 0; element < srodkiTrwale.GetLength(0); element++)
{
    indeks = srodkiTrwale[element].IndexOf('-');
    temp = int.Parse(srodkiTrwale[element].Substring(indeks+1));
    Console.WriteLine("Środek trwały {0} zakupiono {1} lat temu.", srodkiTrwale[element], data - temp);
}