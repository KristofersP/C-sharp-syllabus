using System;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int size = maxNumber - minNumber;
            int[] nums = new int[size + 1];

            for (int i = 0; i <= size; i++) 
            {
                nums[i] = minNumber;
                minNumber++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            
            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
