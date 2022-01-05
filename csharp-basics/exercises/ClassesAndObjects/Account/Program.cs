using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account A = new Account("A", 100.00m);
            Account B = new Account("B", 0.0m);
            Account C = new Account("C", 0.0m);

            Transfer(A, B, 50.00m);
            Transfer(B, C, 25.00m);

            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());

            Console.ReadKey();
        }
        public static void Transfer(Account from, Account to, decimal howMuch)
        {
            from.Money -= howMuch;
            to.Money += howMuch;
        }


    }
}
