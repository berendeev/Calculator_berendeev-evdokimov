using System;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArgumets;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void calculateForTwoArgument(object sender, EventArgs e)
        {
            double numberOne = Convert.ToDouble(tb_InputOne.Text);
            double numberTwo = Convert.ToDouble(tb_InputTwo.Text);
            try
            {
                IOperationsForTwoArguments calculator = FactoryForTwoArguments.CreateCalculator(((Button)sender).Name);
                lbl_Equally.Text = Convert.ToString(calculator.Calculate(numberOne, numberTwo));
            }
            catch (Exception exc)
            {
                lbl_Equally.Text = exc.Message;
            }
            
            
        }

        private void calculateForOneArgument(object sender, EventArgs e)
        {
            double argument = Convert.ToDouble(tb_InputOne.Text);
            IOperationsForOneArgument calculator = FactoryForOneArgument.CreateCalculator(((Button)sender).Name);
            lbl_Equally.Text = Convert.ToString(calculator.Calculate(argument));
        }
    }

}
