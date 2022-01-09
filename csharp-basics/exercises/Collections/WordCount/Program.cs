using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class Program
    {
        
        public static Program obj = new Program();

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("../../lear.txt");
            Console.WriteLine($"Words = {obj.WordCount(text)}");
            Console.WriteLine("Chars = " + obj.CharCount(text));
            Console.WriteLine("Lines = " + obj.LineCount(text));
            Console.ReadKey();
        }

        public int WordCount(string text)
        {
            int wordsum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' || text[i] == '\'')
                {
                    wordsum++;
                }
            }

            return wordsum + 1;
        }

        public int CharCount(string text)
        {

            int charsum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                charsum++;

                if (text[i] == ',')
                {
                    charsum--;
                }
            }

            return charsum;
        }

        public int LineCount(string text)
        {
            return text.Split('\n').Length;
        }
    }
}
