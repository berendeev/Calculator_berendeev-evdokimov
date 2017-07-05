using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class MultiplicationTest
    {
        [TestCase(2, 2, 4)]
        [TestCase(5, 2, 10)]
        [TestCase(9, 4, 36)]
        public void CalculateTest(double firstArgumen, double seconArgument, double expected)
        {
            {
                IOperationsForTwoArguments calculator = new Multiplication();
                double result = calculator.Calculate(firstArgumen, seconArgument);
                Assert.AreEqual(expected, result);

            }
        }
    }
}
