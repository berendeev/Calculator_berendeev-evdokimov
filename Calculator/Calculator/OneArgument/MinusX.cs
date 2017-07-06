namespace Calculator.OneArgument
{
    /// <summary>
    /// For calculate -x
    /// </summary>
    public class MinusX : IOperationsForOneArgument
    {
         /// <summary>
         /// For calculate -x
         /// </summary>
         /// <param name="Argument"> Number </param>
         /// <returns>-(Argument)</returns>
        public double Calculate(double Argument)
        {
            return -Argument;
        }
    }
}
