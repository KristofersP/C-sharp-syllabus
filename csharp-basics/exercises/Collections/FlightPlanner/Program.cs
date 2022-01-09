using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Program
    {
        private static List<string> _trip = new List<string>();
        private static string _origincity;
        private static string _currentcity;
        private static void Main(string[] args)
        {
            Program obj = new Program();

            const string path = "../../flights.txt";
            List<string> readText = File.ReadAllLines(path).ToList();

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press 0");

            var choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                foreach (var x in obj.FillDictionary(readText))
                {
                    Console.WriteLine(x.Key);
                }

                Console.WriteLine("What city are you flying from?");
                _origincity = Console.ReadLine();

                obj.DisplayOriginCityDestinations(obj.FillDictionary(readText), _origincity);
            }

            do
            {
                Console.WriteLine("Where are you flying?");
                _currentcity = Console.ReadLine();

                obj.FillTrip(obj.FillDictionary(readText), _currentcity);
            }
            while (_currentcity != _origincity);

            Console.ReadKey();
        }

        public Dictionary<string, List<string>> FillDictionary(List<string> readText)
        {
            var flights = new Dictionary<string, List<string>>();

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
            return flights;
        }

        public void DisplayOriginCityDestinations(Dictionary<string, List<string>> flights, string origincity)
        {
            _trip.Add(origincity);
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
        }
        

        public List<string> FillTrip(Dictionary<string, List<string>> flights, string currentcity)
        {
            _currentcity = currentcity;
                
            _trip.Add(_currentcity);

            if (_currentcity == _origincity)
            {
                Console.WriteLine("Your trip summary:");

                foreach (var item in _trip)
                {
                    Console.WriteLine(item);
                }   
            }
            else
            {
                Console.WriteLine("These are the destinations from that city:");

                foreach (var item in flights)
                {
                    foreach (var destination in item.Value)
                    {
                        if (item.Key == _currentcity)
                        {
                            Console.WriteLine(destination);
                        }
                    }
                }
            }

            return _trip;
        } 

    }
}