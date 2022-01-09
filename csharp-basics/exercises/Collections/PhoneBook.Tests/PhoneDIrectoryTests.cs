using NUnit.Framework;

namespace PhoneBook.Tests
{
    public class Tests
    {
        private PhoneDirectory _target;

        [SetUp]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [Test]
        public void PutNumber_janis123123_ShouldContainJanis()
        {
            //Act
            _target.PutNumber("janis", "123123");

            //Assert
            Assert.AreEqual("123123", _target.GetNumber("janis"));
        }

        [Test]
        public void PutNumber_janis123123_ShouldBeNull()
        {
            //Act
            _target.PutNumber("janis", "123123");

            //Assert
            Assert.AreEqual(null, _target.GetNumber("davis"));
        }
    }
}