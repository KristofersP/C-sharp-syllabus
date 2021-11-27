using System;

namespace ClassesAndTeachers
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will you want to add?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Choose a digit 1-9.");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 10 && number > -10)
                {
                    sum += number;
                } else
                {
                    Console.WriteLine("The number must be a single digit.");
                    quantity++;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of the digits: {sum}");
        }
    }
}
