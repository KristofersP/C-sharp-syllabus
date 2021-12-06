using System;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 20, 30, 25, 35, -16, 60, -100 };
            int sum = 0;
            int count = 0;
            double average;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                count++;
            }

            average = sum / count;

            Console.WriteLine("Average value of the array elements is : " + average);
            Console.ReadKey();

        }
    }
}
