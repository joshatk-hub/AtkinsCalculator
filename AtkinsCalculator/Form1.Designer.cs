namespace AtkinsCalculator
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
            txtDisplay = new TextBox();
            btnBack = new Button();
            btnClear = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btnSign = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnPoint = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnSqrt = new Button();
            btnReciprocal = new Button();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(199, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 41);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Backspace";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(143, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(68, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 70);
            btn7.Name = "btn7";
            btn7.Size = new Size(35, 35);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 111);
            btn4.Name = "btn4";
            btn4.Size = new Size(35, 35);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 152);
            btn1.Name = "btn1";
            btn1.Size = new Size(35, 35);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 193);
            btn0.Name = "btn0";
            btn0.Size = new Size(35, 35);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(53, 70);
            btn8.Name = "btn8";
            btn8.Size = new Size(35, 35);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(53, 111);
            btn5.Name = "btn5";
            btn5.Size = new Size(35, 35);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(53, 152);
            btn2.Name = "btn2";
            btn2.Size = new Size(35, 35);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(53, 193);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(35, 35);
            btnSign.TabIndex = 10;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(94, 70);
            btn9.Name = "btn9";
            btn9.Size = new Size(35, 35);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(94, 111);
            btn6.Name = "btn6";
            btn6.Size = new Size(35, 35);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(94, 152);
            btn3.Name = "btn3";
            btn3.Size = new Size(35, 35);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(94, 193);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(35, 35);
            btnPoint.TabIndex = 14;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(135, 70);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(35, 35);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(135, 111);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(35, 35);
            btnMultiply.TabIndex = 16;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(135, 152);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(35, 35);
            btnSubtract.TabIndex = 17;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(135, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(35, 35);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(176, 70);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(35, 35);
            btnSqrt.TabIndex = 19;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Location = new Point(176, 111);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(35, 35);
            btnReciprocal.TabIndex = 20;
            btnReciprocal.Text = "1/X";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(176, 152);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(35, 76);
            btnEquals.TabIndex = 22;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 238);
            Controls.Add(btnEquals);
            Controls.Add(btnReciprocal);
            Controls.Add(btnSqrt);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnPoint);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnSign);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnBack;
        private Button btnClear;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btnSign;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btnPoint;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnSqrt;
        private Button btnReciprocal;
        private Button button19;
        private Button btnEquals;
    }
}
