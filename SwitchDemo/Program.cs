namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            do
            {

                Menu();
                option = GetOption();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Επιλέξατε 1");
                        break;
                    case 2:
                        Console.WriteLine("Επιλέξατε 2");
                        break;
                    case 3:
                        Console.WriteLine("Επιλέξατε 3");
                        break;
                    case 4:
                        Console.WriteLine("Επιλέξατε 4");
                        break;
                    case 5:
                        Console.WriteLine("Επιλέξατε εξοδο");
                        break;
                    default:
                        Console.WriteLine("Επιλέξτε 1-5");
                        break;

                }
            } while (option != 5);
        }

        public static void Menu()
        {
            Console.WriteLine("Επιλέξτε ένα από τα παρακάτω: ");
            Console.WriteLine("1. Εισαγωγή");
            Console.WriteLine("2. Διαγραφή");
            Console.WriteLine("3. Ενημέρωση");
            Console.WriteLine("4. Αναζήτηση");
        }

        public static int GetOption()
        {
            return int.Parse(Console.ReadLine()!);
        }
    }
}