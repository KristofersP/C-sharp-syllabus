using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string eyes;
            string teeth;
            string hair;
            int age;
            double height;
            double weight;

            name = "Zed A. Shaw";
            age = 35;
            height = 74 * 2.54;  // inches
            weight = 180 * 0.453592; // lbs
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";

            height = Math.Round(height, 2);
            weight = Math.Round(weight, 2);

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " centimeters tall tall.");
            Console.WriteLine("He's " + weight + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                               + " I get " + (age + height + weight) + ".");

            Console.ReadKey();
        }
    }
}