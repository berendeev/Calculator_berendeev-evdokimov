using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void calculation(object sender, EventArgs e)
        {
            double numberOne = Convert.ToDouble(tb_InputOne.Text);
            double numberTwo = Convert.ToDouble(tb_InputTwo.Text);
            IOperations calculator = Factory.CreateCalculator(((Button)sender).Name);
            lbl_Equally.Text = Convert.ToString(calculator.Calculate(numberOne, numberTwo));
            
        }
    }

}
