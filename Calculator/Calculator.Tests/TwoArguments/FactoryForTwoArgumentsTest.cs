using System;
using Calculator.TwoArgumets;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    class FactoryForTwoArgumentsTest
    {
        [TestCase("btn_Divide", typeof(Division))]
        [TestCase("btn_PowerXY", typeof(PowerXY))]
        [TestCase("btn_LogxY", typeof(LogxY))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = FactoryForTwoArguments.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
