namespace Calculator.TwoArgumets
{
    class Multiplication : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
