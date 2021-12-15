using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 562, 3345, 224, 54, 46, 77, 558, 3459, 1066, 114, 12, 1, 23, 33, 100, 1, 348, 34, 243 };

            Console.WriteLine(string.Join(',', numbers));
            Console.WriteLine("Which numbers position you want to know?");

            int chosenNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == chosenNum)
                {
                    Console.WriteLine("Your numbers position is: " + i);
                }
            }
        }
    }
}

