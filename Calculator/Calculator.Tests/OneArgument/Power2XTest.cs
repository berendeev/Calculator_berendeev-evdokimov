using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class Power2XTest
    {
        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculator = new Power2X();
            double result = calculator.Calculate(Argument);
            Assert.AreEqual(expected, result);
        }
    }
}
