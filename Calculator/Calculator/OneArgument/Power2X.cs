using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate Power(2, x)
    /// </summary>
    public class Power2X : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculate Power(2, x)
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns>Power(2, Argument)</returns>
        public double Calculate(double Argument)
        {
           return Math.Pow(2, Argument);
        }
    }
}
