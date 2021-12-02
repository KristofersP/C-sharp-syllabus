
using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment((decimal)7.50, 35);
            Payment((decimal)8.20, 47);
            Payment((decimal)10.00, 73);
        }

        public static void Payment(decimal basePay, int hoursWorked)
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
