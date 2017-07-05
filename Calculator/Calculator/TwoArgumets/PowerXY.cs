using System;

namespace Calculator.TwoArgumets
{
    public class PowerXY : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
