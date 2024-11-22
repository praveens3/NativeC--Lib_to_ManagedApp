namespace TestApp
{
    partial class TestAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputBox1 = new TextBox();
            inputBox2 = new TextBox();
            outputBox1 = new TextBox();
            labelEqual = new Label();
            mathOperatorcombobox = new ComboBox();
            calcButton = new Button();
            SuspendLayout();
            // 
            // inputBox1
            // 
            inputBox1.Location = new Point(128, 185);
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(100, 23);
            inputBox1.TabIndex = 0;
            inputBox1.KeyPress += inputBox1_KeyPress;
            // 
            // inputBox2
            // 
            inputBox2.Location = new Point(292, 185);
            inputBox2.Name = "inputBox2";
            inputBox2.Size = new Size(100, 23);
            inputBox2.TabIndex = 1;
            inputBox2.KeyPress += inputBox2_KeyPress;
            // 
            // outputBox1
            // 
            outputBox1.Location = new Point(440, 185);
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(100, 23);
            outputBox1.TabIndex = 2;
            // 
            // labelEqual
            // 
            labelEqual.AutoSize = true;
            labelEqual.Location = new Point(408, 188);
            labelEqual.Name = "labelEqual";
            labelEqual.Size = new Size(15, 15);
            labelEqual.TabIndex = 3;
            labelEqual.Text = "=";
            // 
            // mathOperatorcombobox
            // 
            mathOperatorcombobox.FormattingEnabled = true;
            mathOperatorcombobox.Items.AddRange(new object[] { "+", "x" });
            mathOperatorcombobox.Location = new Point(244, 185);
            mathOperatorcombobox.Name = "mathOperatorcombobox";
            mathOperatorcombobox.Size = new Size(32, 23);
            mathOperatorcombobox.TabIndex = 4;
            mathOperatorcombobox.SelectedIndex = 0;

            // 
            // calcButton
            // 
            calcButton.Location = new Point(569, 185);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(75, 23);
            calcButton.TabIndex = 5;
            calcButton.Text = "Calculate";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // TestAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcButton);
            Controls.Add(mathOperatorcombobox);
            Controls.Add(labelEqual);
            Controls.Add(outputBox1);
            Controls.Add(inputBox2);
            Controls.Add(inputBox1);
            Name = "TestAppForm";
            Text = "TestApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox1;
        private TextBox inputBox2;
        private TextBox outputBox1;
        private Label labelEqual;
        private ComboBox mathOperatorcombobox;
        private Button calcButton;
    }
}
