using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class BankAccount
    {
        private readonly decimal AnnualInterest;
        private decimal _balance;
        private int _totalDeposit = 0;
        private int _totalWithDraw = 0;
        private decimal _totalInterest = 0;

        public BankAccount(decimal startingBalance, decimal interestRate)
        {
            _balance = startingBalance;
            AnnualInterest = interestRate/100;
        }

        public void Withdraw(int amount)
        {
            _balance -= amount;
            _totalWithDraw += amount;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
            _totalDeposit += amount;
        }

        public void AddInterest()
        {
            _balance = _balance + (_balance * AnnualInterest / 12);
            _totalInterest += (_balance * AnnualInterest / 12);
        }

        public void Display()
        {
            Console.WriteLine($"Total deposited: ${ _totalDeposit}");
            Console.WriteLine($"Total withdrawn: ${_totalWithDraw}");
            Console.WriteLine($"Interest earned: ${Math.Round(_totalInterest, 2)}");
            Console.WriteLine($"Ending balance: ${ Math.Round(_balance, 2)}");
        }
    }
}
