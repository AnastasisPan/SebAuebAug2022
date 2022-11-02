namespace TryParseDemo
{
    /// <summary>
    /// Reads two ints and prints
    /// the result
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please insert two ints");


            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine("Int Error");
            }  
        }
    }
}