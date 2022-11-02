using System.Numerics;

namespace WhileDemo
{
    /// <summary>
    /// Υπολογίζει και εμφανίζει
    /// το άθροισμα και το γινόμενο
    /// από το 1 έως ένα αριθμό
    /// που δίνει ο χρήστης
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            BigInteger mul = 1;

            Console.WriteLine("Please insert an int");

            if (!int.TryParse(Console.ReadLine(), out int inputNum))
            {
                Console.WriteLine("Error in input");
                Environment.Exit(1);
            }

            i = 1;
            while(i <= inputNum)
            {
                sum += i;
                mul *= i;
                i++;
            }

            Console.WriteLine($"input number: {inputNum}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Mul: {mul}");
        }
    }
}