using System;

namespace Calculator.OneArgument
{
    public class Tg : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Tan(Argument);
        }
    }
}
