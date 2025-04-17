using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformCalculator
{
    public partial class ToggleButton : UserControl
    {
        private void ToggleButton_Load(object sender, EventArgs e)
        {

        }

        private bool isToggled = false;

        public bool IsToggled
        {
            get => isToggled;
            set
            {
                isToggled = value;
                Invalidate(); // 다시 그리기
            }
        }

        public event EventHandler ToggleChanged;

        public ToggleButton()
        {
            InitializeComponent();
            this.Size = new Size(60, 30);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color backColor = isToggled ? Color.MediumSeaGreen : Color.Gray;
            Color knobColor = Color.White;

            g.FillRectangle(new SolidBrush(backColor), 0, 0, Width, Height);

            int knobX = isToggled ? Width - Height : 0;
            g.FillEllipse(new SolidBrush(knobColor), knobX, 0, Height, Height);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            IsToggled = !IsToggled;
            ToggleChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
