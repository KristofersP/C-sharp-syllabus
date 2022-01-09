using NUnit.Framework;

namespace Exercise5.Tests
{
    public class Tests
    {
        private Date _target;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void DisplayDate_Date532_ShouldReturn532()
        {
            //Arrange
            var expected = "3/2/5";
            _target = new Date(5, 3, 2);
            //Act
            var result = _target.DisplayDate();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DisplayDate_DateNegative532_ShouldReturn111()
        {
            //Arrange
            var expected = "1/1/1";
            _target = new Date(-5, -3, -2);
            //Act
            var result = _target.DisplayDate();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}