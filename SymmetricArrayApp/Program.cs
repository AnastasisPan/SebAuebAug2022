namespace SymmetricArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 2, 3, 3, 2, 1 };
        }

        public static bool IsSymmetric(int[] arr)
        {
            bool isSymmetric = false;

            for (int i = 0, j = arr.Length -1; i < j; i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    isSymmetric = false;
                    break;
                }
            }

            return isSymmetric;
        }

        public static bool isSymmetric2(int[] arr)
        {
            bool isSymmetric = true;

            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i] != arr[arr.Length-1 -i])
                {
                    isSymmetric = false;
                    break;
                }
            }

            return isSymmetric;
        }
    }
}