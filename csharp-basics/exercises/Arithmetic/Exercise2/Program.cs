using System;

namespace CheckOddEven
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine("bye!");

        }
    }
}