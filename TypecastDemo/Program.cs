namespace TypecastDemo
{
    /// <summary>
    /// Demonstrates typecast examples.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            long myLong = 1_234_567_891_234L;
            float myFloat = 10.55F;
            double myDouble = 10;
            decimal myDecimal = 1200.767M;

            Console.WriteLine($"{myInt}");
            Console.WriteLine($"{myLong}");
            Console.WriteLine($"{myFloat}");
            Console.WriteLine($"{myDouble:N2}");
            Console.WriteLine($"{myDecimal}");
        }
    }
}