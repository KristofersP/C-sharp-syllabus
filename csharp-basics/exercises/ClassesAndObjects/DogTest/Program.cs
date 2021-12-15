using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class DogTest
    {
        
        private static void Main(string[] args)
        {
            var max = new Dog("Max", "male", "Rocky", "Lady");
            var rocky = new Dog("Rocky", "male", "Sam", "Molly");
            var sparky = new Dog("Sparky", "male", null, null);
            var buster = new Dog("Buster", "male", "Sparky", "Lady");
            var sam = new Dog("Sam", "male", null, null);
            var lady = new Dog("Lady", "female", null, null);
            var molly = new Dog("Molly", "female", null, null);
            var coco = new Dog("Coco", "female", "Buster", "Molly");

            Console.WriteLine(max.FathersName());
            Console.WriteLine(sparky.FathersName());
            Console.WriteLine(buster.HasSameMotherAs(coco));
        }
    }
}
