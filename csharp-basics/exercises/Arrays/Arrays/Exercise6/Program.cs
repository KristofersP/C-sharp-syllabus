using System;

namespace Exercise6
{
    public class Exercise6Array
    {
        public static int[] _myArray1 = new int[10];
        public static int[] _myArray2 = new int[10];

        public Exercise6Array()
        {
            
        }
        public static void Main(string[] args)
        {
            
        }

        public int[] MakeArray1()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                _myArray1[i] = rnd.Next(1, 101);
            }

            return _myArray1;
        }

        public int[] MakeArray2()
        {
            for (int i = 0; i < 10; i++)
            {
                _myArray2[i] = _myArray1[i];
            }

            return _myArray2;
        }

        public int[] ChangeArray(int[] array)
        {
            array[9] = -7;

            return array;
        }

        public string PrintArray(int[] myArray)
        {
            return "Array: " + string.Join(",", myArray);
        }
        

    }
}
