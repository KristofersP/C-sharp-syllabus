using System;
namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string lowerText = text.ToLower();
           
            for (int i = 0; i < text.Length; i++)
            {
                if(lowerText[i] == 'a' || lowerText[i] == 'b' || lowerText[i] == 'c')
                {
                    Console.Write(2);
                }
                else if (lowerText[i] == 'd' || lowerText[i] == 'e' || lowerText[i] == 'f')
                {
                    Console.Write(3);
                }
                else if (lowerText[i] == 'g' || lowerText[i] == 'h' || lowerText[i] == 'i')
                {
                    Console.Write(4);
                }
                else if (lowerText[i] == 'j' || lowerText[i] == 'k' || lowerText[i] == 'l')
                {
                    Console.Write(5);
                }
                else if (lowerText[i] == 'm' || lowerText[i] == 'n' || lowerText[i] == 'o')
                {
                    Console.Write(6);
                }
                else if (lowerText[i] == 'p' || lowerText[i] == 'q' || lowerText[i] == 'e' || lowerText[i] == 's')
                {
                    Console.Write(7);
                }
                else if (lowerText[i] == 't' || lowerText[i] == 'u' || lowerText[i] == 'v')
                {
                    Console.Write(8);
                }
                else if (lowerText[i] == 'w' || lowerText[i] == 'x' || lowerText[i] == 'y' || lowerText[i] == 'z')
                {
                    Console.Write(9);
                }
            }

            Console.ReadKey();

        }
    }
}


