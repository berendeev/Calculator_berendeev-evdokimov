namespace Calculator.TwoArgumets
{
    public class Addition : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
