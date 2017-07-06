using System;

namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For calculate Power(X, 1/Y)
    /// </summary>
    public class PowerXrevY : IOperationsForTwoArguments
    {
        /// <summary>
        /// For calculate Power(X, 1/Y)
        /// </summary>
        /// <param name="firstArgument"> first number </param>
        /// <param name="secondArgument"> secon number </param>
        /// <returns> Pow(firstArgument, 1 / secondArgument) </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
