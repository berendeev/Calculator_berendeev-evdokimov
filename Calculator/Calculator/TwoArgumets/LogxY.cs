using System;

namespace Calculator.TwoArgumets
{
    public class LogxY : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(secondArgument, firstArgument);
        }
    }
}
