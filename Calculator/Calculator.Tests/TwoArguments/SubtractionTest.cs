using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class SubtractionTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(7, 4, 3)]
        [TestCase(15, 4, 11)]
        public void CalculateTest(double firstArgument, double seconArgument, double expected)
        {
            IOperationsForTwoArguments calculator = new Subtraction();
            double result = calculator.Calculate(firstArgument, seconArgument);
            Assert.AreEqual(expected, result);
        }
    }
}
