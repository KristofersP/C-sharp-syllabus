using System;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            int foodEaten = 0;
            string[] input = Console.ReadLine().Split(' ');

            

            while(input[0] != "End")
            {
                string animalType = input[0];
                string animalName = input[1];
                double animalWeight = Convert.ToDouble(input[2]);
                string animalLivingRegion = input[3];
                string catBreed = "";

                if (input.Length == 5)
                {
                    catBreed = input[4];
                }

                if (animalType == "Cat")
                {
                    animals.Add(new Cat(animalName, animalType, animalWeight, foodEaten, animalLivingRegion, catBreed));
                }
                else if (animalType == "Tiger")
                {
                    animals.Add(new Tiger(animalName, animalType, animalWeight, foodEaten, animalLivingRegion));
                }
                else if (animalType == "Zebra")
                {
                    animals.Add(new Zebra(animalName, animalType, animalWeight, foodEaten, animalLivingRegion));
                }
                else if (animalType == "Mouse")
                {
                    animals.Add(new Mouse(animalName, animalType, animalWeight, foodEaten, animalLivingRegion));

                }

                animals.Last().MakeSound();

                string[] input1 = Console.ReadLine().Split(' ');
                string foodType = input1[0];
                int foodQuantity = Convert.ToInt32(input1[1]);

                var food = new List<Food>();

                if (foodType == "Vegetable")
                {
                    // Vegetable vegetable = new Vegetable(foodQuantity);
                    food.Add(new Vegetable(foodQuantity));
                }
                else if (foodType == "Meat")
                {
                    // Vegetable vegetable = new Vegetable(foodQuantity);
                    food.Add(new Meat(foodQuantity));
                }

                animals.Last().EatFood(food.Last());

                Console.WriteLine(animals.Last());

                input = Console.ReadLine().Split(' ');
            }

            foreach (var animal in animals)
            {
                Console.Write(animal + " ");
            }
        }
    }
}