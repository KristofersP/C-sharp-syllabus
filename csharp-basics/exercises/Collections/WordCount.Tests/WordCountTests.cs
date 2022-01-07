using NUnit.Framework;
using WordCount;

namespace WordCount.Tests
{
    public class Tests
    {
        private Program _target;
        //public string text = System.IO.File.ReadAllText("../../lear.txt");

        [SetUp]
        public void Setup()
        {
            _target = new Program();
        }

        [Test]
        public void WordCount_5Words_Returns5()
        {
            //Arrange
            string text = "Word count should be 5";

            //Act
            var result = _target.WordCount(text);

            //Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CharCount_22Characters_Returns22()
        {
            //Arrange
            string text = "Word count should be 5";

            //Act
            var result = _target.CharCount(text);

            //Assert
            Assert.AreEqual(22, result);
        }

        [Test]
        public void LineCount_3Lines_Returns3()
        {
            //Arrange
            string text = "Word count should be 5 \n second line \n third line";

            //Act
            var result = _target.LineCount(text);

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}