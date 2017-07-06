using System;

namespace Calculator.TwoArgumets
{
    public class LogxY : IOperationsForTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument <= 0)
            {
                throw new Exception("Некорректный аргумент");
            }
            if ((firstArgument == 1) || (firstArgument <= 0))
            {
                throw new Exception("Некорректное основание");
            }
            return Math.Log(secondArgument, firstArgument);
        }
    }
}
