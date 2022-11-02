using System.Diagnostics.CodeAnalysis;

namespace IfGradesApp
{
    /// <summary>
    /// Διαβάζει σύνολο βαθμολογίας και πλήθος
    /// μαθημάτων και υπολογίζει και εμφανίζει
    /// τον Μέσο Όρο καθώς και χαρακτηρισμούς
    /// 'Άριστα', 'Πολύ Καλά', 'Καλά', 'Αποτυχία'
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesSum = 0;
            int modulesCount = 0;
            int average = 0;

            Console.WriteLine("Παρακαλώ εισάγετε σύνολο βαθμολογίας και πλήθος μαθημάτων");

            if (!int.TryParse(Console.ReadLine(), out gradesSum)
                || (!int.TryParse(Console.ReadLine(), out modulesCount)))
            {
                Console.WriteLine("Grades sum input error");
                Environment.Exit(1);
            }
            if (modulesCount != 0)
            {
                average = gradesSum / modulesCount;
                if ((average >= 0) && (average <= 10))
                {
                    if (average >= 9)
                    {
                        Console.WriteLine($"Average: {average}, 'Αριστα'");
                    }
                    else if (average >= 7)
                    {
                        Console.WriteLine($"Average: {average}, 'Πολύ καλά'");
                    }
                    else if (average >= 5)
                    {
                        Console.WriteLine($"Average: {average}, 'Kαλά'");
                    }
                    else // if (average < 5)
                    {
                        Console.WriteLine($"Average: {average}, 'Αποτυχία'");
                    }
                }
                else
                {
                    throw new Exception("Error in average");
                }
            }
            else
            {
                throw new Exception("Error divide by zero");
            }

        }
    }
}