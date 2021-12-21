using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("e");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            foreach (var item in set)
            {
                set.Remove(item);
            }

            Console.WriteLine();

            set.Add("a");
            set.Add("a");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}

