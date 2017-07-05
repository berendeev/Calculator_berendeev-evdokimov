using System;

namespace Calculator.OneArgument
{
    public class ExpX : IOperationsForOneArgument

    {
        public double Calculate(double Argument)
        {
            return Math.Exp(Argument);
        }
    }
}
