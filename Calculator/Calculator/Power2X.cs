using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Power2X : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
           return Math.Pow(2, Argument);
        }
    }
}
