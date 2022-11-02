using System.Globalization;

namespace NumberFormatApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num = 1234L;
            double d = 1234.5678;

            DateTime dt = DateTime.Now;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("el-GR");

            Console.WriteLine("{0:D6}", num);
            Console.WriteLine("{0,6:N2}", d);
            Console.WriteLine("{0:P}", 0.451);
            Console.WriteLine("{0:X}", 254);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine($"{dt:D}");



        }
    }
}