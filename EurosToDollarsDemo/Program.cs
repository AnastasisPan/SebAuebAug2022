namespace EurosToDollarsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Rate = 116;
            int euros = 0;
            int dollars = 0, usaCents = 0, totalUsaCents = 0;

            Console.WriteLine("Please insert Euro amount");
            euros =int.Parse(Console.ReadLine()!);

            totalUsaCents = euros * Rate;

            dollars = totalUsaCents / 100;
            usaCents = totalUsaCents % 100;

            Console.WriteLine($"{euros} Euros = {dollars} and {usaCents} cents");
        }
    }
}