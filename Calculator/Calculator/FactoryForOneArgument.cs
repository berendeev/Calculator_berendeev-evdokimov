using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FactoryForOneArgument
    {
        public static IOperationsForOneArgument CreateCalculator(string name)
        {
            switch(name)
            {
                case "btn_Pow2X":
                    return new Power2X();
                case "btn_Square":
                    return new Square();
                case "btn_Sin":
                    return new Sin();
                case "btn_Cos":
                    return new Cos();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
