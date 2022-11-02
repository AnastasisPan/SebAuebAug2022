namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and populate
            int[] arr1 = new int[3];
            int[] arr2 = { 1, 2, 3, 4 };
            int[] arr3 = new[] { 1, 2, 3, 4 };

            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            // Traverse
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }

            foreach (int num in arr3)
            {
                Console.WriteLine(num);
            }
        }
    }
}