using System;

namespace RollTwoDice
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your desired sum(1 - 12):");
            int desiredSum = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int dice1 = 0;
            int dice2 = 0;

            while(dice1 + dice2 != desiredSum)
            {
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);

                Console.WriteLine($"{dice1} and {dice2} = {dice1 + dice2}");
            }
        }
    }
}
