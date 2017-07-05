using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class ExpXTest
    {
        [TestCase(1, 2.71)]
        [TestCase(5, 148.41)]
        [TestCase(0, 1)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculator = new ExpX();
            double result = calculator.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
