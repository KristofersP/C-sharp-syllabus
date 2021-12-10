using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");

            int sum = 0;
            bool gameOn = true;
            int dice;
            Random rnd = new Random();


            while (gameOn)
            {
                dice = rnd.Next(1, 7);

                Console.WriteLine($"You rolled a {dice}");

                if (dice == 1)
                {
                    gameOn = false;
                    sum = 0;
                }
                else
                {
                    sum += dice;

                    Console.WriteLine("Roll again? (y/n)");

                    string choice = Console.ReadLine();

                    if (choice == "y") continue;
                    else gameOn = false;
                }
            }

            Console.WriteLine($"You got {sum} points.");
        }
    }
}