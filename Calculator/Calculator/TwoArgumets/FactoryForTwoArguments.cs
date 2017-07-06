using System;

namespace Calculator.TwoArgumets
{
    /// <summary>
    /// For creat calculator
    /// </summary>
    public class FactoryForTwoArguments
    {
        /// <summary>
        /// For creat calculator
        /// </summary>
        /// <param name="name">Name of button</param>
        /// <returns>Class of the required calculator</returns>
        public static IOperationsForTwoArguments CreateCalculator(string name)
        {
            switch (name)
            {
                case "btn_Plus":
                    return new Addition();
                case "btn_Minus":
                    return new Subtraction();
                case "btn_Multiply":
                    return new Multiplication();
                case "btn_Divide":
                    return new Division();
                case "btn_PowerXY":
                    return new PowerXY();
                case "btn_PowerXrevY":
                    return new PowerXrevY();
                case "btn_LogxY":
                    return new LogxY();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
