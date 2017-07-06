namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For link all calculate
    /// </summary>
    public interface IOperationsForTwoArguments
    {
        /// <summary>
        /// Abstract method for calculate
        /// </summary>
        /// <param name="firstArgumen"> first number </param>
        /// <param name="seconArgument"> secon number </param>
        /// <returns></returns>
        double Calculate(double firstArgumen, double seconArgument);
    }
}
