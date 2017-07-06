using System;

namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For calculate Logx(Y)
    /// </summary>
    public class LogxY : IOperationsForTwoArguments
    {
        /// <summary>
        /// For calculate Logx(Y)
        /// </summary>
        /// <param name="firstArgument"> first number </param>
        /// <param name="secondArgument"> secon number </param>
        /// <returns> Log(secondArgument, firstArgument) </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument <= 0)
            {
                throw new Exception("Некорректный аргумент");
            }
            if ((firstArgument == 1) || (firstArgument <= 0))
            {
                throw new Exception("Некорректное основание");
            }
            return Math.Log(secondArgument, firstArgument);
        }
    }
}
