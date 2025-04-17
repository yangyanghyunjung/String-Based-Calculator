using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace winformCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadControl(new CalculatorControl());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbxMode.BackColor = Color.Gray;
        }

        private UserControl currentControl = null;

        private void LoadControl(UserControl newControl)
        {
            if (currentControl != null)
            {
                panelContent.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            currentControl = newControl;
            newControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(newControl);
        }

        private void btnCalculateMode_CheckedChanged(object sender, EventArgs e)
        {
            LoadControl(new CalculatorControl());
        }

        private void btnConvertMode_CheckedChanged(object sender, EventArgs e)
        {
            LoadControl(new ConverterControl());
        }

        private void cbxMode_CheckedChanged(object sender, EventArgs e)
        {
            //cbxMode.FlatAppearance.BorderSize = 0;
            cbxMode.BackColor = Color.Gray;
            //cbxMode.FlatAppearance.BorderColor = cbxMode.BackColor;
            cbxConvertMode.BackColor = SystemColors.Control;
            LoadControl(new CalculatorControl());
        }

        private void cbxConvertMode_CheckedChanged(object sender, EventArgs e)
        {
            //cbxConvertMode.FlatAppearance.BorderSize = 0;
            cbxConvertMode.BackColor = Color.Gray;
            //cbxConvertMode.FlatAppearance.BorderColor = cbxConvertMode.BackColor;
            cbxMode.BackColor = SystemColors.Control;
            LoadControl(new ConverterControl());
        }
    }
}
