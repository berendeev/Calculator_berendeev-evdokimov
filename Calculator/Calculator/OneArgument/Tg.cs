using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate Tg(X)
    /// </summary>
    public class Tg : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculate tg(X)
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns> tg(Argument) </returns>
        public double Calculate(double Argument)
        {
            return Math.Tan(Argument);
        }
    }
}
