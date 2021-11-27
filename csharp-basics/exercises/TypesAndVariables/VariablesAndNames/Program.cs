using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int drivers;
            double passengers;
            int carsNotDriven;
            double carsDriven;
            int carpoolCapacity;
            int seatsInACar;
            double averagePassengersPerCar;

            cars = 100;
            seatsInACar = 4; 
            drivers = 28;
            passengers = 90;
            carsNotDriven = 72;
            carsDriven = 28;
            carpoolCapacity = 112;
            averagePassengersPerCar = passengers / carsDriven;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " people to carpool today.");
            Console.WriteLine("We have " + (seatsInACar - 1) + " seats in each car.");
            Console.WriteLine("We need to put about " + Math.Round(averagePassengersPerCar, 2) + " in each car.");
            Console.ReadKey();
        }
    }
}