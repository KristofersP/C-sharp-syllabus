using System;

namespace Exercise6
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray1 = new int[10];
            int[] myArray2 = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                myArray1[i] = rnd.Next(1, 101);
            }

            for (int i = 0; i < 10; i++)
            {
                myArray2[i] = myArray1[1];
            }

            myArray1[9] = -7;

            Console.WriteLine("Array 1: " + string.Join(",", myArray1));
            Console.WriteLine("Array 2: " + string.Join(",", myArray2));
        }
    }
}
