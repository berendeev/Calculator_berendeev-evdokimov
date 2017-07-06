using System;

namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For calculate Power(X, Y)
    /// </summary>
    public class PowerXY : IOperationsForTwoArguments
    {
        /// <summary>
        /// For calculate Power(X, Y)
        /// </summary>
        /// <param name="firstArgument"> first number </param>
        /// <param name="secondArgument"> secon number </param>
        /// <returns> Pow(firstArgument, secondArgument) </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
