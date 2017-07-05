namespace Calculator.TwoArgumets
{
    public class Subtraction : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
