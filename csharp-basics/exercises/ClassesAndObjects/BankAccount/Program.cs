using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bensen = new BankAccount("Bensen", -17.5m);

            Console.WriteLine(bensen.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}
