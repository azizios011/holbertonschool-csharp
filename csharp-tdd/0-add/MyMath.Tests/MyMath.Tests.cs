using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// a test method that tests the adds method.
    /// </summary>
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_PositiveNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            Assert.AreEqual(1, Operations.Add(3, -2));
        }

        [Test]
        public void Add_Zero_ReturnsCorrectSum()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }
    }
}
