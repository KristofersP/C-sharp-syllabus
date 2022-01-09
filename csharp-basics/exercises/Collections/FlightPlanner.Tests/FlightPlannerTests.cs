using NUnit.Framework;
using FlightPlanner;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner.Tests
{
    public class Tests
    {
        private Program _target;

        [SetUp]
        public void Setup()
        {
            _target = new Program();
        }

        [Test]
        public void FillDictionary_ShouldReturnFullList()
        {
            //Arrange
            var path = @"..\..\..\..\FlightPlanner\flights.txt";
            List<string> readText = File.ReadAllLines(path).ToList();

            var expected = new Dictionary<string, List<string>>()
            {
                {"San Jose", new List<string>{ "San Francisco", "Anchorage"} },
                {"New York", new List<string>{ "Anchorage", "San Jose", "San Francisco", "Honolulu" } },
                {"Anchorage", new List<string>{ "New York", "San Jose" } },
                {"Honolulu", new List<string>{ "New York", "San Francisco" } },
                {"Denver", new List<string>{ "San Jose" } },
                {"San Francisco", new List<string>{ "New York", "Honolulu", "Denver" } }
            };

            //Act
            var result = _target.FillDictionary(readText);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FillTrip_ShouldReturnAddedCities()
        {
            //Arrange
            var flights = new Dictionary<string, List<string>>()
            {
                {"San Jose", new List<string>{ "San Francisco", "Anchorage"} },
                {"New York", new List<string>{ "Anchorage", "San Jose", "San Francisco", "Honolulu" } },
                {"Anchorage", new List<string>{ "New York", "San Jose" } },
                {"Honolulu", new List<string>{ "New York", "San Francisco" } },
                {"Denver", new List<string>{ "San Jose" } },
                {"San Francisco", new List<string>{ "New York", "Honolulu", "Denver" } }
            };
            var city1 = "New York";
            var city2 = "Honolulu";
            var city3 = "New York";

            var expected = new List<string> { "New York", "Honolulu", "New York" };

            //Act
            _target.FillTrip(flights, city1);
            _target.FillTrip(flights, city2);
            var result = _target.FillTrip(flights, city3);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}