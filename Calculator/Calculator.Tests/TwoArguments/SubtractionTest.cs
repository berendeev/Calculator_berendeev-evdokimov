using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class SubtractionTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(7, 4, 3)]
        [TestCase(15, 4, 11)]
        public void CalculateTest(double firstArgumen, double seconArgument, double expected)
        {
            IOperationsForTwoArguments calculator = new Subtraction();
            double result = calculator.Calculate(firstArgumen, seconArgument);
            Assert.AreEqual(expected, result);
        }
    }
}
