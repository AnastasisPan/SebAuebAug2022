namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PrintDate();
            int result = Add(1, 2, 3, 4);*/
            /*int a = 1, b = 2;
            Swap(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");*/

            string s = null;
            AlterString(out s);
            Console.WriteLine(s);

        }

        public static void Swap(ref int i, ref int j)
        {
            int tmp = i;
            i = j;
            j = tmp;
        }

        public static void Swap(string s1, string s2)
        {
            string tmp = s1;
            s1 = s2;
            s2 = tmp;
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(params int[] nums)
        {
            int result = 0;

            foreach (var num in nums)
            {
                result += num;
            }

            return result;
        }

        public static void PrintDate(int day = 1, int month = 1, int year = 1900)
        {
            Console.WriteLine($"{day} {month} {year}");
        }

        public static void AlterString(out string s)
        {
            s = "HELLO";
        }
    }
}