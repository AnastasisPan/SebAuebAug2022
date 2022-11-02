using System.Numerics;

namespace FactoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// Iterative Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static BigInteger Facto(int n)
        {
            BigInteger result = 1;

            for(int i = 1; i <=n; i++)
            {
                result *= i;
            }

            return result;
        }


        static BigInteger FactoRecursive(int n)
        {
            /*if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * FactoRecursive(n - 1);
            }*/

            return (n == 0) ? BigInteger.One : n * FactoRecursive(n - 1);
        }
    }
}