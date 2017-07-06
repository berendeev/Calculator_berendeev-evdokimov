namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For calculate multiplication
    /// </summary>
    public class Multiplication : IOperationsForTwoArguments
    {
        /// <summary>
        /// For calculate multiplication
        /// </summary>
        /// <param name="firstArgument"> first number </param>
        /// <param name="secondArgument"> secon number </param>
        /// <returns> firstArgument * secondArgument </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
