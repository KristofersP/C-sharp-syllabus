using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Felime : Mammal
    {
        public Felime(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {

        }

        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
