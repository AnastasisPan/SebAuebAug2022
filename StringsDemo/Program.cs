namespace StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Not null
            String s1;

            // Nullable Reference
            String? s2;

            //String Literal Init
            String s3 = "AUEB";
            String s4 = "AUEB";


            String s5 = new String("AUEB");
            string s6 = string.Intern("AUEB");

            String s7 = new("AUEB");

            /*Console.WriteLine($"{ReferenceEquals(s3, s4)}");
            Console.WriteLine($"{s3.Equals(s5)}");
            Console.WriteLine($"{s3 == s5}");

            Console.WriteLine($"{string.Compare(s3.ToLower(), s4.ToLower())}");
            Console.WriteLine($"{s3.ToUpper().CompareTo(s4.ToUpper())}");*/

            Console.WriteLine($"{s5.IndexOf("K")}");
            Console.WriteLine($"{s7.Substring(1, 3)}");
            Console.WriteLine($"{s6.Trim()}");




        }
    }
}