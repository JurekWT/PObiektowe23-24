namespace Figury;

public abstract class Figura
{
    protected int zmienna1;
    protected int zmienna2;
    protected int zmienna3;

    public abstract void ObliczPole();
}

public class Kwadrat : Figura
{
    public Kwadrat(int a)
    {
        base.zmienna1 = a;
    }

    public override void ObliczPole()
    {
        Console.WriteLine($"Pole kwadratu {zmienna1*zmienna1}");
    }
}

public class Trojkat : Figura
{
    public Trojkat(int a, int h)
    {
        zmienna1 = a;
        zmienna2 = h;
    }

    public override void ObliczPole()
    {
        Console.WriteLine($"Pole trójkąta {0.5*zmienna1*zmienna2}");
    }
}