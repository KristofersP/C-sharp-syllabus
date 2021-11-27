using System;

namespace Exercise9
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance(in meters):");
            double distance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hours:");
            double hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the minutes:");
            double minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the seconds:");
            double seconds = Convert.ToInt32(Console.ReadLine());

            double speedInMetersAndSeconds =  distance / ((hours * 3600) + (minutes * 60) + seconds);
            double speedInKmAndHours = speedInMetersAndSeconds * 3.6;
            double speedInMilesAndHours = speedInKmAndHours / 1.609;

            Console.WriteLine($"{Math.Round(speedInMetersAndSeconds, 8)} m/s");
            Console.WriteLine($"{Math.Round(speedInKmAndHours, 8)} km/h");
            Console.WriteLine($"{Math.Round(speedInMilesAndHours, 8)} miles/h");

        }
    }
}
