using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string number = Console.ReadLine();

            char[] c = number.ToCharArray();
            
            List<string> list = new List<string>();
            list.AddRange(number.Select(c => c.ToString()));

            int sum = 0;

            while(sum != 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum = sum + int.Parse(list[i]) * int.Parse(list[i]);
                }

                if (sum == 1)
                {
                    Console.WriteLine("Happy");
                }
                else
                {
                    list.Clear();
                    list.AddRange(sum.ToString().Select(c => c.ToString()));
                    sum = 0;
                }
            }

            Console.ReadKey();
        }
    }
}


