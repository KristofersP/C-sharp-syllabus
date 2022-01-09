using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string animalName;
        public string animalType;
        public double animalWeight;
        public int foodEaten;

        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
            this.foodEaten = foodEaten;
        }

        public abstract string MakeSound();


        public abstract int EatFood(Food food);


    }
}
