namespace ConsoleOutputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            Console.WriteLine(i);
            Console.WriteLine("Η τιμή του i είναι " +i);
            Console.WriteLine("Η τιμή του {0}", i);
            Console.WriteLine($"Η τιμή του {i} είναι {i}");
        }
    }
}