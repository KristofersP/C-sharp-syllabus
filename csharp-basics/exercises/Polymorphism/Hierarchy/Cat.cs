using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Felime
    {
        public string breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            this.breed = breed;
        }

        public override int EatFood(Food food)
        {    
            foodEaten = food.quantity;
            return foodEaten;
        }

        public override string MakeSound()
        {
            return "Moew!!!!";
        }

        public override string ToString()
        {
            return $"{animalType} [{animalName}, {animalWeight},{breed}, {livingRegion}, {foodEaten}]";
        }
    }
}
