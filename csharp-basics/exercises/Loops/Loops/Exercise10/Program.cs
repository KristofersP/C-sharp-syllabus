using System;

namespace NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter min value:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max value:");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                   if (i == min)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        if((j + i - 1) > max)
                        {
                            Console.Write(j + i - 6);
                        }
                        else
                        {
                            Console.Write(j + i - 1);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

