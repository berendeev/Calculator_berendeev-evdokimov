using System;

namespace Calculator.OneArgument
{
    public class Log2 : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Log(Argument, 2);
        }
    }
}
