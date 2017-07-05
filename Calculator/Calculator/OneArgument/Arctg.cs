using System;

namespace Calculator.OneArgument
{
    public class Arctg : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Atan(Argument);
        }
    }
}
