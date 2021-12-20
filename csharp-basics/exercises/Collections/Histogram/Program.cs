using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var sortedMarks = new Dictionary<string, string>();
            var sortMarks = new Dictionary<string, string>
            {
                { "00-09", String.Empty},
                { "10-19", String.Empty},
                { "20-29", String.Empty},
                { "30-39", String.Empty},
                { "40-49", String.Empty},
                { "50-59", String.Empty},
                { "60-69", String.Empty},
                { "70-79", String.Empty},
                { "80-89", String.Empty},
                { "90-99", String.Empty},
                { "100", String.Empty},
            };
            foreach (var s in readText)
            {
                var entries = Regex.Split(s, @" ");
                int[] myNumbers = Array.ConvertAll(entries, int.Parse);

                foreach (var item in sortMarks)
                {
                    var z = item.Key.Split('-').Select(i => int.Parse(i)).ToList();
                    if (z.Count == 2)
                    {
                        sortedMarks.Add($"{z[0].ToString().PadLeft(2, '0')}-{z[1].ToString().PadLeft(2, '0')}", new string('*', myNumbers.Where(n => n >= z[0] && n <= z[1]).Count()));
                    }
                    else
                    {
                        sortedMarks.Add($"{z[0]}", new string('*', myNumbers.Where(n => n == z[0]).Count()));
                    }
                }

            }
            foreach (var item in sortedMarks)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
