using NUnit.Framework;
using GravityCalculator;
using System;

namespace GravityCalculator.Tests
{
    public class Tests
    {
        private Program _target;

        [SetUp]
        public void Setup()
        {
            _target = new Program();
        }

        [Test]
        public void CalculateFinalPosition_Gravity981fallingTime10_Returns4905()
        {
            //Arrange
            double gravity = 9.81;
            double fallingTime = 10.0;

            //Act
            var result = _target.CalculateFinalPosition(gravity, fallingTime);

            //Assert
            Assert.AreEqual(490.5, Math.Round(result, 1));
        }
    }
}