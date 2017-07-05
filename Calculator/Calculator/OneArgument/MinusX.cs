using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgument
{
    public class MinusX : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return -Argument;
        }
    }
}
