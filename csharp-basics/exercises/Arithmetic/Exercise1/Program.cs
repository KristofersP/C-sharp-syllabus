using System;

namespace Exercise1
{
    public class Program
    {
        private static int _num1;
        private static int _num2;
        static void Main()
        {
            Console.WriteLine("Enter the first number");
            _num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            _num2 = Convert.ToInt32(Console.ReadLine());
        }

        public bool CheckNumber15(int num1, int num2)
        {
            if (num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
