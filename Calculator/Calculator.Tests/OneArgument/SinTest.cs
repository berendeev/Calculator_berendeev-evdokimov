using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class SinTest
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.84)]
        [TestCase(0.5, 0.47)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculator = new Sin();
            var result = calculator.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

