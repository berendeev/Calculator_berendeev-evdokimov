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
            switch (((Button)sender).Name)
            {
                case "btn_Plus":
                    lbl_Equally.Text = Convert.ToString(numberOne + numberTwo);
                break;
                case "btn_Minus":
                    lbl_Equally.Text = Convert.ToString(numberOne - numberTwo);
                break;
                case "btn_Multiply":
                    lbl_Equally.Text = Convert.ToString(numberOne * numberTwo);
                break;
                case "btn_Divide":
                    lbl_Equally.Text = Convert.ToString(numberOne / numberTwo);
                break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
