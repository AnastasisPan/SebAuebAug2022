namespace SecondsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int DaySeconds = 24 * 3600;
            const int HourSeconds = 3600;
            const int MinuteSeconds = 60;

            int remainingSeconds = 0;
            int inputSeconds = 0;
            int days = 0, hours = 0, minutes = 0, seconds = 0;

            Console.WriteLine("Please insert number of seconds");
            if (!int.TryParse(Console.ReadLine(), out inputSeconds))
            {
                Console.WriteLine("Please give an integer number");
            }

            days = inputSeconds / DaySeconds;
            remainingSeconds = inputSeconds % DaySeconds;

            hours = remainingSeconds / HourSeconds;
            remainingSeconds = remainingSeconds % HourSeconds;

            minutes = remainingSeconds / MinuteSeconds;
            remainingSeconds %= MinuteSeconds;

            seconds = remainingSeconds;

            Console.WriteLine($"Days: {days}, Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}");


        }
    }
}