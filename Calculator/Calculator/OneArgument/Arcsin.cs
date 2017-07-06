using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculation Arcsin
    /// </summary>
    public class Arcsin : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculation Arcsin
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns>Arcsin(Argumet)</returns>
        public double Calculate(double Argument)
        {
            return Math.Asin(Argument);
        }
    }
}
