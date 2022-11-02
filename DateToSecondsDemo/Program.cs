using System.Globalization;

namespace DateToSecondsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Day = 24 * 3600;
            const int Hour = 3600;
            const int Minute = 60;

            int inputDays = 0, inputHours = 0, inputMinutes = 0, inputSeconds = 0;
            int finalSeconds = 0;

            Console.WriteLine("Please insert Days, Hours, Minutes and Seconds");
            if (!int.TryParse(Console.ReadLine(), out inputDays))
            {
                Console.WriteLine("Please give an integer");
            }

            if (!int.TryParse(Console.ReadLine(), out inputHours))
            {
                Console.WriteLine("Please give an integer");
            }

            if (!int.TryParse(Console.ReadLine(), out inputMinutes))
            {
                Console.WriteLine("Please give an integer");
            }

            if (!int.TryParse(Console.ReadLine(), out inputSeconds))
            {
                Console.WriteLine("Please give an integer");
            }

            finalSeconds = (inputDays * Day) + (inputHours * Hour) + (inputMinutes * Minute) + inputSeconds;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{inputDays} Days, {inputHours} Hours, {inputMinutes} Minutes, " + 
                $"{inputSeconds}  Seconds =  {finalSeconds:N0} Seconds");
        }
    }
}