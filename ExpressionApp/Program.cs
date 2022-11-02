namespace ExpressionApp
{
    /// <summary>
    /// Addws two ints
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Δήλωση και Αρχικοποίηση Μεταβλητών
            int num1 = 10;
            int num2 = 20;
            int result = 0;

            // Εντολές
            result = num1 + num2;

            // Εκτύπωση Αποτελεσμάτων
            Console.WriteLine("Το άθροισμα των " + num1 + " + " + num2 + " είναι " + result);
            Console.WriteLine("Tο άθροισμα των {0} + {1} είναι {2}", num1, num2, result);
            Console.WriteLine($"Το άθροισμα των {num1} + {num2} = {result}");
        }
    }
}