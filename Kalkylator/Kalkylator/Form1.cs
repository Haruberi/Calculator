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
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void num01_Click(object sender, EventArgs e)
        {
            if (showNumberBox.Text == "0")
                showNumberBox.Clear();
            Button button=(Button)sender;
            showNumberBox.Text = showNumberBox.Text + button.Text;
        }
    }
}
