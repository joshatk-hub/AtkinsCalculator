using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace AtkinsCalculator
{
    public partial class Form1 : Form
    {
        private CalcFunctions calc;
        public Form1()
        {
            InitializeComponent();
            calc = new CalcFunctions();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                return; // prevent multiple leading zeros
            }
            else
            {
                calc.InputDigit("0");
                txtDisplay.Text = calc.Display;
            }
        }

        private void btn1_Click(object sender, EventArgs e) // how can i avoid having to use the click event for every single button? it's painful
        {
            calc.InputDigit("1");
            txtDisplay.Text = calc.Display;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calc.InputDigit("2");
            txtDisplay.Text = calc.Display;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calc.InputDigit("3");
            txtDisplay.Text = calc.Display;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calc.InputDigit("4");
            txtDisplay.Text = calc.Display;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calc.InputDigit("5");
            txtDisplay.Text = calc.Display;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calc.InputDigit("6");
            txtDisplay.Text = calc.Display;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calc.InputDigit("7");
            txtDisplay.Text = calc.Display;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calc.InputDigit("8");
            txtDisplay.Text = calc.Display;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calc.InputDigit("9");
            txtDisplay.Text = calc.Display;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            calc.DecimalPoint();
            txtDisplay.Text = calc.Display;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc.Clear();
            txtDisplay.Text = calc.Display;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.SetOperator("+");
            txtDisplay.Text = calc.Display;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calc.SetOperator("-");
            txtDisplay.Text = calc.Display;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calc.SetOperator("*");
            txtDisplay.Text = calc.Display;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calc.SetOperator("/");
            txtDisplay.Text = calc.Display;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calc.Calculate();
            txtDisplay.Text = calc.Display;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            calc.Backspace();
            txtDisplay.Text = calc.Display;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            calc.SquareRoot();
            txtDisplay.Text = calc.Display;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            calc.ChangeSign();
            txtDisplay.Text = calc.Display;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            calc.Reciprocal();
            txtDisplay.Text = calc.Display;
        }
    }
}
