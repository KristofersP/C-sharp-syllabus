using System;

namespace CheckOddEven
{
    public class Programm
    {
        private static int _number;
        static void Main()
        {
            Console.WriteLine("Enter a number");
            _number = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
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