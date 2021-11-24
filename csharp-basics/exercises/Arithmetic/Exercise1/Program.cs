using System;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 15 || num2 == 15) 
            {
                Console.WriteLine("True");
            } else if (num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15)
            {
                Console.WriteLine("True");
            } else 
            {
                Console.WriteLine("False");
            }
            
        }
    }
}
