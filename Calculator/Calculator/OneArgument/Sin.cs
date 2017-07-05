using System;

namespace Calculator.OneArgument
{
    public class Sin : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Sin(Argument);
        }
    }
}
