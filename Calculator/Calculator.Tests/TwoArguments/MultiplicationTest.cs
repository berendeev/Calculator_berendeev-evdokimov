using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class MultiplicationTest
    {
        [TestCase(2, 2, 4)]
        [TestCase(5, 2, 10)]
        [TestCase(9, 4, 36)]
        public void CalculateTest(double firstArgument, double seconArgument, double expected)
        {
            {
                IOperationsForTwoArguments calculator = new Multiplication();
                double result = calculator.Calculate(firstArgument, seconArgument);
                Assert.AreEqual(expected, result);

            }
        }
    }
}
