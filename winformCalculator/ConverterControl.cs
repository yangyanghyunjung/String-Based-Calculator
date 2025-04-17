using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformCalculator
{
    public partial class ConverterControl : UserControl
    {
        public ConverterControl()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch(cmbConvertType.SelectedIndex)
            {
                case (int)EConvertType.BINARY_TO_DECIMAL:
                    txtNum.Text =  Calculator.ToDecimal(txtNum.Text);
                    break;
                case (int)EConvertType.BINARY_TO_HEX:
                    txtNum.Text = Calculator.ToHex(txtNum.Text);
                    break;
                case (int)EConvertType.DECIMAL_TO_BINARY:
                    txtNum.Text = Calculator.ToBinary(txtNum.Text);
                    break;
                case (int)EConvertType.DECIMAL_TO_HEX:
                    txtNum.Text = Calculator.ToHex(txtNum.Text);
                    break;
                case (int)EConvertType.HEX_TO_BINARY:
                    txtNum.Text = Calculator.ToBinary(txtNum.Text);
                    break;
                case (int)EConvertType.HEX_TO_DECIMAL:
                    txtNum.Text = Calculator.ToDecimal(txtNum.Text);
                    break;
                default:
                    txtNum.Text = "error";
                    break;

            }

        }

     
    }
}
