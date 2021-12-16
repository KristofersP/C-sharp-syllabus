using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private decimal _balance;

        public BankAccount(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if(_balance < 0)
            {
                _balance *= -1;
                return $"{_name}, -${_balance.ToString("0.00")}";
            }
            else
            {
                return $"{_name}, ${_balance.ToString("0.00")}";
            }
        }
    }
}
