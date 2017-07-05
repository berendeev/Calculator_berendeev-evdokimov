using System;
using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class DivisionTest
    {
        [TestCase(8, 2, 4)]
        [TestCase(48, 48, 1)]
        [TestCase(8, 4, 2)]
        public void CalculateTest(double firstArgument, double seconArgument, double expected)
        {
            
            IOperationsForTwoArguments calculator = new Division();
            double result = calculator.Calculate(firstArgument, seconArgument);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void DivisionByZeroTest()
        {
            Assert.Throws<Exception>(() => FactoryForTwoArguments.CreateCalculator("WrongOperation"));

        }
    }
}
