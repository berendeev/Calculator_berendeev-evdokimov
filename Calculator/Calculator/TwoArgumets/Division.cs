namespace Calculator.TwoArgumets
{
    class Division : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
