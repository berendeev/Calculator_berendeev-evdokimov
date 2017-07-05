using System;

namespace Calculator.OneArgument
{
    public class Square : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Pow(Argument, 2);
        }
    }
}
