using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IOperationsForTwoArguments calculator = FactoryForTwoArguments.CreateCalculator(((Button)sender).Name);
            lbl_Equally.Text = Convert.ToString(calculator.Calculate(numberOne, numberTwo));
            
        }

        private void calculateForOneArgument(object sender, EventArgs e)
        {
            double argument = Convert.ToDouble(tb_InputOne.Text);
            IOperationsForOneArgument calculator = FactoryForOneArgument.CreateCalculator(((Button)sender).Name);
            lbl_Equally.Text = Convert.ToString(calculator.Calculate(argument));
        }
    }

}
