using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Sin : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Sin(Argument);
        }
    }
}
