using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class ArccosTest
    {
        [TestCase(1,0)]
        [TestCase(-1,Math.PI)]
        [TestCase(0.1, 1.47)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculate = new Arccos();
            double result = calculate.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
