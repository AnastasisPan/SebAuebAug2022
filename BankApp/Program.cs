using BankApp.Exceptions;
using BankApp.Model;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account()
            {
                Id = 1,
                Iban = "GR123",
                Firstname = "Alice",
                Lastname = "W.",
                Ssn = "A1267",
                Balance = 1000m
            };

            try
            {
                account.Deposit(150m);
                account.Withdraw(750.50m);
                Console.WriteLine($"Account: {account}");

            } catch (NegativeAmountException e)
            {
                Console.WriteLine(e.Message);
            } catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}