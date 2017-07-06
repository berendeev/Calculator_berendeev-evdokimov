using System;

namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For calculate division
    /// </summary>
    public class Division : IOperationsForTwoArguments
    {
        /// <summary>
        /// For calculate division
        /// </summary>
        /// <param name="firstArgument"> first number</param>
        /// <param name="secondArgument"> secon number </param>
        /// <returns> firstArgument / secondArgument </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }

            return firstArgument / secondArgument;
        }
    }
}
