namespace pierwszy;

public class Osoba
{
    public string imie;
    public string nazwisko;

    public Osoba(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }

    protected Osoba()
    {
        
    }

    public virtual void WypiszInfo()
    {
        Console.WriteLine($"{imie} {nazwisko}");
    }
}

public class Student : Osoba
{
    public int rokStudiow;
    public int numerGrupy;
    public int numerAlbumu;

    public Student(string imie, string nazwisko, int rokStudiow, int numerGrupy, int numerAlbumu) : base(imie,nazwisko)
    {
        this.rokStudiow = rokStudiow;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }

    public Student(int rokStudiow, int numerGrupy, int numerAlbumu)
    {
        this.rokStudiow = rokStudiow;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }

    public Student()
    {
    }

    public override void WypiszInfo()
    {
        //Console.WriteLine($"{imie} {nazwisko}, Rok: {rokStudiow}, numer grupy: {numerGrupy}, numer albumu {numerAlbumu}");
        base.WypiszInfo();
    }
}