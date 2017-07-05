using System;

namespace Calculator.OneArgument
{
    class Power2X : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
           return Math.Pow(2, Argument);
        }
    }
}
