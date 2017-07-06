using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class PowerXYTest
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 1, 3)]
        [TestCase(5, 3, 125)]
        public void CalculateTest(double firstArgument, double seconArgument, double expected)
        {

            IOperationsForTwoArguments calculator = new PowerXY();
            double result = calculator.Calculate(firstArgument, seconArgument);
            Assert.AreEqual(expected, result);
        }
    }
}
