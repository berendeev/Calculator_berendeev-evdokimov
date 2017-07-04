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

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            double numberOne = Convert.ToDouble(tb_InputOne.Text);
            double numberTwo = Convert.ToDouble(tb_InputTwo.Text);
            lbl_Equally.Text = Convert.ToString(numberOne + numberTwo);
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            double numberOne = Convert.ToDouble(tb_InputOne.Text);
            double numberTwo = Convert.ToDouble(tb_InputTwo.Text);
            lbl_Equally.Text = Convert.ToString(numberOne - numberTwo);
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            double numberOne = Convert.ToDouble(tb_InputOne.Text);
            double numberTwo = Convert.ToDouble(tb_InputTwo.Text);
            lbl_Equally.Text = Convert.ToString(numberOne * numberTwo);
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            double numberOne = Convert.ToDouble(tb_InputOne.Text);
            double numberTwo = Convert.ToDouble(tb_InputTwo.Text);
            lbl_Equally.Text = Convert.ToString(numberOne / numberTwo);
        }
    }
}
