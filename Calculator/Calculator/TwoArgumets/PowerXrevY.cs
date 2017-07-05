using System;

namespace Calculator.TwoArgumets
{
    class PowerXrevY : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
