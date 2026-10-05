using Backend;
using System.Globalization;

namespace Frontend.Windows
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private bool _showingError = false;

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "/";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : ".";
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "(";
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : ")";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text += _showingError ? "" : "^";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _showingError = false;
            txtbxOperations.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtbxOperations.Text = !string.IsNullOrEmpty(txtbxOperations.Text) && !_showingError ? txtbxOperations.Text.Substring(0, txtbxOperations.Text.Length - 1) : "";
            if (_showingError) _showingError = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (_showingError) return;

            try
            {
                var result = ExpressionEvaluator.Evaluate(txtbxOperations.Text);
                txtbxOperations.Text = result.ToString("N5");
            }
            catch (Exception ex)
            {
                _showingError = true;
                txtbxOperations.Text = ex.Message;
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}