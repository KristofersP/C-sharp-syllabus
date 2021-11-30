using System;

namespace Exercise4
{
    class Programm
    {
        static void Main()
        {
            int sum = 1;

            for (int i = 1; i <= 10; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
