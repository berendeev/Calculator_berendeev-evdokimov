using System;

namespace Calculator.OneArgument
{
    class Cos : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Cos(Argument);
        }
    }
}
