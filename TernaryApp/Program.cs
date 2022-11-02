namespace TernaryApp
{
    /// <summary>
    /// Demonstrates Ternary Operator.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;
            int abs = 0;

            Console.WriteLine("Please insert a number");
            inputNumber= int.Parse(Console.ReadLine()!);

            abs = (inputNumber >= 0) ? inputNumber : -inputNumber;

            Console.WriteLine($"abs of {inputNumber} is {abs}");

        }
    }
}