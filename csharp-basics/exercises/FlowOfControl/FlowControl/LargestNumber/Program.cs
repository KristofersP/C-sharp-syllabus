using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());
            
            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine(input1 + " Is the biggest number");
            }
            else if(input2 > input3 && input2 > input1)
            {
                Console.WriteLine(input2 + " Is the biggest number");
            }
            else
            {
                Console.WriteLine(input3 + " Is the biggest number");
            }

            Console.ReadKey();
            
        }
    }
}
