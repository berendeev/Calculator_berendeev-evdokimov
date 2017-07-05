using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.TwoArgumets
{
    class PowerXY : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
