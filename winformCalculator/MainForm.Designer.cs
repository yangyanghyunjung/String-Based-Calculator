namespace winformCalculator
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxConvertMode = new System.Windows.Forms.CheckBox();
            this.cbxMode = new System.Windows.Forms.CheckBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxConvertMode);
            this.panel1.Controls.Add(this.cbxMode);
            this.panel1.Location = new System.Drawing.Point(279, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 37);
            this.panel1.TabIndex = 0;
            // 
            // cbxConvertMode
            // 
            this.cbxConvertMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxConvertMode.AutoSize = true;
            this.cbxConvertMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxConvertMode.Location = new System.Drawing.Point(122, 3);
            this.cbxConvertMode.Name = "cbxConvertMode";
            this.cbxConvertMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxConvertMode.Size = new System.Drawing.Size(110, 25);
            this.cbxConvertMode.TabIndex = 3;
            this.cbxConvertMode.Text = "Convert Mode";
            this.cbxConvertMode.UseVisualStyleBackColor = true;
            this.cbxConvertMode.CheckedChanged += new System.EventHandler(this.cbxConvertMode_CheckedChanged);
            // 
            // cbxMode
            // 
            this.cbxMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxMode.AutoSize = true;
            this.cbxMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMode.Location = new System.Drawing.Point(6, 3);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Size = new System.Drawing.Size(119, 25);
            this.cbxMode.TabIndex = 2;
            this.cbxMode.Text = "Calculate Mode";
            this.cbxMode.UseVisualStyleBackColor = true;
            this.cbxMode.CheckedChanged += new System.EventHandler(this.cbxMode_CheckedChanged);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(12, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(776, 338);
            this.panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.CheckBox cbxMode;
        private System.Windows.Forms.CheckBox cbxConvertMode;
    }
}