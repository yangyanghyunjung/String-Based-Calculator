namespace winformCalculator
{
    partial class ConverterControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cmbConvertType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Location = new System.Drawing.Point(343, 249);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(180, 148);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(427, 25);
            this.txtNum.TabIndex = 2;
            // 
            // cmbConvertType
            // 
            this.cmbConvertType.FormattingEnabled = true;
            this.cmbConvertType.Items.AddRange(new object[] {
            "Binary to Decimal",
            "Binary to Hex",
            "Decimal to Binary",
            "Decimal to Hex",
            "Hex to Binary",
            "Hex to Decimal"});
            this.cmbConvertType.Location = new System.Drawing.Point(180, 90);
            this.cmbConvertType.Name = "cmbConvertType";
            this.cmbConvertType.Size = new System.Drawing.Size(427, 23);
            this.cmbConvertType.TabIndex = 6;
            // 
            // ConverterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbConvertType);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnConvert);
            this.Name = "ConverterControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cmbConvertType;
    }
}