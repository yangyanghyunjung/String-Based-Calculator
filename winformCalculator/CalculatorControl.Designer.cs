namespace winformCalculator
{
    partial class CalculatorControl
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtOperation1 = new System.Windows.Forms.TextBox();
            this.txtOperation2 = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.labOperand1 = new System.Windows.Forms.Label();
            this.labOperand2 = new System.Windows.Forms.Label();
            this.labOperator = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.panelResultMode = new System.Windows.Forms.Panel();
            this.radioDecimalResultMode = new System.Windows.Forms.RadioButton();
            this.radioBinaryResultMode = new System.Windows.Forms.RadioButton();
            this.labResultMode = new System.Windows.Forms.Label();
            this.panelResultMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(330, 302);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOperation1
            // 
            this.txtOperation1.Location = new System.Drawing.Point(167, 91);
            this.txtOperation1.Name = "txtOperation1";
            this.txtOperation1.Size = new System.Drawing.Size(427, 25);
            this.txtOperation1.TabIndex = 1;
            // 
            // txtOperation2
            // 
            this.txtOperation2.Location = new System.Drawing.Point(167, 181);
            this.txtOperation2.Name = "txtOperation2";
            this.txtOperation2.Size = new System.Drawing.Size(427, 25);
            this.txtOperation2.TabIndex = 3;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(167, 140);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(427, 23);
            this.cmbOperator.TabIndex = 5;
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(167, 255);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(427, 25);
            this.resultTxt.TabIndex = 6;
            // 
            // labOperand1
            // 
            this.labOperand1.AutoSize = true;
            this.labOperand1.Location = new System.Drawing.Point(87, 94);
            this.labOperand1.Name = "labOperand1";
            this.labOperand1.Size = new System.Drawing.Size(68, 15);
            this.labOperand1.TabIndex = 7;
            this.labOperand1.Text = "operand1";
            // 
            // labOperand2
            // 
            this.labOperand2.AutoSize = true;
            this.labOperand2.Location = new System.Drawing.Point(87, 184);
            this.labOperand2.Name = "labOperand2";
            this.labOperand2.Size = new System.Drawing.Size(68, 15);
            this.labOperand2.TabIndex = 8;
            this.labOperand2.Text = "operand2";
            // 
            // labOperator
            // 
            this.labOperator.AutoSize = true;
            this.labOperator.Location = new System.Drawing.Point(89, 143);
            this.labOperator.Name = "labOperator";
            this.labOperator.Size = new System.Drawing.Size(61, 15);
            this.labOperator.TabIndex = 9;
            this.labOperator.Text = "operator";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(94, 258);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(42, 15);
            this.labResult.TabIndex = 10;
            this.labResult.Text = "result";
            // 
            // panelResultMode
            // 
            this.panelResultMode.Controls.Add(this.radioDecimalResultMode);
            this.panelResultMode.Controls.Add(this.radioBinaryResultMode);
            this.panelResultMode.Location = new System.Drawing.Point(167, 34);
            this.panelResultMode.Name = "panelResultMode";
            this.panelResultMode.Size = new System.Drawing.Size(427, 31);
            this.panelResultMode.TabIndex = 11;
            // 
            // radioDecimalResultMode
            // 
            this.radioDecimalResultMode.AutoSize = true;
            this.radioDecimalResultMode.Location = new System.Drawing.Point(244, 3);
            this.radioDecimalResultMode.Name = "radioDecimalResultMode";
            this.radioDecimalResultMode.Size = new System.Drawing.Size(79, 19);
            this.radioDecimalResultMode.TabIndex = 1;
            this.radioDecimalResultMode.TabStop = true;
            this.radioDecimalResultMode.Text = "Decimal";
            this.radioDecimalResultMode.UseVisualStyleBackColor = true;
            // 
            // radioBinaryResultMode
            // 
            this.radioBinaryResultMode.AutoSize = true;
            this.radioBinaryResultMode.Location = new System.Drawing.Point(103, 3);
            this.radioBinaryResultMode.Name = "radioBinaryResultMode";
            this.radioBinaryResultMode.Size = new System.Drawing.Size(69, 19);
            this.radioBinaryResultMode.TabIndex = 0;
            this.radioBinaryResultMode.TabStop = true;
            this.radioBinaryResultMode.Text = "Binary";
            this.radioBinaryResultMode.UseVisualStyleBackColor = true;
            // 
            // labResultMode
            // 
            this.labResultMode.AutoSize = true;
            this.labResultMode.Location = new System.Drawing.Point(67, 39);
            this.labResultMode.Name = "labResultMode";
            this.labResultMode.Size = new System.Drawing.Size(83, 15);
            this.labResultMode.TabIndex = 4;
            this.labResultMode.Text = "result mode";
            // 
            // CalculatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labResultMode);
            this.Controls.Add(this.panelResultMode);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.labOperator);
            this.Controls.Add(this.labOperand2);
            this.Controls.Add(this.labOperand1);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtOperation2);
            this.Controls.Add(this.txtOperation1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CalculatorControl";
            this.Size = new System.Drawing.Size(700, 378);
            this.Load += new System.EventHandler(this.CalculatorControl_Load);
            this.panelResultMode.ResumeLayout(false);
            this.panelResultMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtOperation1;
        private System.Windows.Forms.TextBox txtOperation2;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Label labOperand1;
        private System.Windows.Forms.Label labOperand2;
        private System.Windows.Forms.Label labOperator;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Panel panelResultMode;
        private System.Windows.Forms.Label labResultMode;
        private System.Windows.Forms.RadioButton radioDecimalResultMode;
        private System.Windows.Forms.RadioButton radioBinaryResultMode;
    }
}

