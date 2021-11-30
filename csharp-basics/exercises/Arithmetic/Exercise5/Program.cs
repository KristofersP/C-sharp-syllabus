using System;

namespace Exercise5
{
    class Programm
    {
        static void Main()
        {
            Random rnd = new Random();
            int guessable = rnd.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");

            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == guessable)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
                return;
            }
            else if (guess > guessable)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {guessable}.");
                return;
            }
            else if (guess < guessable)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {guessable}.");
                return;
            }
        }
    }
}