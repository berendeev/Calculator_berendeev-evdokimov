using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class CosTest
    {
        [TestCase(1, 0.54)]
        [TestCase(0, 1)]
        [TestCase(0.5, 0.87)]
        public void CalculateTest(double Argument, double expected)
        {
            var  calculate = new Cos();
            double result = calculate.Calculate(Argument);
            Assert.AreEqual(expected, result, 0.01);
        }

    }
}
