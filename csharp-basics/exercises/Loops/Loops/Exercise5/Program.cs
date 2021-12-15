using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine();

            Console.WriteLine();
            Console.Write(word1);
            
            for (int i = 0; i < 30 - word1.Length - word2.Length; i++)
            {
                Console.Write(".");
            }

            Console.Write(word2);

            Console.ReadKey();
        }
    }
}
