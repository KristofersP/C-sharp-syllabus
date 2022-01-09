using NUnit.Framework;

namespace Exercise1.Tests
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
        public void CheckNumber15_InputIs15_ReturnsTrue()
        {
            //Arrange
            int num1 = 15;
            int num2 = 3;

            //Act
            var result = _target.CheckNumber15(num1, num2);

            //Assert

            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckNumber15_InputIsNot15_ReturnsFalse()
        {
            //Arrange
            int num1 = 14;
            int num2 = 3;

            //Act
            var result = _target.CheckNumber15(num1, num2);

            //Assert

            Assert.AreEqual(false, result);
        }

        [Test]
        public void CheckNumber15_SumIs15_ReturnsTrue()
        {
            //Arrange
            int num1 = 12;
            int num2 = 3;

            //Act
            var result = _target.CheckNumber15(num1, num2);

            //Assert

            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckNumber15_SubtractionIs15_ReturnsTrue()
        {
            //Arrange
            int num1 = 29;
            int num2 = 14;

            //Act
            var result = _target.CheckNumber15(num1, num2);

            //Assert

            Assert.AreEqual(true, result);
        }
    }
}