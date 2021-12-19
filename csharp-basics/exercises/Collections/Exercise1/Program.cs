using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = new List<string>(array);
            list.ForEach(Console.WriteLine);

            Console.WriteLine();

            HashSet<string> set = new HashSet<string>(array);
            Console.WriteLine(string.Join(" ", set));

            Console.WriteLine();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Audi", "Germany");
            dict.Add("BMW", "Germany");
            dict.Add("Honda", "Japan");
            dict.Add("Mercedes", "Germany");
            dict.Add("VolksWagen", "Germany");
            dict.Add("Tesla", "USA");

            dict.ToList().ForEach(x => Console.WriteLine(x.Key));

            Console.ReadKey();
        }
    }
}
