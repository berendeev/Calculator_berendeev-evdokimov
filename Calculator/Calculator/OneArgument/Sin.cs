using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate Sin(x)
    /// </summary>
    public class Sin : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculate Sin(x)
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns> Sin(Argument) </returns>
        public double Calculate(double Argument)
        {
            return Math.Sin(Argument);
        }
    }
}
