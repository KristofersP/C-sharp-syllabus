
using System;

namespace Exercise8
{
    public class Program
    {
        private static Program obj = new Program();
        static void Main(string[] args)
        {
            Console.WriteLine(obj.Payment((decimal)7.50, 35));
            Console.WriteLine(obj.Payment((decimal)8.20, 47));
            Console.WriteLine(obj.Payment((decimal)10.00, 73));
        }

        public decimal Payment(decimal basePay, int hoursWorked)
        {
            int bonusHours;
            decimal salary;

            if (basePay < 8 || hoursWorked > 60)
            {
                return 0;
            }
            else
            {
                bonusHours = hoursWorked - 40;
                salary = 40 * basePay + bonusHours * basePay * (decimal)1.5;

               return salary;
            }
        }
    }
}
