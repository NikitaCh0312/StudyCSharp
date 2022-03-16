using Moq;
using NUnit.Framework;
using NUnitApplication;

namespace NUnitTests
{
    [TestFixture]
    public class CaclulatorTests
    {
        [TestCase]
        public void AdditionTest()
        {
            Mock<ICreator> mock = new Mock<ICreator>();
            mock.Setup(s => s.GetSubstractor()).Returns(new Substractor());
            Calculator calc = new Calculator(mock.Object);
            var res = calc.Add(10, 5);
            Assert.AreEqual(res, 15);
            Assert.AreNotEqual(res, 16);
        }
        [TestCase]
        public void SubstractionTest()
        {
            //var mock = new Mock<ISubstractor>();
            //mock.Setup(s => s.Subsctract(5, 10)).Returns(10);
            //Calculator calc = new Calculator(mock.Object);
            //Assert.AreEqual(calc.Substract(10, 5), 10);
            //Assert.AreNotEqual(calc.Substract(10, 5), 10);
        }
    }
}
