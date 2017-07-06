using System;
using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class PowerXrevYTest
    {
        [TestCase(4, 2, 2)]
        [TestCase(25, 2, 5)]
        [TestCase(27, 3, 3)]
        public void CalculateTest(double firstArgument, double seconArgument, double expected)
        {
            {
                IOperationsForTwoArguments calculator = new PowerXrevY();
                double result = calculator.Calculate(firstArgument, seconArgument);
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void PowerDivisionByZeroTest()
        {
            var calculate = new PowerXrevY();
            Assert.Throws<Exception>(() => calculate.Calculate(1, 0));
        }
    }
}
