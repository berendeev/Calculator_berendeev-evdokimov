using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class ArctgTest
    {
        [TestCase(0.5, 0.46)]
        [TestCase(1, 0.78)]
        [TestCase(0, 0)]
        public void CalculateTest(double Argument, double expected)
        {
            var calculator = new Arctg();
            double result = calculator.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
