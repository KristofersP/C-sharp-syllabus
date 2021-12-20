using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        private static List<string> readText = File.ReadAllLines(Path).ToList();


        private static void Main(string[] args)
        {
            var flights = new Dictionary<string, List<string>>();
            var trip = new List<string>();

            foreach (var x in readText)
            {
                string[] entries = Regex.Split(x, @" -> ");
                if (flights.ContainsKey(entries[0]))
                {
                    flights[entries[0]].Add(entries[1]);
                }
                else
                {
                    flights.Add($"{entries[0]}", new List<string> { entries[1] });
                }
            }

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press 0");

            var choice = Convert.ToInt32(Console.ReadLine());


            foreach (var item in flights)
            {

                Console.WriteLine(item.Key);
            }

            Console.WriteLine("What city are you flying from?");

            var origincity = Console.ReadLine();
            trip.Add(origincity);

            Console.WriteLine("These are the destinations from that city:");

            foreach (var item in flights)
            {
                foreach (var destination in item.Value)
                {
                    if (item.Key == origincity)
                    {
                        Console.WriteLine(destination);
                    }
                }
            }

            while (choice == 1)
            {
                Console.WriteLine("Where are you flying?");
                var city = Console.ReadLine();
                trip.Add(city);

                if (city == origincity)
                {
                    Console.WriteLine("Your trip summary:");

                    foreach (var item in trip)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                }

                Console.WriteLine("These are the destinations from that city:");

                foreach (var item in flights)
                {
                    foreach (var destination in item.Value)
                    {
                        if (item.Key == city)
                        {
                            Console.WriteLine(destination);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}