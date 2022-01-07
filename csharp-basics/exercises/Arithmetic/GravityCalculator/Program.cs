
using System;

namespace GravityCalculator
{
    public class Program
    {
        private static double _gravity = 9.81;
        private static double _fallingTime = 10.0;

        static void Main(string[] args)
        {
            var calc = new Program();
            Console.WriteLine("The object's position after " + _fallingTime + " seconds is " + calc.CalculateFinalPosition(_gravity, _fallingTime) + " m.");
            Console.ReadKey();
        }

        public double CalculateFinalPosition(double gravity, double fallingTime)
        {
            return (gravity * fallingTime * fallingTime) / 2;
        }
    }
}
