using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgumets;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class AdditionTest
    {
        [Test]
        public void CalculateTest()
        {
           IOperationsForTwoArguments calculate = new Addition();
            double result = calculate.Calculate(1, 2);
            Assert.AreEqual(3,result);
        }
    }
}
