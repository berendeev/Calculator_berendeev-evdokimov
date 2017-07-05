using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    class FactoryForOneArgumentTest
    {
        [TestCase("btn_Square", typeof(Square))]
        [TestCase("btn_Sin", typeof(Sin))]
        [TestCase("btn_Arccos", typeof(Arccos))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = FactoryForOneArgument.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
