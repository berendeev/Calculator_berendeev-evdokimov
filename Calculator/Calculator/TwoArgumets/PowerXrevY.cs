using System;

namespace Calculator.TwoArgumets
{
    public class PowerXrevY : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
