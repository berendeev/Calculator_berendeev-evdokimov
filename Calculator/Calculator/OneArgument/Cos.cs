using System;

namespace Calculator.OneArgument
{
    public class Cos : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Cos(Argument);
        }
    }
}
