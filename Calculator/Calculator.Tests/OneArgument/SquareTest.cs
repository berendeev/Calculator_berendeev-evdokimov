using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class SquareTest
    {
        [TestCase(2, 4)]
        [TestCase(5, 25)]
        [TestCase(6, 36)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculator = new Square();
            var result = calculator.Calculate(Argument);
            Assert.AreEqual(expected, result);
        }
    }
}
