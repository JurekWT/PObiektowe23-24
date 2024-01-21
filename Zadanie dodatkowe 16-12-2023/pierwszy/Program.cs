namespace pierwszy;

class Program
{
    static void Main(string[] args)
    {
        // Pracownik p = new Programista();
        // p.Pracuj();

        Pracownik p1 = new Programista();
        Pracownik p2 = new Projektant();
        Pracownik p3 = new Ksiegowy();

        List<Pracownik> lista = new List<Pracownik>();
        lista.Add(p1);
        lista.Add(p2);
        lista.Add(p3);

        foreach (var pracownik in lista)
        {
            pracownik.Pracuj();
        }

        Osoba student1 = new Student("Janek","Kowalski",3,3,123654);
        student1.WypiszInfo();

    }
}