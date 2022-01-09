using NUnit.Framework;
using CheckOddEven;

namespace Exercise2.Tests
{
    public class Tests
    {
        private Programm _target;

        [SetUp]
        public void Setup()
        {
            _target = new Programm();
        }

        [Test]
        public void IsNumberEven_NumberIsEven_ReturnsTrue()
        {
            //Arrange
            int number = 56;

            //Act
            var result = _target.IsNumberEven(number);

            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsNumberEven_NumberIsNotEven_ReturnsFalse()
        {
            //Arrange
            int number = 55;

            //Act
            var result = _target.IsNumberEven(number);

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}