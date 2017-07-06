using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculation Exp
    /// </summary>
    public class ExpX : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculation Exp
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns> Exp(Argument) </returns>
        public double Calculate(double Argument)
        {
            return Math.Exp(Argument);
        }
    }
}
