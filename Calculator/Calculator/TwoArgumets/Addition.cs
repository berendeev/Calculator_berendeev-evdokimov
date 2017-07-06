namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For calculate addition
    /// </summary>
    public class Addition : IOperationsForTwoArguments
    {
        /// <summary>
        /// For calculate addition
        /// </summary>
        /// <param name="firstArgument"> first number </param>
        /// <param name="secondArgument"> second number </param>
        /// <returns> firstArgument + secondArgument </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
