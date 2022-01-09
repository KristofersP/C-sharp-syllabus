using NUnit.Framework;

namespace Account.Tests
{
    public class Tests
    {
        private Account _target;
        private Account _target1;
        private static Program _target2;

        [SetUp]
        public void Setup()
        {
            _target = new Account("Jarvis", 150m);
            _target1 = new Account("Bob", 200m);
            _target2 = new Program();
        }

        [Test]
        public void WithDraw_Withdraw50_ShouldReturn100()
        {
            //Act
            var result = _target.Withdrawal(50);

            //Assert
            Assert.AreEqual(100, result);
        }

        [Test]
        public void Deposit_Deposit50_ShouldReturn200()
        {
            //Act
            var result = _target.Deposit(50m);

            //Assert
            Assert.AreEqual(200, result);
        }

        [Test]
        public void Balance_ShouldReturn150()
        {
            //Act
            var result = _target.Balance();

            //Assert
            Assert.AreEqual(150, result);
        }

        [Test]
        public void ToString_ShouldReturnNameAndBalance()
        {
            //Act
            var result = _target.ToString();

            //Assert
            Assert.AreEqual("Jarvis: 150", result);
        }

        [Test]
        public void Transfer_Tranfer50FromJarvisToBob_ShouldReturnJarvis100Bob250()
        {
            //Act
            _target2.Transfer(_target, _target1, 50m);

            //Assert
            Assert.AreEqual("Jarvis: 100 Bob: 250", $"{_target.ToString()} {_target1.ToString()}");
        }
    }
}