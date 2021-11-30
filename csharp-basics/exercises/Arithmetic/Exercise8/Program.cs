
using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            payment((decimal)7.50, 35);
            payment((decimal)8.20, 47);
            payment((decimal)10.00, 73);
        }

        public static void payment(decimal basePay, int hoursWorked)
        {
            int bonusHours;
            decimal salary;

            if (basePay < 8 || hoursWorked > 60)
            {
                Console.WriteLine("ERROR");
            }
            else if (hoursWorked > 40)
            {
                bonusHours = hoursWorked - 40;
                salary = 40 * basePay + bonusHours * basePay * (decimal)1.5;

                Console.WriteLine(salary);
            }
        }
    }
}
