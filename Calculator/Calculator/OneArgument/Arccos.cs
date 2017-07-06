using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculation Arccos
    /// </summary>
    public class Arccos : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculation Arccos
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns>Arccos(Argumet)</returns>
        public double Calculate(double Argument)
        {
            return Math.Acos(Argument);
        }
    }
}
