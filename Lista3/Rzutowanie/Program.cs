namespace Rzutowanie;

class Program
{
    static void Main(string[] args)
    {
        BaseClass based = new BaseClass();
        DerrivedClass derrivedbased = based as DerrivedClass;
        NextDerrivedClass nextderrivedbased = based as NextDerrivedClass;
    }
}