using NUnit.Framework;

namespace Exercise1.Tests
{
    public class Tests
    {
        private Product _target;

        [SetUp]
        public void Setup()
        {
            _target = new Product("mouse", 45.00, 5);
        }

        [Test]
        public void PrintProduct_ShouldPrintProduct()
        {
            //Arrange
            var expected = "mouse, price 45, amount 5";

            //Act
            var result = _target.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ChangeAmount_Amount7_ShouldChangeAmountTo7()
        {
            //Arrange
            var expected = "mouse, price 45, amount 7";

            //Act
            _target.ChangeAmount(7);
            var result = _target.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ChangePrice_Price50_ShouldChangePriceTo50()
        {
            //Arrange
            var expected = "mouse, price 50, amount 5";

            //Act
            _target.ChangePrice(50);
            var result = _target.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}