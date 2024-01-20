using System.Runtime.Serialization;

namespace Wyjątki;

class Program
{
    public class NaszWyjatekException : SystemException
    {
        public NaszWyjatekException()
        {
        }

        protected NaszWyjatekException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public NaszWyjatekException(string? message) : base(message)
        {
        }

        public NaszWyjatekException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
    static void Main(string[] args)
    {
        static void metoda23()
        {
            throw new NotImplementedException();
        }
        try
        {
            int liczba1 = 1;
            int liczba2 = 0;
            //int liczba3 = liczba1 / liczba2;
            metoda23();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}