using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Square : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Pow(Argument, 2);
        }
    }
}
