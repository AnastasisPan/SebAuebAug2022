namespace SpacesConsumeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charCode = 0;
            do
            {
                charCode = Console.Read();

                if (charCode == 32)
                {
                    Console.Write(" ");
                    while ((charCode = Console.Read()) == 32);
                    Console.Write((char)charCode);
                }
                else
                {
                    Console.Write((char)charCode);
                }
            } while (charCode != 10);
        }
    }
}