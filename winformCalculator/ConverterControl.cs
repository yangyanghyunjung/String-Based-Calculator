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
                    txtNum.Text =  Calculator.ToDecimalOrNull(txtNum.Text);
                    break;
                case (int)EConvertType.BINARY_TO_HEX:
                    txtNum.Text = Calculator.ToHexOrNull(txtNum.Text);
                    break;
                case (int)EConvertType.DECIMAL_TO_BINARY:
                    txtNum.Text = Calculator.ToBinaryOrNull(txtNum.Text);
                    break;
                case (int)EConvertType.DECIMAL_TO_HEX:
                    txtNum.Text = Calculator.ToHexOrNull(txtNum.Text);
                    break;
                case (int)EConvertType.HEX_TO_BINARY:
                    txtNum.Text = Calculator.ToBinaryOrNull(txtNum.Text);
                    break;
                case (int)EConvertType.HEX_TO_DECIMAL:
                    txtNum.Text = Calculator.ToDecimalOrNull(txtNum.Text);
                    break;
                default:
                    txtNum.Text = "error";
                    break;

            }

        }

     
    }
}
