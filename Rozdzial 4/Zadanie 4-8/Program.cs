// See https://aka.ms/new-console-template for more information

string[,] dniTygodnia;
dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
dniTygodnia[0, 0] = "poniedzialek";
dniTygodnia[1, 0] = "wtorek";
dniTygodnia[2, 0] = "środa";
dniTygodnia[3, 0] = "czwartek";
dniTygodnia[4, 0] = "piątek";
dniTygodnia[5, 0] = "sobota";
dniTygodnia[6, 0] = "niedziela";
dniTygodnia[0, 1] = "monday";
dniTygodnia[1, 1] = "tuesday";
dniTygodnia[2, 1] = "wednesday";
dniTygodnia[3, 1] = "Thursday";
dniTygodnia[4, 1] = "Friday";
dniTygodnia[5, 1] = "Saturday";
dniTygodnia[6, 1] = "Sunday";
dniTygodnia[0, 2] = "montag";
dniTygodnia[1, 2] = "dienstag";
dniTygodnia[2, 2] = "mittwoch";
dniTygodnia[3, 2] = "Donnerstag";
dniTygodnia[4, 2] = "Freitag";
dniTygodnia[5, 2] = "Samstag";
dniTygodnia[6, 2] = "Sonntag";
for (int wiersz = 0; wiersz < dniTygodnia.GetLength(0); wiersz++)
{
    for (int kolumna = 0; kolumna < dniTygodnia.GetLength(1); kolumna++)
    {
        Console.Write("{0} ",dniTygodnia[wiersz,kolumna]);
    }
    Console.WriteLine();
}