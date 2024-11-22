using MathutilCLR;
using System.Diagnostics.Eventing.Reader;

namespace TestApp
{
    public partial class TestAppForm : Form
    {
        //private MathWrapper MathUtilsLib;

        public TestAppForm()
        {
            InitializeComponent();
            //MathWrapper MathUtilsLib = new MathWrapper();
        }

        private void inputBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void inputBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(inputBox1.Text, out double num1) || !double.TryParse(inputBox2.Text, out double num2))
            {
                return;
            }

            var oper = mathOperatorcombobox.SelectedItem.ToString();
            double result = 0.0;
            MathWrapper mathWrapper = new MathWrapper();
            if (oper == "+")
            {
                result = mathWrapper.Add(num1, num2);
            }
            else if(oper == "x")
            { 
            
                result = mathWrapper.Multiply(num1, num2);
            }

            outputBox1.Text = result.ToString();
        }
    }
}
