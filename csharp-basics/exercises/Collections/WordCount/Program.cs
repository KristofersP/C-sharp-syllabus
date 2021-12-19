using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("../../lear.txt");
            int wordsum = 0;
            int charsum = 0;
            int numLines = text.Split('\n').Length;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ' || text[i] == '\'')
                {
                    wordsum++;
                }

                charsum++;

                if(text[i] == ',')
                {
                    charsum--;
                }
                
            }

            Console.WriteLine($"Words = {wordsum + 1}");
            Console.WriteLine("Chars = " + charsum);
            Console.WriteLine("Lines = " + numLines);
            Console.ReadKey();
        }
    }
}
