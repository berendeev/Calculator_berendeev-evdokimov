using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculation Arctg
    /// </summary>
    public class Arctg : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculation Arctg
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns>Arctg(Argumet)</returns>
        public double Calculate(double Argument)
        {
            return Math.Atan(Argument);
        }
    }
}
