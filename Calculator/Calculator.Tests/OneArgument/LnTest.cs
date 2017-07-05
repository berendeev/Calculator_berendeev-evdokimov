using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class LnTest
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.69)]
        [TestCase(Math.E, 1)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculator = new Ln();
            double result = calculator.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
