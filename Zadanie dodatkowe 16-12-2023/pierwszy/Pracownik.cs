namespace pierwszy;

public class Pracownik
{
   // public virtual void Pracuj()
   // {
   //     Console.WriteLine("logowanie");
   // }
   public virtual void Pracuj()
   {
       Console.WriteLine("Pracownik pracuje");
   }
}

class Programista : Pracownik
{
    // public override void Pracuj()
    // {
    //     base.Pracuj();
    //     Console.WriteLine("Obowiązki programisty");
    // }

    public override void Pracuj()
    {
        Console.WriteLine("Programista pracuje");
    }
}

class Projektant : Pracownik
{
    public override void Pracuj()
    {
        Console.WriteLine("Projektant pracuje");
    }
}

class Ksiegowy : Pracownik
{
    public override void Pracuj()
    {
        Console.WriteLine("Księgowy pracuje");
    }
}
