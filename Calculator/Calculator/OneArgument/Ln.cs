using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate Ln
    /// </summary>
    public class Ln : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculate Ln
        /// </summary>
        /// <param name="Argument">Number</param>
        /// <returns>ln(Argument)</returns>
        public double Calculate(double Argument)
        {
            return Math.Log(Argument, Math.E);
        }
    }
}
