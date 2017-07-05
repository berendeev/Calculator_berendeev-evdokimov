using System;

namespace Calculator.OneArgument
{
    public class Ln : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Log(Argument, Math.E);
        }
    }
}
