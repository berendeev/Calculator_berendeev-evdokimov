using System;

namespace Calculator.OneArgument
{
    class Sin : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Sin(Argument);
        }
    }
}
