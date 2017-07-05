using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class Log10Test
    {
        [TestCase(10, 1)]
        [TestCase(1, 0)]
        [TestCase(3, 0.47)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculator = new Log10();
            double result = calculator.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
