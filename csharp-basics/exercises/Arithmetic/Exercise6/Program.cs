using System;

namespace Exercise6
{
    public class Programm
    {
        private static Programm coza = new Programm();
        static void Main()
        {
            coza.PrintCozaLozaWoza();
        }

        public string CheckCozaLozaWoza(int i)
        {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                   return "CozaLozaWoza" + " ";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    return "CozaLoza" + " ";
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                   return "CozaWoza" + " ";
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    return "LozaWoza" + " ";
                }
                else if (i % 7 == 0)
                {
                    return "Woza" + " ";
                }
                else if (i % 5 == 0)
                {
                    return "Loza" + " ";
                }
                else if (i % 3 == 0)
                {
                    return "Coza" + " ";
                }
                else
                {
                    return i + " ";
                }
        }

        public string CheckNewLine(int number)
        {
            
                if (number % 11 == 0)
                {
                    return "\n";
                }
                else
                {
                    return "";
                }
        }

        public void PrintCozaLozaWoza()
        {
            int counter = 0;
            for (int i = 1; i < 111; i++)
            {
                counter++;

                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaLozaWoza" + " ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza" + " ");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaWoza" + " ");
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write("LozaWoza" + " ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza" + " ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza" + " ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza" + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (counter % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}