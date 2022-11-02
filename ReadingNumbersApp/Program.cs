namespace ReadingNumbersApp
{
    /// <summary>
    /// Reads two ints from std input and
    /// adds them, and prints the result to
    /// std output
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            Console.WriteLine("Please insert two ints");
            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!);

            result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }
}