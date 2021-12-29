using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            
        }

        public override void EatFood(Food food)
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
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeek!");
        }

        public override string ToString()
        {
            return $"{animalType} [{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
