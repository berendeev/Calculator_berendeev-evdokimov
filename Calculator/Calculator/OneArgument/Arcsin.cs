﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgument
{
    class Arcsin : IOperationsForOneArgument
    {
        public double Calculate(double Argument)
        {
            return Math.Asin(Argument);
        }
    }
}