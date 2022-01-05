using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?");
            var startBalance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the annual interest rate:");
            var interest = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How long has the account been open?");
            var months = Convert.ToInt32(Console.ReadLine());

            var account = new BankAccount(startBalance, interest);

            for (int i = 0; i < months; i++)
            {
                Console.WriteLine($"How much deposited for month: {i + 1}: ");
                int deposit = Convert.ToInt32(Console.ReadLine());
                account.Deposit(deposit);

                Console.WriteLine($"How much withdrawn for month: {i + 1}: ");
                int withdraw = Convert.ToInt32(Console.ReadLine());
                account.Withdraw(withdraw);

                account.AddInterest();
            }

            account.Display();

            Console.ReadKey();
        }
    }
}

