using System;

namespace Calculator.OneArgument
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
                case "btn_Tg":
                    return new Tg();
                case "btn_Arcsin":
                    return new Arcsin();
                case "btn_Arccos":
                    return new Arccos();
                case "btn_Arctg":
                    return new Arctg();
                case "btn_ExpX":
                    return new ExpX();
                case "btn_Ln":
                    return new Ln();
                case "btn_Log2":
                    return new Log2();
                case "btn_Log10":
                    return new Log10();
                case "btn_MinusX":
                    return new MinusX();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
