namespace Array2DApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            int[,] arr2 =
            {
                {1, 2, 3},
                {4, 5, 6},
                {5, 6, 7}
            };

            // Jagged Arrays
            int[][] jagged = new int[3][];
            jagged[0] = new int[10];
            jagged[1] = new int[5];
            jagged[2] = new int[6];

            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}