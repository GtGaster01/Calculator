using System;
using System.Windows.Forms;
using NCalc;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isResultDisplayed = false;
        private double StringToDouble(string textValue)
        {

            if (double.TryParse(
                textValue,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double result))
            {
                return result;
            }
            else
            {
                return 0.0;
            }
        }
        #region Clear and Backspace
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string text = txtDisplay.Text;
            if (text.Length > 0)
            {
                txtDisplay.Text = text.Substring(0, text.Length - 1);
            }

        }
        #endregion
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double number = StringToDouble(txtDisplay.Text);
            double result = Math.Sqrt(number);
            double roundedResult = Math.Round((double)result, 4, MidpointRounding.AwayFromZero);
            txtDisplay.Text = Convert.ToDouble(roundedResult).ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            isResultDisplayed = true;
        }

        #region Numbers and Operators
        private void btnDivide_Click(object sender, EventArgs e)
        {
            
            txtDisplay.Text += "/";
            isResultDisplayed = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
            isResultDisplayed = false;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
            isResultDisplayed = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
            isResultDisplayed = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
            isResultDisplayed = false;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
            isResultDisplayed = false;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text = "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtDisplay.Clear();
                isResultDisplayed = false;
            }
            txtDisplay.Text += "9";
        }
        private void btnOpenBrckt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
            isResultDisplayed = false;
        }
        private void btnCloseBrckt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
            isResultDisplayed = false;
        }
        #endregion

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string text= txtDisplay.Text;
            try
            {
                Expression expression = new Expression(text);
                object result = expression.Evaluate();
                double roundedResult = Math.Round((double)result, 4, MidpointRounding.AwayFromZero);
                txtDisplay.Text = Convert.ToDouble(roundedResult).ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in expression: " + ex.Message);
            }
            isResultDisplayed = true;
        }

       
    }
}
