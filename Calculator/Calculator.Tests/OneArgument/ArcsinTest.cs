using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class ArcsinTest
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.57)]
        [TestCase(0.5, 0.52)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculate = new Arcsin();
            double result = calculate.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }

    }
}
