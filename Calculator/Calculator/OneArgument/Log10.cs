using System;

namespace Calculator.OneArgument
{
    public class Log10 : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Log10(Argument);
        }
    }
}
