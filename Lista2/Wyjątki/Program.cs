namespace Wyjątki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2, liczba3;
            liczba1 = 30;
            liczba2 = 0;
            int[] tabela = new int[2];

            try
            {
                tabela[25] = 2;
            }
            catch ()
            {
                Console.WriteLine("Błąd");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            /*try
            {
                liczba3 = liczba1 / liczba2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("FINALLY");
            }*/
        }
    }
}
