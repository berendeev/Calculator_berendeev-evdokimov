using System;

namespace Calculator.OneArgument
{
    public class Arccos : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Acos(Argument);
        }
    }
}
