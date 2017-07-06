using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate Lg
    /// </summary>
    public class Log10 : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculate lg
        /// </summary>
        /// <param name="Argument">Number</param>
        /// <returns>lg(Argument)</returns>
        public double Calculate(double Argument)
        {
            return Math.Log10(Argument);
        }
    }
}
