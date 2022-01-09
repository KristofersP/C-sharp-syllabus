using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
         
        }

        public override int EatFood(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine($"{animalType} are not eating that type of food!");
                foodEaten = 0;
            }
            else
            {
                foodEaten = food.quantity;
            }

            return foodEaten;
        }

        public override string MakeSound()
        {
            return "Brrrr!";
        }

        public override string ToString()
        {
            return $"{animalType} [{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
