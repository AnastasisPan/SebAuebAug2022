using System.Numerics;

namespace PowerDemo
{/// <summary>
/// 
/// Βρίσκει την δύναμη του a ^ b
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 100;
            BigInteger result = 1;
            int i;

            i = 1;
            while (i <= b)
            {
                result *= a;
                i++;
            }

            Console.WriteLine($"{a}^{b}={ result: N0}");
        }
        }
    }