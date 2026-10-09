
using System.Globalization;
using Backend;

namespace Frontend.Windows
{
    public partial class Form1 : Form
    {
        private string expression = string.Empty;
        private bool showingResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object? sender, EventArgs e)
        {
            Append("0");
        }

        private void btn1_Click(object? sender, EventArgs e)
        {
            Append("1");
        }

        private void btn2_Click(object? sender, EventArgs e)
        {
            Append("2");
        }

        private void btn3_Click(object? sender, EventArgs e)
        {
            Append("3");
        }

        private void btn4_Click(object? sender, EventArgs e)
        {
            Append("4");
        }

        private void btn5_Click(object? sender, EventArgs e)
        {
            Append("5");
        }

        private void btn6_Click(object? sender, EventArgs e)
        {
            Append("6");
        }

        private void btn7_Click(object? sender, EventArgs e)
        {
            Append("7");
        }

        private void btn8_Click(object? sender, EventArgs e)
        {
            Append("8");
        }

        private void btn9_Click(object? sender, EventArgs e)
        {
            Append("9");
        }

        private void btnDot_Click(object? sender, EventArgs e)
        {
            Append(".");
        }

        private void btnOpenParenthesis_Click(object? sender, EventArgs e)
        {
            Append("(");
        }

        private void btnCloseParenthesis_Click(object? sender, EventArgs e)
        {
            Append(")");
        }

        private void btnMultiple_Click(object? sender, EventArgs e)
        {
            Append("*");
        }

        private void btnDivide_Click(object? sender, EventArgs e)
        {
            Append("/");
        }

        private void btnPlus_Click(object? sender, EventArgs e)
        {
            Append("+");
        }

        private void btnMinus_Click(object? sender, EventArgs e)
        {
            Append("-");
        }

        private void btnPotencia_Click(object? sender, EventArgs e)
        {
            Append("^");
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            expression = string.Empty;
            showingResult = false;
            ShowExpression();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (showingResult)
            {
                expression = string.Empty;
                showingResult = false;
            }
            else if (expression.Length > 0)
            {
                expression = expression[..^1];
            }
            ShowExpression();
        }

        private void btnResult_Click(object? sender, EventArgs e)
        {
            if (expression.Length == 0 || showingResult)
            {
                return;
            }
            try
            {
                var value = ExpressionEvaluator.Evalute(expression);
                if (!double.IsFinite(value))
                {
                    throw new Exception("Invalid result.");
                }
                var result = value.ToString(CultureInfo.InvariantCulture);
                lblDisplay.BackColor = Color.Green;
                lblDisplay.Text = $"{expression}={result}";
                expression = result;
                showingResult = true;
            }
            catch
            {
                expression = string.Empty;
                showingResult = false;
                lblDisplay.BackColor = Color.Firebrick;
                lblDisplay.Text = "Error";
            }
        }

        private void Append(string text)
        {
            if (showingResult)
            {
                var continuesWithResult = text is "+" or "-" or "*" or "/" or "^";
                if (!continuesWithResult)
                {
                    expression = string.Empty;
                }
                showingResult = false;
            }
            expression += text;
            ShowExpression();
        }

        private void ShowExpression()
        {
            lblDisplay.BackColor = Color.Green;
            lblDisplay.Text = expression;
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {

        }

        private void btn2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOpenParenthesis_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCloseParenthesis_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPotencia_Click_1(object sender, EventArgs e)
        {

        }

        private void btnResult_Click_1(object sender, EventArgs e)
        {

        }

        private void btn0_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDot_Click_1(object sender, EventArgs e)
        {

        }
    }
}