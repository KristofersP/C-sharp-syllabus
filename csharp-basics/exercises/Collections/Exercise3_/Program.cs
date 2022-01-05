using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();

            while (input != String.Empty)
            {
                names.Add(input);
                Console.WriteLine("Enter a name:");
                input = Console.ReadLine();
            }

            var uniqueItemsList = names.Distinct().ToList();
            uniqueItemsList.ForEach(Console.WriteLine);
        }
    }
}

