using NUnit.Framework;
using CalculateArea;
using System;

namespace CalculateArea.Tests
{
    public class Tests
    {
        private Geometry _target;

        [SetUp]
        public void Setup()
        {
            _target = new Geometry();
        }

        [Test]
        public void AreaOfCircle_InputIs5_Returns3142()
        {
            //Arrange
            decimal radius = 5m;

            //Act
            var result  = _target.AreaOfCircle(radius);

            //Assert
            Assert.AreEqual(31.42, Math.Round(result, 2));
        }

        [Test]
        public void AreaOfRectangle_InputIs5And10_Returns3142()
        {
            //Arrange
            decimal width = 5m;
            decimal length = 10m;

            //Act
            var result = _target.AreaOfRectangle(length, width);

            //Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void AreaOfTriangle_InputIs10And14_Returns3142()
        {
            //Arrange
            decimal ground = 10;
            decimal h = 14;

            //Act
            var result = _target.AreaOfTriangle(ground, h);

            //Assert
            Assert.AreEqual(70, Math.Round(result, 2));
        }
    }
}