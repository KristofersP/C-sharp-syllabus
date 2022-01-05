using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        public string breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            this.breed = breed;
        }

        public override void EatFood(Food food)
        {    
            foodEaten = food.quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Moew!!!!");
        }

        public override string ToString()
        {
            return $"{animalType} [{animalName}, {animalWeight},{breed}, {livingRegion}, {foodEaten}]";
        }
    }
}
