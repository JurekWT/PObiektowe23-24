namespace Figury;

public abstract class Figura
{
    protected int zmienna1;
    protected int zmienna2;
    protected int zmienna3;

    public abstract void Pole();
}

public class Kwadrat : Figura
{
    public override void Pole()
    {
        Console.WriteLine($"Pole kwadratu {zmienna1*zmienna1}");
    }
}

public class Trojkat : Figura
{
    public override void Pole()
    {
        Console.WriteLine($"Pole trójkąta {0.5*zmienna1*zmienna2}");
    }
}