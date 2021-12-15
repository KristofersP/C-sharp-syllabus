using System;
using System.Text;

namespace Hangman
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] words = { "Kristofers", "GUNGA GINGA", "DoubleWhopper", "AMillionsDOllas" };

            var rnd = new Random();

            var word = words[rnd.Next(0, words.Length)].ToLower();
            var guessable = new string('_', word.Length);
            var misses = string.Empty;
            var missesCount = 0;

            while (guessable.IndexOf('_') != -1 && missesCount < 5)
            {
                Console.WriteLine($"Word: {guessable}");
                Console.WriteLine($"Misses: {misses}");

                var input = Console.ReadKey();
                var guess = input.KeyChar;

                Console.WriteLine();
                Console.WriteLine($"Guess: {guess} ");

                if (word.IndexOf(guess) > -1)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess)
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = word[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                    missesCount++;
                }

                if (missesCount == 5)
                {
                    Console.WriteLine("GAME OVER. Too many wrong guesses.");
                }
                else if (guessable.IndexOf('_') == -1)
                {
                    Console.WriteLine($"CONGRATULATIONS!! You succesfully guessed the word {word}");
                }
            }
            Console.ReadKey();
        }
    }
}

