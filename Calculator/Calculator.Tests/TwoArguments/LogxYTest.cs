using System;
using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class LogxYTest
    {
        [TestCase(2, 8, 3)]
        [TestCase(3, 9, 2)]
        [TestCase(4, 64, 3)]
        public void CalculateTest(double firstArgument, double seconArgument, double expected)
        {
            IOperationsForTwoArguments calculator = new LogxY();
            double result = calculator.Calculate(firstArgument, seconArgument);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void UncorrectLog()
        {
            var calculate = new LogxY();
            Assert.Throws<Exception>(() => calculate.Calculate(2, -1));
        }
    }
}
