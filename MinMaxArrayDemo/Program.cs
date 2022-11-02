namespace MinMaxArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 21, 17, 52, 34, 40 };
            int minPos = GetMinPosition(ages);
            int maxPos = GetMaxPosition(ages);

            Console.WriteLine("MinValue: {0}, MinPosition {1}", ages[minPos], minPos +1);
            Console.WriteLine("MinValue: {0}, MinPosition {1}", ages[maxPos], maxPos +1);
        }

        public static int GetMinPosition(int[] arr)
        {
            int minPosition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minPosition])
                {
                    minPosition = i;
                }
            }

            return minPosition;
        }

        public static int GetMaxPosition(int[] arr)
        {
            int maxPosition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxPosition])
                {
                    maxPosition = i;
                }
            }

            return maxPosition;
        }
    }
}