using System;

namespace Exercise5
{
    class Programm
    {
        static void Main()
        {
            int counter = 0;
            int num;
           

            for (int i = 1; i < 111; i++)
            {
                num = i;
                counter++;

                if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
                {
                    Console.Write("CozaLozaWoza" + " ");
                }
                else if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.Write("CozaLoza" + " ");
                }
                else if (num % 3 == 0 && num % 7 == 0)
                {
                    Console.Write("CozaWoza" + " ");
                }
                else if (num % 5 == 0 && num % 7 == 0)
                {
                    Console.Write("LozaWoza" + " ");
                }
                else if (num % 7 == 0)
                {
                    Console.Write("Woza" + " ");
                }
                else if (num % 5 == 0)
                {
                    Console.Write("Loza" + " ");
                }
                else if (num % 3 == 0)
                {
                    Console.Write("Coza" + " ");
                }
                else
                {
                    Console.Write(num + " ");
                }

                if (counter % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}