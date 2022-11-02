namespace DictionaryStudentApp
{
    internal class Program
    {
        static Dictionary<int, Student> map = new Dictionary<int, Student>();

        static void Main(string[] args)
        {
            //CRUD

            map.Add(1, new Student()
            {
                Id = 1,
                Firstname = "Alice",
                Lastname = "W."
            });
            map.Add(2, new Student()
            {
                Id = 2,
                Firstname = "Bob",
                Lastname = "D."
            });

            map.Add(3, new Student()
            {
                Id = 3,
                Firstname = "Costas",
                Lastname = "A."
            });

            map.Remove(1);

            // update
            map[2] = new Student() {
                Id = 2,
                Firstname = "Dimitra",
                Lastname = "P." };

            //Search
            if (map.ContainsKey(1))
            {
                Student student = map[1];
                Console.WriteLine(student);
            }

            Console.WriteLine("Dictionary size: " + map.Count);

            foreach (KeyValuePair<int, Student> kvp in map)
            {
                Console.WriteLine("(" + kvp.Key + "," + kvp.Value);
            }
        }
    }
}