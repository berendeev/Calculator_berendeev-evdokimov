using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate Square(X)
    /// </summary>
    public class Square : IOperationsForOneArgument
    {
        /// <summary>
        /// For calculate Square(X)
        /// </summary>
        /// <param name="Argument"> Number </param>
        /// <returns> Square(Argument) </returns>
        public double Calculate(double Argument)
        {
            return Math.Pow(Argument, 2);
        }
    }
}
