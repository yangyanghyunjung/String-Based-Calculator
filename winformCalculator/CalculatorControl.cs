using System;
using System.Windows.Forms;

namespace winformCalculator
{
    public partial class CalculatorControl : UserControl
    {
        public CalculatorControl()
        {
            InitializeComponent();
        }

        private void CalculatorControl_Load(object sender, EventArgs e)
        {
            cmbOperator.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMode selectedEMode = EMode.BINARY;
            if (radioBinaryResultMode.Checked)
            {
                selectedEMode = EMode.BINARY;
            }
            else if (radioDecimalResultMode.Checked)
            {
                selectedEMode = EMode.DECIMAL;
            }
            else
            {
                selectedEMode = EMode.HEX;
            }

            Calculator calculator = new Calculator(100, selectedEMode); //Mode 선택
            bool bOverflow = false;

            switch(cmbOperator.SelectedItem)
            {
                case "+":
                    resultTxt.Text = calculator.Add(txtOperation1.Text, txtOperation2.Text, out bOverflow);
                    break;

                case "-":
                    resultTxt.Text = calculator.Subtract(txtOperation1.Text, txtOperation2.Text, out bOverflow);
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    resultTxt.Text = "error";
                    break;
            }



        }

    }
}
