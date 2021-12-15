using System;

namespace AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            int num = 0;

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < (rows - 1) * 8; j++)
                {
                    if (i == 0)
                    {
                        if (((rows - 1) * 8) / 2 <= j)
                        {
                            Console.Write("\\");
                        }
                        else 
                        {
                            Console.Write("/");                      }
                    }
                    else
                    {
                        if (j < ((rows - 1) * 4) - num)
                        {
                            Console.Write("/");
                        }
                        else if (j >= ((rows - 1) * 4) + num)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
        
                }

                Console.WriteLine();
                num += 4;
            }

            Console.ReadKey();
        }
    }
}
