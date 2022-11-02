namespace RightTriangleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0D;
            double b = 0D;
            double c = 0D;

            const double EPSILON = 0.000005;

            bool isRight = false;

            Console.WriteLine("Please insert three doubles, a, b, c");
            a = double.Parse(Console.ReadLine()!);
            b = double.Parse(Console.ReadLine()!);
            c = double.Parse(Console.ReadLine()!);

            isRight = Math.Abs(a*a - b*b - c*c) < EPSILON;

            Console.WriteLine("Το τρίγωνο{0}είναι ορθογώνιο", (isRight) ? "  " : " δεν ");
        }
    }
}