using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class TgTest
    {
        [TestCase(0.5, 0.54)]
        [TestCase(1, 1.55)]
        [TestCase(0, 0)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculate = new Tg();
            double result = calculate.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
