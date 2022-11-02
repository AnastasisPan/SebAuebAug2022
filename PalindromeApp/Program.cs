namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            
            Console.WriteLine("please insert a string");
            s = Console.ReadLine()!;

            bool isPalindrome = true;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine($"{s} is Palindrome: {isPalindrome}");
        }

        public static string? GetUpperCase(string? s)
        {
            return s?.ToUpper();
        }
    }
}