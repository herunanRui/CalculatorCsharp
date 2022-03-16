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
        string firstInput = "";
        string secondInput = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void but0_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "0";
            display.Text += userInput;
        }

        private void but00_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "00";
            display.Text += userInput;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "1";
            display.Text += userInput;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "2";
            display.Text += userInput;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "3";
            display.Text += userInput;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "4";
            display.Text += userInput;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "5";
            display.Text += userInput;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "6";
            display.Text += userInput;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "7";
            display.Text += userInput;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "8";
            display.Text += userInput;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "9";
            display.Text += userInput;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            function = '+';
            firstInput = userInput;
            userInput = "";
        }

        private void butSubtract_Click(object sender, EventArgs e)
        {
            function = '-';
            firstInput = userInput;
            userInput = "";
        }

        private void butMultiplication_Click(object sender, EventArgs e)
        {
            function = '*';
            firstInput = userInput;
            userInput = "";
        }

        private void butDivission_Click(object sender, EventArgs e)
        {
            function = '/';
            firstInput = userInput;
            userInput = "";
        }

        private void deci_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += ".";
            display.Text += userInput;
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            secondInput = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(firstInput);
            secondNum = Convert.ToDouble(secondInput);

            if(function== '+')
            {
                result = firstNum + secondNum;
                display.Text = result.ToString();
            }
            else if(function == '-')
            {
                result = firstNum - secondNum;
                display.Text = result.ToString();
            }
            else if(function == '*')
            {
                result = firstNum * secondNum;
                display.Text = result.ToString();
            }
            if (function == '%')
            {
                result = firstNum % secondNum;
                display.Text = result.ToString();
            }
            else if(function == '/')
            {
                if (secondNum != 0)
                {
                    result = firstNum / secondNum;
                    display.Text = result.ToString();
                }
                else
                {
                    display.Text = "INVALID";
                }
                
            }
        }

        private void butPerc_Click(object sender, EventArgs e)
        {
            function = '%';
            firstInput = userInput;
            userInput = "";
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            firstInput = "";
            secondInput = "";
            userInput = "";
            display.Text = "0"; 

        }

        private void display_Click(object sender, EventArgs e)
        {

        }
    }
}
