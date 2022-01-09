using NUnit.Framework;
using Exercise6;

namespace Exercise6.Tests
{
    public class Tests
    {
        private Exercise6Array _target;
        [SetUp]
        public void Setup()
        {
             _target = new Exercise6Array();
        }

        [Test]
        public void MakeArray1_LengthShouldBe10()
        {
            //Act
            var result = _target.MakeArray1();

            //Assert
            Assert.AreEqual(10, result.Length);
        }

        [Test]
        public void MakeArray2_LengthShouldBe10()
        {
            //Act
            var result = _target.MakeArray2();

            //Assert
            Assert.AreEqual(10, result.Length);
        }

        [Test]
        public void ChangeArray_Given7_LastElementShouldBe7()
        {
            //Act
            var arr = _target.MakeArray1();
            var result = _target.ChangeArray(arr);

            //Assert
            Assert.AreEqual(-7, result[9]);
        }
    }
}