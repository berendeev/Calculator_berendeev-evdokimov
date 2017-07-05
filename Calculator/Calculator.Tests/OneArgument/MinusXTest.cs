using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class MinusXTest
    {

        [TestCase(10,-10)]
        [TestCase(0, 0)]
        [TestCase(-2, 2)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculate = new MinusX();
            double result = calculate.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
