using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the max number:");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            
            for (int i = 1; i <= maxNum; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                count++;

                if (count % 20 == 0) Console.WriteLine();
            }
        }
    }
}
