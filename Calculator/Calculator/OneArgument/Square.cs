using System;

namespace Calculator.OneArgument
{
    class Square : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Pow(Argument, 2);
        }
    }
}
