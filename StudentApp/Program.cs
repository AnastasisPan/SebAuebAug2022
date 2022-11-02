namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new();        // C# 9.0
            var julia = new Student();  // C# 3.0

            alice.Id = 1;
            Console.WriteLine(alice.Id);

            // Object Initializer
            Student john = new Student()
            {
                Id = 1,
                Firstname = "John",
                Lastname = "X."
            };
        }
    }
}