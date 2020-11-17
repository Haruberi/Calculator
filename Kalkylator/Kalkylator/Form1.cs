using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator
{
    public partial class CalculatorForm : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void num01_Click(object sender, EventArgs e)
        {
            if ((showNumberBox.Text == "0") || (isOperationPerformed))
                showNumberBox.Clear();

            isOperationPerformed = false;
            Button button=(Button)sender;
            showNumberBox.Text = showNumberBox.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(showNumberBox.Text);
            labelCurrOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void Cbutton_click(object sender, EventArgs e)
        {
            showNumberBox.Text = "0";
            resultValue = 0;
        }

        private void CEbutton_click(object sender, EventArgs e)
        {
            showNumberBox.Text = "0";
        }

        private void equalbutton_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    showNumberBox.Text = (resultValue + Double.Parse(showNumberBox.Text)).ToString();
                    break;
                case "-":
                    showNumberBox.Text = (resultValue - Double.Parse(showNumberBox.Text)).ToString();
                    break;
                case "*":
                    showNumberBox.Text = (resultValue * Double.Parse(showNumberBox.Text)).ToString();
                    break;
                case "/":
                    showNumberBox.Text = (resultValue / Double.Parse(showNumberBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
