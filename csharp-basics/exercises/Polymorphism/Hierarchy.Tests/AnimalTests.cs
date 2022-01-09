using NUnit.Framework;
using System.Collections.Generic;
using Hierarchy;
using Moq;
using System.Linq;

namespace Hierarchy.Tests
{
    public class Tests
    {
        private List<Animal> _target;

        [SetUp]
        public void Setup()
        {
            _target = new List<Animal>();
        }

        [Test]
        public void EatFood_EatsRightFood3_Returns3()
        {
            //Arrange
            _target.Add(new Cat("Gray", "Cat", 8.5, 0 , "Home", "BritishBlue"));
            var food = new List<Food>();
            food.Add(new Vegetable(3));

            //Act
            foreach (var animal in _target)
            {
                animal.EatFood(food.Last());
            }

            //Assert
            foreach (var animal in _target)
            {
                Assert.AreEqual(3, animal.foodEaten );
            }
            
        }

        [Test]
        public void MakeSound_ReturnsSound()
        {
            //Arrange
            _target.Add(new Cat("Gray", "Cat", 8.5, 0, "Home", "BritishBlue"));

            //Assert
            foreach (var animal in _target)
            {
                Assert.AreEqual("Moew!!!!", animal.MakeSound());
            }

        }

        [Test]
        public void ToString_ReturnsAllDataAboutAnimal()
        {
            //Arrange
            _target.Add(new Cat("Gray", "Cat", 8.5, 0, "Home", "BritishBlue"));
            var food = new List<Food>();
            food.Add(new Vegetable(3));

            //Act
            foreach (var animal in _target)
            {
                animal.EatFood(food.Last());
            }

            //Assert
            foreach (var animal in _target)
            {
                Assert.AreEqual("Cat [Gray, 8.5,BritishBlue, Home, 3]", animal.ToString());
            }

        }

        [Test]
        public void EatFood_EatsWrongFood3_Returns0()
        {
            //Arrange
            _target.Add(new Zebra("Stripes", "Zebra", 200.54, 0, "Africa"));
            var food = new List<Food>();
            food.Add(new Meat(3));

            //Act
            foreach (var animal in _target)
            {
                animal.EatFood(food.Last());
            }

            //Assert
            foreach (var animal in _target)
            {
                Assert.AreEqual(0, animal.foodEaten);
            }

        }
    }
}