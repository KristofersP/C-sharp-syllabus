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
            Account C = new Account("V", 0.0m);

            Account.Transfer(A, B, 50.00m);
            Account.Transfer(B, C, 25.00m);

            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());

            Console.ReadKey();
        }

       
    }
}
