using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FactoryForTwoArguments
    {
        public static IOperationsForTwoArguments CreateCalculator(string name)
        {
            switch (name)
            {
                case "btn_Plus":
                    return new Addition();
                    break;
                case "btn_Minus":
                    return new Subtraction();
                    break;
                case "btn_Multiply":
                    return new Multiplication();
                    break;
                case "btn_Divide":
                    return new Division();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
