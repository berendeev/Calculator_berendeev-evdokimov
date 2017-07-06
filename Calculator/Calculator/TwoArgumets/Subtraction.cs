namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For calculate subtraction
    /// </summary>
    public class Subtraction : IOperationsForTwoArguments
    {
        /// <summary>
        /// For calculate subtraction
        /// </summary>
        /// <param name="firstArgument"> first number </param>
        /// <param name="secondArgument"> secon number </param>
        /// <returns> firstArgument - secondArgument </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
