namespace CharReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputChar;
            int charCode;

            Console.WriteLine("Please insert some chars");

            do
            {
                
                charCode = Console.Read();
                inputChar = (char)charCode;
                Console.WriteLine($"char: {inputChar}) - charCode: {charCode}");
            } while (charCode != 10);
        }
    }
}