using NUnit.Framework;
using code_challenge.Challenges;
using System;

namespace code_challenge.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {
        readonly Calculator calculator = new Calculator();

        [Test()]
        public void TestAddition()
        {
            Assert.AreEqual(4, calculator.Add(2, 2));
        }

        [Test()]
        public void TestSubtraction()
        {
            Assert.AreEqual(2, calculator.Subtract(4, 2));
        }

        [Test()]
        public void TestMultiplication()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
        }

        [Test()]
        public void TestDivision()
        {
            Assert.AreEqual(2, calculator.Divide(6, 3));
        }

    }
}
