namespace Calculator
{
    partial class Form1
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
            panel1 = new Panel();
            textBoxDisplay = new TextBox();
            panel2 = new Panel();
            buttonDot = new Button();
            buttonCalculate = new Button();
            buttonDivide = new Button();
            buttonMultiply = new Button();
            buttonSubtract = new Button();
            buttonAdd = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonDelChar = new Button();
            buttonReset = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDisplay);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 61);
            panel1.TabIndex = 0;
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Dock = DockStyle.Fill;
            textBoxDisplay.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDisplay.Location = new Point(0, 0);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.ReadOnly = true;
            textBoxDisplay.RightToLeft = RightToLeft.No;
            textBoxDisplay.Size = new Size(331, 57);
            textBoxDisplay.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonDot);
            panel2.Controls.Add(buttonCalculate);
            panel2.Controls.Add(buttonDivide);
            panel2.Controls.Add(buttonMultiply);
            panel2.Controls.Add(buttonSubtract);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(button0);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonDelChar);
            panel2.Controls.Add(buttonReset);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 269);
            panel2.TabIndex = 1;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(165, 211);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(75, 46);
            buttonDot.TabIndex = 18;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(246, 211);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 46);
            buttonCalculate.TabIndex = 17;
            buttonCalculate.Text = "=";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(246, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 46);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonOperation_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(246, 55);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 46);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonOperation_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(246, 107);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(75, 46);
            buttonSubtract.TabIndex = 14;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonOperation_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(246, 159);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 46);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonOperation_Click;
            // 
            // button0
            // 
            button0.Location = new Point(84, 211);
            button0.Name = "button0";
            button0.Size = new Size(75, 46);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonNumber_Click;
            // 
            // button9
            // 
            button9.Location = new Point(165, 55);
            button9.Name = "button9";
            button9.Size = new Size(75, 46);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonNumber_Click;
            // 
            // button8
            // 
            button8.Location = new Point(84, 55);
            button8.Name = "button8";
            button8.Size = new Size(75, 46);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNumber_Click;
            // 
            // button7
            // 
            button7.Location = new Point(3, 55);
            button7.Name = "button7";
            button7.Size = new Size(75, 46);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(165, 107);
            button6.Name = "button6";
            button6.Size = new Size(75, 46);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumber_Click;
            // 
            // button5
            // 
            button5.Location = new Point(84, 107);
            button5.Name = "button5";
            button5.Size = new Size(75, 46);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 107);
            button4.Name = "button4";
            button4.Size = new Size(75, 46);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonNumber_Click;
            // 
            // button3
            // 
            button3.Location = new Point(165, 159);
            button3.Name = "button3";
            button3.Size = new Size(75, 46);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(84, 159);
            button2.Name = "button2";
            button2.Size = new Size(75, 46);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNumber_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 46);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNumber_Click;
            // 
            // buttonDelChar
            // 
            buttonDelChar.Location = new Point(84, 3);
            buttonDelChar.Name = "buttonDelChar";
            buttonDelChar.Size = new Size(75, 46);
            buttonDelChar.TabIndex = 1;
            buttonDelChar.Text = "<<<";
            buttonDelChar.UseVisualStyleBackColor = true;
            buttonDelChar.Click += buttonDelChar_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(3, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 46);
            buttonReset.TabIndex = 0;
            buttonReset.Text = "C";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 332);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxDisplay;
        private Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonDelChar;
        private Button buttonReset;
        private Button buttonDot;
        private Button buttonCalculate;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonSubtract;
        private Button buttonAdd;
        private Button button0;
        private Button button9;
        private Button button8;
    }
}