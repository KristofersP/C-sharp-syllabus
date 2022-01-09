using NUnit.Framework;
using Exercise6;

namespace Exercise6.Tests
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
        public void CheckCozaLozaWoza_IsCozaLozaWoza_ReturnsCozaLozaWoza()
        {
            //Arrange
            int number = 105;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual("CozaLozaWoza" + " ", result);
        }

        [Test]
        public void CheckCozaLozaWoza_IsCozaLoza_ReturnsCozaLoza()
        {
            //Arrange
            int number = 15;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual("CozaLoza" + " ", result);
        }

        [Test]
        public void CheckCozaLozaWoza_IsCozaWoza_ReturnsCozaWoza()
        {
            //Arrange
            int number = 21;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual("CozaWoza" + " ", result);
        }

        [Test]
        public void CheckCozaLozaWoza_IsLozaWoza_ReturnsLozaWoza()
        {
            //Arrange
            int number = 35;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual("LozaWoza" + " ", result);
        }

        [Test]
        public void CheckCozaLozaWoza_IsLoza_ReturnsLoza()
        {
            //Arrange
            int number = 5;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual("Loza" + " ", result);
        }

        [Test]
        public void CheckCozaLozaWoza_IsWoza_ReturnsWoza()
        {
            //Arrange
            int number = 7;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual("Woza" + " ", result);
        }

        [Test]
        public void CheckCozaLozaWoza_IsCoza_ReturnsCoza()
        {
            //Arrange
            int number = 3;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual("Coza" + " ", result);
        }

        [Test]
        public void CheckCozaLozaWoza_NotCozaWozaLoza_ReturnsNumber()
        {
            //Arrange
            int number = 4;

            //Act
            var result = _target.CheckCozaLozaWoza(number);

            //Assert
            Assert.AreEqual(number + " ", result);
        }

        [Test]
        public void CheckNewLine_InputIs11_ReturnsNewLine()
        {
            //Arrange
            int number = 11;

            //Act
            var result = _target.CheckNewLine(number);

            //Assert
            Assert.AreEqual("\n", result);
        }
    }
}