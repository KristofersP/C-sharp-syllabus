using NUnit.Framework;
using System.Collections.Generic;

namespace DragRace.Tests
{
    public class Tests
    {
        private List<ICar> cars = new List<ICar>();

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void SpeedUp_ShouldReturn10()
        {
            //Arrange
            cars.Add(new Audi());

            //Act
            foreach (var car in cars)
            {
                car.SpeedUp();
            }

            //Assert
            foreach (var car in cars)
            {
                Assert.AreEqual("10", car.ShowCurrentSpeed());
            }
            
        }

        [Test]
        public void SlowDown_ShouldReturn10()
        {
            //Arrange
            cars.Add(new Audi());

            //Act
            foreach (var car in cars)
            {
                car.SpeedUp();
                car.SpeedUp();
                car.SlowDown();
            }

            //Assert
            foreach (var car in cars)
            {
                Assert.AreEqual("10", car.ShowCurrentSpeed());
            }

        }

        [Test]
        public void StartEngine_ShouldReturnRrrrrrr()
        {
            //Arrange
            cars.Add(new Audi());

            //Assert
            foreach (var car in cars)
            {
                Assert.AreEqual("Rrrrrrr.....", car.StartEngine());
            }

        }

        [Test]
        public void UseNitrousOxideEngine_ShouldReturn30()
        {
            //Arrange
            cars.Add(new Lexus());

            //Act
            foreach (var car in cars)
            {
                ((IBoostable)car).UseNitrousOxideEngine();
            }

            //Assert
            foreach (var car in cars)
            {
                Assert.AreEqual("30", car.ShowCurrentSpeed());
            }

        }
    }
}