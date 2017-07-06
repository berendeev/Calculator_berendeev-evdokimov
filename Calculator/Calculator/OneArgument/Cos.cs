using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculation Cos
    /// </summary>
    public class Cos : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculation Cos
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns>Cos(Argumet)</returns>
        public double Calculate(double Argument)
        {
            return Math.Cos(Argument);
        }
    }
}
