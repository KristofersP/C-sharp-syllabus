using NUnit.Framework;
using Exercise8;

namespace Exercise8.Tests
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
        public void Payment_InputIsInvalid_Returns0()
        {
            //Arrange
            decimal basePay = 7.50m;
            int hoursWorled = 35;

            //Act
            var result = _target.Payment(basePay, hoursWorled);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Payment_InputIsValid_ReturnsSalary()
        {
            //Arrange
            decimal basePay = 8.20m;
            int hoursWorled = 47;

            //Act
            var result = _target.Payment(basePay, hoursWorled);

            //Assert
            Assert.AreEqual(414.10, result);
        }
    }
}