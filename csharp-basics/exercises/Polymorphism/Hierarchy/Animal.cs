using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
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

        public abstract void MakeSound();


        public abstract void EatFood(Food food);


    }
}
