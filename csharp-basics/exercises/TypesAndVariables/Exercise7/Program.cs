using System;

namespace Exercise7
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string text = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of upper case letters in this string: {count}");
        }
    }
}