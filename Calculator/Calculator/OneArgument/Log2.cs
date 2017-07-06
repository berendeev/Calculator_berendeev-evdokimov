using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate Log2
    /// </summary>
    public class Log2 : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculate log2
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns> Log2(Argument)</returns>
        public double Calculate(double Argument)
        {
            return Math.Log(Argument, 2);
        }
    }
}
