using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            
            for (i = 1; i <= n; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
