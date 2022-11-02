using BankApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    internal class Account
    {
        public long Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public override string ToString() => $"{Id}, {Iban}, {Firstname}, {Lastname}, {Ssn}, {Balance}";

        // Public API

        /// <summary>
        /// Deposits a certain amount of money
        /// </summary>
        /// <param name="amount">The amount of money to deposit</param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount >= 0)
                {
                    Balance += amount;
                }
                else
                {
                    throw new NegativeAmountException("Error in Deposit");
                }
            } catch (NegativeAmountException e)
            {
                //Console.WriteLine($"Error in Deposit, {e}");
                //Console.WriteLine(e.StackTrace);
                //Console.WriteLine(e.Message);
                Logger(e);
                throw;
            }
        }

        /// <summary>
        /// Withdraws  a certain amount of money from
        /// the Account's balance.
        /// </summary>
        /// <param name="amount">The amount of money to withdraw</param>
        public void Withdraw(decimal amount)
        {
            try
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
                else
                {
                    throw new InsufficientBalanceException("Error in Withdraw");
                }
            } catch (InsufficientBalanceException e)
            {
                Logger(e);
                throw;
            }
        }

        private static void Logger(Exception e)
        {
            FileStream fs = new FileStream(@"C:\tmp\log.txt", FileMode.Append);
            StreamWriter sw = new(fs);

            sw.AutoFlush = true;
            sw.WriteLine($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}, {e}");
        }
    }
}
