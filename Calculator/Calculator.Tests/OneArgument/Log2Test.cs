using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class Log2Test
    {
        [TestCase(10, 3.32)]
        [TestCase(1, 0)]
        [TestCase(2,1)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculate = new Log2();
            double result = calculate.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
